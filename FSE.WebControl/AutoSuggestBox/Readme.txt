++++++++++++++
AutoSuggestBox

Version 1.5.4
Aug 7 2006
++++++++++++++


Release Notes
=============

Ver 1.5.4
	* Fixed a bug with AutoSuggestBox not working in ATLAS's UpdatePanel
	
Ver 1.5.3
	* Fixed a javascript bug that occured if user would type single quote (') into
	  ASB TextBox.
	* Fully disabled cache on 'GetAutoSuggestData.aspx' page by adding line:
		Response.Cache.SetCacheability(HttpCacheability.NoCache);

	  Removed line
		<%@ OutputCache Duration="1" VaryByParam="None" %>
	  which would cache the page for 1 second.
	  
	  
Ver 1.5.2
	* Fixed an issue with AutoSuggestBox menu being displayed after
	  user tabbed out from the control.  That would happen if user
	  would type a couple of characters really fast and then click on
	  'Tab' key.  The menu would get displayed even though text box did
	  not have focus any longer.

Ver 1.5.1
	* Disabled caching on GetAutoSuggestData by adding
	  <%@ OutputCache Duration="1" VaryByParam="None" %>

	* Added OnBlur to JSAutoSuggestBox, so it could be easily overriden
	  

Ver 1.5.0

 	* Support for VS 2005.  Provided two more downloads - for C# and VB.

	* Added new properties to AutoSuggextBox control:
		MaxSuggestChars  
			-  number of characters that trigger suggestion menu
				(defaults to 5)
        	
		KeyPressDelay    
			-  milliseconds to wait for next key stroke before 			   
			   displaying sugesstions. Can be used to
			   minimize number of database queries if 
			   user types quickly.
				(defaults to 300)
		
		NumMenuItems
			- number of menu items that will appear in suggest menu
				(defaults to 10)

        	IncludeMoreMenuItem 
			- indicates if '...' menu item should be added to
			  the bottom of the list if there are more suggestions
			  then NumMenuItems
			(defaults to false)

         	MoreMenuItemLabel 
			- Label of menu item that indicates that not all 
			  suggestions were displayed
			(defaults to '...')
		
		UseIFrame
			- Indicates that IFrame should be used in Internet Explorer
			  so SELECT controls overlapping suggest menu don't 
  			  appear in front of it
			(default to true)

		MenuCSSClass
			- controls how the menu is displayed
			(defaults to 'asbMenu')

		MenuItemCSSClass
			- controls how menu items are displayed
			(defaults to 'asbMenuItem')


		SelMenuItemCSSClass
			- controls how selected menu item is displayed
			(defaults to 'asbSelMenuItem')
 

	* Changed javascript to use objects.  There is now a JSAutoSuggestBox 	  
	  object for every AutoSuggestBox displayed on the page
	
	* AutoSuggestBox now supports absolute positioning in CSS

	* Verified support for Mac:
		Firefox -- Works
		IE  -- Doesn't work in  
		   (Microsoft will not be supporting this app in near future)
		Safari -- works except using up and down keys to select menu items

	* Switched to using div attribute to store value of each menu item 
	  instead of using hidden field

	* SelectedValue property is now read/write
	
	* Added ViewState loading/saving to the control, so that control attribute 
	  values persist after submitting the form.

	* Included Blank.html to fix the problem with warning message in IE.  See
	  the following link for more information:
		http://support.microsoft.com/default.aspx?scid=kb;en-us;261188
		
		
Ver 1.0.1

	* Fixed a bug that disabled suggest menu in FireFox when control was 
	  used in User Control

	* Added new feature where manually modifying text in text box will now
	  reset the value of AutoSuggestBox.SelectedValue


Ver 1.0.0

	* Original release




Known Issues
============

1. Mac Safari - navigating in suggestions menu using key presses doesn't work




Documentation 
=============

All documentation is available at the following Url:
	
http://www.autosuggestbox.com/Documentation.aspx
