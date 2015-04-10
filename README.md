# Simple.Wpf.Exceptions

This isn't a definitive guide or 'proper' way to do exception handling in a WPF application (if there is one), it's my way of dealing with unhandled exceptions. To many times I come across WPF applications which have either no or incomplete exception handling - typically observed as an application that just terminates unexpectedly without giving the user any info about why it crashed, and no easy way to report what happened to first line IT support.

In my opinion when an unhandled exception occurs, an application should do the following:

* Show the exception message (not the full stack info),
* Offer the user the explicit opportunity to copy the message (for us in an email conversation with support),
* Easy access to the log file folder (makes it easier to attach log file to any email conversation with support),
* Opportunity to terminates the application,
* Opportunity to restart the application,
* Opportunity to continue with current session of the application - obivously this mean possible invalid state etc.

This approach targets version 4.0 of the Mircosoft .Net framework.
