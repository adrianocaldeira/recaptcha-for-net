###################################################################
reCAPTCHA for .Net
###################################################################

===================================================================
Configuration
===================================================================

After installation you must configure the web.config file of your application with data from its reCAPTCJA account, as shown below:

<configSections>
	<section name="recaptcha" type="Recaptcha4Net.ConfigurationSection, Recaptcha4Net" />
</configSections>

<recaptcha site="YOUR SITE KEY" secret="YOUR SECRET KEY"/>

More information visit https://github.com/adrianocaldeira/recaptcha4net.