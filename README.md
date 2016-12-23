# IdentityPlus
ASP.NET EF Identity extending Users in C#

I had to extend the EntityFramework Identity schema, 
basically creating a relationship one-to-one between Users and my "Persons" table.

I googled a lot, found a bunch of people with the SAME problem, some ideas, 
most of them too complicated and other just don't work.

So, using Visual Studio Community Edition 2017 RC and most recent version of NuGet packages (in Dec 2016), 
I've merged ideas and working solutions to create this demo.

A few parts are in Brazilian Portuguese:
- Pessoa as "Person"
- PrimeiroNome as "GivenName" ("first name" literally)
- Sobrenome as "Surname"
- NomeCompleto as "FullName"

Enjoy

This version of README is really poor... Working on that...

Last but definitelly not least, I'd like to leave here come links with the articles and ideas 
that I've compiled do create this demo
(thanks for sharing, all or you, authors!!!)

(Simple and effective!)
http://www.itorian.com/2013/11/customizing-users-profile-to-add-new.html

(Great!!!!!! Lots of ideas and lessons!)
https://github.com/rustd/AspnetIdentitySample

http://stackoverflow.com/questions/22297097/how-to-add-a-foreign-key-reference-to-asp-net-mvc-5-identity

Great tutorials - in Portuguese
http://www.eduardopires.net.br/2014/03/asp-net-identity-customizando-cadastro-usuarios/ 
http://www.eduardopires.net.br/2015/02/customizando-nomes-tabelas-campos-asp-net-identity/

