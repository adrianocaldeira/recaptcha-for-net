## reCAPTCHA for .Net

Integration library with reCAPTCHA for security check

##What is reCAPTCHA?

reCAPTCHA is a free service to protect your website from spam and abuse. reCAPTCHA uses an advanced risk analysis engine and adaptive CAPTCHAs to keep automated software from engaging in abusive activities on your site. It does this while letting your valid users pass through with ease.

reCAPTCHA offers more than just spam protection. Every time our CAPTCHAs are solved, that human effort helps digitize text, annotate images, and build machine learning datasets. This in turn helps preserve books, improve maps, and solve hard AI problems.

More information visit https://www.google.com/recaptcha/intro/index.html

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

##<a name="release-notes"></a>Release Notes

- Versão 1.0.0
	- First version.