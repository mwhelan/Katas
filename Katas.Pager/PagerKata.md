# Page Kata #

Source: [Tomek Kaczanowski](http://kaczanowscy.pl/tomek/2013-04/code-kata-pager)

The kata is about the writing of the underlying data model for a pager control (NOT about the presentation). What you should create is a class (bunch of classes) which is smart enough to provide all the data required to actually render the links to pages.

![pager control](pager.png)

So, the pager gets the following data as input:

- total number of items
- page size. That is, number of items per page
- offset e.g. 4680, which means that the user has already flipped through 234 pages (20 items each) 
- current page number e.g. 234 (which in fact is the same information)

Given this data pager should be able to answer the following questions:

- how many pages are there? e.g. total records / records per page,
- should prev/next link be visible? e.g. prev button should not be visible when user is on the first page,
- which links to print? e.g. when user is on 25th page, then links to 24, 25 and 26 should be printed,
- which page is current? so we could bold/highlight it's number (and remove the link).
- And so on.


