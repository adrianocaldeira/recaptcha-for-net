## reCAPTCHA for .Net

## <a name="instacao"></a>Installation

To install, run the following command in <a href="http://docs.nuget.org/docs/start-here/using-the-package-manager-console#Installing_a_Package" target="_blank">Package Manager Console</a>.

<img src="https://raw.githubusercontent.com/adrianocaldeira/recaptcha4net/master/nuget.png"/>

## <a name="instacao"></a>Configuration

After installation you must configure the web.config file of your application with data from its reCAPTCJA account, as shown below:

```xml
<configSections>
	<section name="recaptcha" type="Recaptcha4Net.ConfigurationSection, Recaptcha4Net" />
</configSections>

<recaptcha site="YOUR SITE KEY" secret="YOUR SECRET KEY"/>
```

More information visit https://github.com/adrianocaldeira/recaptcha4net.

##<a name="release-notes"></a>Release Notes

- Versão 1.0.0
	- First version.