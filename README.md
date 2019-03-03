# Cucumber

## 1. Details	of	applications,	frameworks	etc.	required	to	run	your	solution

The application is built using .net core.

The frontend of the application is built using bootstrap 4 framework.

I have used github for source control. Azure is used as a hosting platform, kudu is used as a build tool.

## 2. Detailed	instructions	on	how	to	install,	configure	and	execute	your	solution

To run the solution you would need to install
[dotnet core sdk](https://dotnet.microsoft.com/download)
[git command line tools](https://git-scm.com/downloads)

<em>open terminal</em><br>
<em>***exec*** git clone https://github.com/dinesh46/Cucumber.git</em><br>
<em>***exec*** dotnet run</em><br>

## 3. Technical	description	and	explanation	of	design	and	programming	techniques	utilised

.net core is a cross platform version of .net. 

MVC architecture is used as its very simple to setup multiple page website. 

Model validation are done using data annotations.

Have written a static class which can convert 12 place number to currency format. if failed to the program returns "Zero".

Recursive functions are used to in place to convert places to words.