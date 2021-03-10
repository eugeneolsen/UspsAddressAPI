# CityStateLookup
CityStateLookup is a small WinForms application that calls the United States Postal Service Address API.  It is designed and built using a _very_ simple implementation of the Model-View-Presenter (MVP) pattern. 
It's main purpose is to showcase some my development skills and thought processes.

## WinForms MVP
There are a number of examples of MVP for Windows Forms (aka WinForms) of varying complexity on the web.   WinForms is an aging but not obsolete technology: 
Microsoft is including WinForms support in .NET 6.  There is a place for WinForms in new development for leading-edge technologies.

The primary goals of the Model-View-Presenter pattern are:
1. Separation of the user interface from business logic from data.
2. Potential for reusable logic.
3. Possibility of changing the UI or adding different kinds of input without distrubing the business logic.
4. Ability to add automated unit testing to a GUI application.

Separating the UI from the processing logic can make code clearer and easier to maintain, but one of the greatest benefits of MVP 
is to enable self-testing code and test-driven development (TDD) for applications with user interfaces.
Martin Fowler, noted author on software pattens and practices, discusses this in his essay on [GUI Architectures](https://www.martinfowler.com/eaaDev/uiArchs.html).

### The Model
In our CityStateLookup application, the model is the city and state information returned by the United States Postal Service Address API.  
The XML response from the USPS Web API is a \<CityStateLookupResponse> element containing 1 to 5 \<ZipCode> elements or an \<Error> element.
The \<ZipCode> element contains an ID attribute, a \<City>, \<State>, and \<Zip5> element.
The \<Error> element contains a \<Number> and a \<Description> element.
These are all documented in greater detail at [Address Information USPS Web Tools API User's Guide](https://www.usps.com/business/web-tools-apis/address-information-api.htm).
Scroll to the bottom of the web page for the City/State Lookup documentation and example.

**Note** that the USPS CityStateLookupRequest requires an ID, which can be obtained at the [USPS Web Tools API Portal](https://www.usps.com/business/web-tools-apis/welcome.htm).

Perhaps this model isn't really a true model in the strictest sense, but the application is structured to accomodate such.

### The View
The view consists of bare-bones WinForm code.   The default Form1 has been renamed to MainView.   
All business logic, with the exception of some rudimentary length and numeric checking for the ZIP Code input, is handled by the Presenter.
An Interface IMainView gives the Presenter access to the City, State, and Zip properties of the View.

### The Presenter
The Presenter class, MainPresenter, builds a request for the USPS Address API and submits it using an asynchronous HttpRequest so as not to block the UI. The Presenter then parses the response, whether City and State or an error.  

The Presenter is instantiated, as is customary, by the View, which passes a reference to the IMainView interface to the Presenter, as is also customary with the Model-View-Presenter pattern.  This interface is used by the Presenter to update the View.

Rather than attempt XML deserialization, the Presenter parses the response XML using the Linq to XML XDocument class.  After long and sometimes painful experience, the author firmly believes that XML from third parties, over which the developer has no control, should generally _not_ be deserialized with the XmlSerializer class, but rather, with XmlReader, XmlDocument, or XDocument.

#### Unit Tests
With the business logic separated from the data and the user interface, creating unit tests not only becomes possible, but also easy.  The [xUnit](https://xunit.net) tool was chosen for this project.  Unit tests can be found in the file UnitTests.cs.

## Other Considerations

### Configuration
The appSettings values are wrapped in a Singleton class, defined in Config.cs, and globally accessible.  The configuration wrapper class follows the Singleton pattern because the configuration settings collection is a Singleton in real life.   I have seen code limited in its reusability because  an interface to the configuration values is (needlessly) passed in to class constructors.   The same goes for logging classes: there is usually only one log.   Even if there are multiple logs, each log is written only one place, and therefore each log should arguably be wrapped in a Singleton class.

### Literal Strings
Most constants, whether numbers or character strings, become the source of a bug sooner or later.  To avoid their becoming bugs, such constants are best placed in configuration files or resource files.  I possibly went overboard in putting nearly all literal strings, including appSettings keys, in the application's string table.
