## Status
Due to the release of .NET Core 2, and the supporting libraries, I am going to branch and retire the root.
I'll use this repository to manage the new library, which will focus on being .NET Standars, and keep to pure standards. Meaning a lot of .NET Standard libraries are nothing more than Framework based code, so it messes up the Core deployments.

Since I just lived through that, I won't subject other to that.

Expect a new branch in Q3 2018

## CommonNET

A slowly building collection of my common libraries.

* Common.Data.SqlClient - Shortcuts and common code for SQL data readers and commands
* Common.Reflection - Shortcuts for handling some of the most used reflections in .NET.
* Common.DateTimeOffset.Extender - Handle DateTimeOffset change of TimeZone, and a couple more related methods.
  * This is obsoleted code. Just GOOGLE: "DateTimeOffset Change Timezone". Don't Bing it, the results will be useless.
* Common.String.StringDictionaryHelper - Provides casting shortcuts for Dictionary<string,string> objects that are pretty common for websites.
* Common.Reflection.AttributeReader - Simplifies the reading of an object's attributes in runtime.
* Common.String.StringUtilities - More common string utilities for working with web development.
* Common.XMLTools - Shortcut for getting nodes from an XPath being applied to current node. I may make a version of this for jSON later.
* Common.Image.Tools - Encodes bitmaps into base 64 strings so that you can embed them into your CSS and HTML.
* JsonNetResult - for those of use who like the JSon.NET library better than the MS library.
* NoCache - An Attribute that can be added to an MVC function that tells IIS do not cache.
* More to come
