# Ipify.NET

**An unofficial client library for `ipify <http://www.ipify.org>`: *A Simple IP Address API*.**

##Meta

- Author: David Musgrove
- Email: david@musgroves.us
- Status: maintained, active

##Purpose

This library makes getting your public IP address from .NET languages extremely simple using ipify's api.

##Installation

Install ``Ipify.NET`` using NuGet.

##Usage

Using this library is very simple. Here's a simple example:

```cs
using System;

using Ipify;

class Program
{
    static void main(string[] args)
	{
		Console.WriteLine(Ipify.GetAddress());
	}
}
```

##Change Log

All library changes, in descending order.

####Version 1.0.0

**Release Sep 23, 2015**

- First release
