DotNetNuke - Forum

PLEASE READ CAREFULLY!

Clean Installation:
- Install this module as any other DNN private assembly. 

Upgrade: 
- Same as installation just note that upgrades are only supported from core version 03.00.00 forward.
- It is STRONGLY recommended that if you are upgrading from a version prior to 04.04.03 that you check all admin settings and per forum permissions after upgrade. There were major changes and additions and you should review all settings to ensure the forum operates as you expect. In fact, before upgrading module you should disable access to your forum pages except for administrators. You should also remove edit module permissions for all users except administrators (or roles you want to act as administrators). This is especially important for those in "Registered Users" role. Please check module as Registered User role only before opening to public to ensure permissions are properly set. 

Source Notes:
- If using SOURCE, you can now install as a normal module.
- The DotNetNuke.Forums.build file in SOURCE can be used to build source and install packages via nAnt.  This will package the module they way this sub-project team does for release.  Notice the only difference is module version needs adjusted to two digits at end xx.xx.xx.


Main Notes:
** NOTE: You must have visual studio 2005 and the web application projects plugin (or vs 2005 sp1) installed in order to develop the module. 

CHANGES WHICH ARE COMING AND WILL AFFECT A FUTURE RELEASE (To Do):

- FOR-XXXX - Skinning Engine
- FOR-XXXX - Ajax Integration


Version 04.04.02

CHANGES/ENHANCEMENTS/BUGS:

FOR-2334 - Moderator Auditing - Exposed in seperate forum extension (Forum.TopModerators)
FOR-2372 - Member Directory exposed to users for first time. (Similar to contact directory)
FOR-2331 - Added Report Post ability.
FOR-2332 - Created IEmailQueueable for task scheduling of email sends. (Bulk sending in seperate thread using generic interface)
FOR-2371 - Added Private Messaging System.
FOR-3302 - Fixed word filter so it checks for empty string (validators) and make sure word attempting to add doesn't already exist.
FOR-3690 - All search is now filtered for SQL Injection attacks. None seemed to be possible in previous versions, but this will ensure that continues in future versions.
FOR-4040 - Fixed bug exposed by SQL Server 2005 using "My Posts" or searches.
FOR-4041 - Reworked search a bit to provide better results.
FOR-4115 - Moderator By Role (in addition to by user) this required a permission grid set similar to how module level permissions are handled but using another table too. (re
FOR-4116 - Moved per user settings security (moderator per forum) to new security class for single point of access control. Also handled per ModuleID now (meaning no more IsModerator).
FOR-4117 - Removed Gallery Integration Project.
FOR-4118 - Removed Forum Popup Project and replaced w/ DNNTextSuggest, DNNTree, New Permission Grid.
FOR-4119 - Using Core Permissions Grid for module permission control instead of requiring Registered Users to be in Edit Module roles.
FOR-4120 - Updated User Management to mimic core User Management, Includes ability to manage Forum Users that never visited the forum module.
FOR-4140 - Moved Statistics to seperate module. (Forum.TopThreads & Forum.TopUsers)
FOR-4121 - Moved the Forum Email Template System to the database. (Now allows editable subject, HTML body, Text body per template type)
FOR-4122 - Added TemplateType table. (Primarily for emails, open for expansion later)
FOR-4123 - Added Keyword Rendering System. (Primarily for Emails, open for expansion later)
FOR-4124 - Added Email Template Management UI. (Set at portal level using install default templates for each portal to start with)
FOR-4125 - Added check to make sure forum exists when retrieving RSS feeds, to avoid error by manual entry of forumid in querystring or deleted forum.
FOR-4126 - Added HTML/Text Email format per user for email notifications
FOR-4127 - Applied enhancement to change page title to post subject which allows better indexing by web crawlers.
FOR-4130 - Added Thread Status. This allows user to set an unresolved, resolved, informative, not specified status per post. This can be edited by the original thread author and moderators. It is enabled at the module level and can then be turned on/off at the specific forum level. (You can also set which post was the answer to help others) Also added this in threads view UI.
FOR-4131 - Altered the next/previous thread buttons and placed at top and bottom of post view pages. (Auto enable/disalbe to provide consistent UI)
FOR-4132 - Refined use of caching. (To use proper core pattern)
FOR-4133 - Refactored Info objects, use of caching, reduce database calls to improve performance.
FOR-4134 - Removed Statistics area from footer options, this is now handled as a seperate module. (Removed Stats/Footer area)
FOR-4135 - Removed What's New from footer options, this is now handled as a seperate module. (Removed Stats/Footer area)
FOR-4136 - Added ability to split threads.(Selecting which posts to take with it)
FOR-4137 - Duplicated URLController from core to create an avatar control. (Re
FOR-4138 - Sub Avatar management for Emoticon management.
FOR-4139 - Made What's New its own module. This allows users to place anywhere they wish. (Forum Add
FOR-4143 - Changed how avatars work, no longer using gallery project. (Using modules new URLController)
FOR-4145 - Deleted User Critical Bug
FOR-4146 - ReplaceCaseInsensitive Method - Null checking
FOR-4147 - GetWords Caching Code Pattern
FOR-4149 - GetUser - Caching Code Pattern
FOR-4151 - Changed response.redirect(string) to response.redirect(string, Boolean) to avoid Thread was being aborted erors.
FOR-4153 - Add DateAPproved Column on Posts table - Search Indexing
FOR-4260 - Forum display fails for Active Directory Validated Users.
FOR-4801 - Corrected bug where users can manually edit forumid in querystring to post in restricted posting forums.
FOR-4802 - Added ability to make all users trusted by default.
FOR-4803 - Corrected many UI issues (Cross
FOR-4804 - Changed paging logic to handle users coming directly to a post. (Regardless of their view, should see right post) Changed links to handle this.
FOR-4805 - Added search from post view for that particular forum.
FOR-4806 - Changed "Mark Threads Read" checkbox to a linkbutton for usability reasons.
FOR-4807 - Removed all items around involving xml templates, forum template control, forum menu, Resources folder.
FOR-4808 - Changed thread ratings scale from 0
FOR-4809 - Changed user post level rankings from 1
FOR-4810 - Made source distro package installable as normal PA installable module. (means vb files and all project related files are included in package too)
FOR-4811 - Added new theme, Default, changed default theme to this theme in pre
FOR-4812 - Changed it so adding/updating a forum takes you back to the manage forums/groups screen.
FOR-4813 - Added new series of thread status icons for various thread options.
FOR-4814 - Added Private Moderated Forum Icons w/ new/old Status.
FOR-4815 - Added Aggregated Forum Icon.
FOR-4816 - Fixed bug shown when all forums were deleted from a module instance.
FOR-4817 - Fixed bug where selecting a rating did not post back the updated rating image.
FOR-4818 - Made forum user profile dependant on PortalID. This allows for use across multiple portals and each user having a profile based on that portal.
FOR-4819 - Converted development base to ASP.NET 2.0 WAP Project. (includes reorganization, combining w/ dataprovider project, minimizing warnings)
FOR-4821 - Cleaned up localization.
FOR-4822 - Started XHTML compliance changes.
FOR-4823 - Added ability to select a default forum at the tabmodule level, removed from forum config. (Previously done by simply ModuleID)
FOR-4824 - Added Ability to select Aggregated as a Default Group in TabModuleSettings.
FOR-4885 - Made forum name links in Search/MyPosts/Aggregated Forum View clickable links.
FOR-4886 - Added 100 character description of last post when over its link in thread view, search results view. (As Title of link)
FOR-5385 - Added ability to copy permissions from an existing forum and apply to a different forum.
FOR-5386 - Added "Link" type forums, which are just links to a url. Uses core URL Control.
FOR-5388 - Add search variable "Thread Status".
FOR-5389 - Add transparent png support using javascript (for IE 5.5 or 6 versions)
FOR-5390 - Added ability for administrators to change title (tooltip) displayed for rankings.
FOR-5391 - Added ability for administrators to set if they want to use icon or text for post ranking in user profile/post author info.
FOR-5392 - Added ability for administrators to change title (tooltip) displayed for post ratings.
FOR-5393 - Added ability for icon bar to be rendered as links or as images.
FOR-5394 - Added Trust Locking. (Prohibits moderators from altering trust level of a specific user)
FOR-5395 - Added option for administrators to lock the trust setting automatically for all new users.
FOR-5396 - Added search from thread view for that particular forum.
FOR-5397 - Added ability for moderators and administrators to edit user signatures from a user's forum profile. (Similar to trusting feature)
FOR-5398 - Added ability for administrators to set if moderators can alter user signatures.
FOR-5399 - Added ability to disable HTML signatures and render text only.
FOR-5400 - Added ability for administrators to enable/disable user signatures at the module lev
FOR-5401 - Fixed Posts to moderate count issues.
FOR-5402 - Fixed last post showing in group view when it was not approved yet. (waiting for moderation)
FOR-5403 - Add link to aggregated forum in iconbar and remove from breadcrumb.
FOR-5404 - Fixed breadcrumb navigating to wrong TabID.
FOR-5405 - Fixed Add Moderator Issues.
FOR-5406 - Allow users to edit their own posts if untrusted in non
FOR-5407 - Add cachetime node to .dnn file and set to 0
FOR-5408 - Add compatibleversion node to .dnn file and set to 4.4.0.
FOR-5409 - Updated build file for core module release process packaging.
FOR-5414 - Fixed bug in "Today" & "Yesterday" to now work properly.
FOR-5685 - Removeded use of session
FOR-5686 - Drastically reduced number of db hits by depending more on cache where applicable.
FOR-5687 - Use default_collation on temp table creation for nvarchar columns, ntext, etc.
FOR-5963 - Moved per user moderator/forum permissions to Forum Permissions Grid (mimics core implementation)
FOR-5964 - Added nofollow configuration option for user website links in posts and forum profile view.
FOR-5965 - Added ability to enable/disable the overwriting of the page title by the forum system when in threads or posts view.
FOR-5976 - Aggregated Forum Syndication
FOR-5977 - RSS/Latest Posts Caching
FOR-5978 - RSS Feeds to use FURL's
FOR-5979 - Implementation of ISearchable Sucks
FOR-5980 - Clear out no longer needed sprocs
FOR-5981 - ISearchable Results to Standard Posts View
FOR-6122 - Added "No Replies" capability for all forum views.
FOR-6123 - Added Polling feature. Can be turned on/off at the forum level. 
FOR-6137 - Corrected problem where users could receive notifications after being removed from a role, or a private forum.


Version 03.20.09
* This is a patch release for security reasons

CHANGES/ENHANCEMENTS/BUGS:

- FOR-5387 - Security Fixes in 3 areas where module could potentially be affected.


Version 03.20.08 (Bug Fixes Deemed Major)

CHANGES/ENHANCEMENTS/BUGS:

- FOR-4144 - Fixed issues where forums were being added to a group multiple times depending on how many were selected. Added a check to avoid groups from being selected (so only forums are selected).
- FOR-4145 - Added code to populate the ForumUser.Membership.Email address.
- FOR-4146 - Added check to ReplaceCaseInsensitive to ensure text value was not "". This was causing errors System.ArgumentNullException: Value cannot be null. Parameter name: input at System.Text.RegularExpressions.Regex.Replace(String input, String replacement).
- FOR-4147 - Fixed caching code pattern in GetWords.
- FOR-4148 - Added error trapping to ConvertTimeZone to eliminate The added or subtracted value results in an un-representable DateTime errors
- FOR-4149 - Fixed standard caching coding pattern issue in GetForumUser ( only noticeable in ASP.NET 2.0 ).
- FOR-4150 - Fixed index out of range error in BindControls.


Version 03.20.07 (More quick fixes, major)

CHANGES/ENHANCEMENTS/BUGS:

- FOR-3358 - Extra { in DNNSilver.css was removed
- FOR-3359 - Fixed What's New sproc to get proper items.
- FOR-3361 - Fixed problem in PreConfig that assigned admin email of string "portalsettings.Email" instead of value.
- FOR-3362 - Showing private forums in tree view when they shouldn't be shown. Allows subscriptions (security).
- FOR-3364 - Thread sort order corrected.
- FOR-3365 - Fixed display issue w/ group header looking like extra <br> in there.
- FOR-3360 - Added GroupID value to solpart nav instead of just normal 'home' view when clicked.
- FOR-3366 - Aggregated showing Last post of private forums does not happen now.
- FOR-3367 - Aggregated no longer counts private forums in totals. 
- FOR-4152 - Corrected Search Results and My Posts Order (Re-wrote sproc, better structure too)
- FOR-4153 - Added DateApproved Column for better search indexing, this allowed me to correct search indexing to exclude unapproved posts.


Version 03.20.06 (Just a quick fix release)
* This release was packaged 2 days from .05 to correct immediate needs found in RC release. 

CHANGES/ENHANCEMENTS/BUGS:

- FOR-3146 - Add height spacer to be consistant with other group headers.
- FOR-3147 - Remove Forum_Download.aspx and Forum_Attachment.aspx as they are legacy and stop ASP.NET 2.0 builds from compiling. 


Version 03.20.05
* There are items in this release which were half implemented but have been held back and hidden in order to release to the public faster. These items will not be seen unless you dive into the source code and they will not interfere with the module operating properly. In addition to this, some usability issues exist which were being enhanced but had to be held back because of time constraints.

CHANGES/ENHANCEMENTS/BUGS:

- FOR-2275 - Added handler to ThreadMove so it did something.  Corrected Redirection URL to include mid.
- FOR-2258 - Made Today/Yesterday localizable for Forum What's New.
- FOR-2260 - Added missing Forum_UserDeleteReads sproc & missing Forum_UserThreadsDelete sproc.
- FOR-2294 - Changed breadcrumb navigation to include groupid, modified module to only show a specific group in group view if groupid is in querystring.
- FOR-2293 - Added sproc to handle feature so only moderators w/ notification enabled for mod emails get emails of new posts to moderate.
- FOR-2295 - Added anchors to each post in posts view.  Also added ability to navigate to single post via emails, hard url w/ # at end, and on return of post add/reply.
- FOR-2908 - Added new header per post and moved posted time to it.  It uses the Forum_AltHeader class and Forum_AltHeaderText.  Makes display more complete. (In Flat View Only)
- FOR-2323 - Added formating against bad word filter (if enabled) for What's New subjects.
- FOR-2322 - Filtered for XSS for all places forum subject is rendered including breadcrumbs and What's New.
- FOR-2324 - Added formating against bad word filter (if enabled) for What's New post bodies.
- FOR-2325 - Corrected PostsToModerate count when deleting a post in the moderation queue.
- FOR-2326 - Added Forum_ContentRemoved.ascx to handle when someone calls a page directly that is a deleted thread. (This could happen from RSS, email links, bookmarks, etc.)
- FOR-2350 - Corrected post datetime in posts view to be localized.
- FOR-2352 - Made lookup control (that which initiates popup) use localized text for "None Specified".
- FOR-2366 - Added ability for moderator to return to moderate posts view when using approve & reply/edit. (User setting)
- FOR-2304 - Added localizable tooltips for forum and thread status icons.
- FOR-2585 - Replace Popup for forum selection with treeview in search and thread move, user settings. (uses client api)
- FOR-2586 - Ability to restirct attachment download to authenticated users only.
- FOR-2362 - Added ability to assign moderators as global moderators.  Global moderators can moderate even unmoderated forums.
- FOR-2899 - Added moderation auditing for thread moves, post deletes, post approval. (Post approval was already working)
- FOR-2367 - Added Moderate Button in Posts View.
- FOR-2350 - Set Post time in Posts View to use Timezone conversion.
- FOR-2340 - Corrected links in emails sent by portals not using FURLs.
- FOR-2303 - Add a link to existing thread when moderating a post which is the existing threads name (if the post in queue is not the first thread).
- FOR-2302 - Added a link which is the name of a forum which navigates to thread view of a forum in moderate posts view.
- FOR-2375 - Added ability to reset LastIndexDate so forum content can be re-indexed for site search. (portal search ISearchable)
- FOR-2900 - Made date used for ISearchable formated using UTC Integer to avoid conflict w/ different culture sets in data store.
- FOR-2907 - Set it so only non-Private Forums are indexed for ISearchable. (portal search cannot handle this second level security)
- FOR-2901 - Added ability to assign moderators to non-moderated forums.
- FOR-2902 - Added standard email selection for deleting posts.
- FOR-2903 - Added outgoing email to post author on post delete.
- FOR-2904 - Fixed PostsToModerated bug where delete from moderation queue did not decrease posts to moderate count.
- FOR-2905 - Fixed oversight which did not decrease user post count when an approved post was deleted.
- FOR-2906 - Added ability for users to reset all posts to 'unread' status.
- FOR-2874 - Reworked ConvertTimeZone to handle DST and handle SQL Server/Web Server differences better.
- FOR-3047 - Replaced Attachment uploads w/ core URLController. 
- FOR-3048 - Made it so only Trusted users can edit their own posts.
- FOR-3145 - Added an Aggregated Forum which pulls posts from all non-private forums into a single new forum. (On/Off General Settings option)


Version 03.20.01
* If you have custom themes, you will need to change these as how the UI is generated has been changed along with additional css classes added and more theme customizable icons have been added.  The way read status for forums and threads has been changed, therefore all posts will be set to unread if upgrading.

CHANGES/ENHANCEMENTS/BUGS:

- FOR-1913 - Changed setting key to ForumMailFormat instead of HTMLMailFormat
- FOR-1956 - Corrected problem when posts were deleted via moderation screen, they were not removed until leaving and returning to the page.
- FOR-1857 - Corrected how menu was loading, added missing checks for ShowNavigator.  Made sure ID was assigned prior to loading the menu.
- FOR-1240 - Corrected many localization items including: User Profile and Search.
- FOR-2175 - Corrected forum and thread read status.  Broke up array stored for thread status and made one row of data per user/thread.  Added new Forum read status table.
- FOR-2179 - Removed legacy code for LastPostedID in Thread view, this corrected a bug which caused an infinite loop if that column was not populated.
- FOR-2178 - Corrected ability to use popup in Firefox (This was related to Modal usage).
- FOR-2173 - Corrected post attachments so each post has only its own attachments.
- FOR-1959 - Corrected links in email notifications to be more friendly for FURL's and non FURL's.
- FOR-1977 - Added delete confirmation from moderation by requiring user to go to new screen to confirm.
- FOR-1978 - IMG tag usage corrected so users can use remote URL's.
- FOR-1194 - Corrected My Settings (User Settings) avatar popup issues.
- FOR-2017 - Corrected missing localization items by adding in.
- FOR-1991 - Proper css classes added to forum search results UI.
- FOR-2060 - Added link in user profile to view posts by that user.
- FOR-1957 - Fixed popup issues so forums are selectable within popup drop down list.
- FOR-2120 - Corrected issues only seen in 3.2 or 4.0 where users were not being added if visiting forum for first time.  (There were problems w/ how module was accessing user profile data via MemberRole)
- FOR-2121 - Remove direct MemberRole dependancy.
- FOR-2174 - Made moderation an easier task by completely changing how moderating posts is done.
- FOR-2179 - Removed legacy code for LastPostedID in Thread view, this corrected a bug which caused an infinite loop if that column was not populated.
- FOR-2176 - Control panel added for administration, combined Solpart action menu items into one Forum Administion one to reach this new control panel.
- FOR-2177 - Added more icons and more css classes to make themse more customizable including spacing between groups and posts. 
- Made all icons customizable per theme, not just per install.
- Broke out configuration settings into seperate areas.
- Broke apart forum edit, group edit and manage forums into seperate screens. (Re-using the edit screens for add and update)
- Brought back prev. and next thread navigation in post view (in footer of each post view)
- Refactored how most of the forum UI generated in code only (no ascx) is written using reusable methods for common items.
- Started adding more standardized development documentation using vbCommentor


Version 03.10.04
*VERY IMPORTANT!!!!
The upgrade removes the blog module.  You will no longer be able to access blog once this is installed. (Blog project based on this discontinued, replaced with a new blog module.)
Please make sure blog is not exposed in portal to non admin users, as it will be broken after this install.
Also, never use the uninstall of core to remove the blog module prior to this install running successfully.  Once this has completed, you may delete module definition safely if you have no plans to migrate existing blog data at a later date. (Possible migration path to new module in the future.)

CHANGES/ENHANCEMENTS/BUGS:

- Removed all blog controls.  
- Changed way searhable items were indexed, passing a date now to avoid indexing all content each time.
- Changed UI so post dates display in a manner that maximizes use of screen real estate.
- Added ability to turn on/off Solpart Forum navigation menu. (On by default)
- Set DNNSilver as default Forum Theme and Email Template.
- Fixed thread view counts for all users including moderators.
- Fixed rankings to display proper image.
- Replicated core paging server control. Used in: all forum, thread, post views and manage users.
- Fixed RSS Syndication to not allow disabled forums for syndication, no private forum syndication.  (Was reachable by typing link before)
- Fixed ability for moderators to trust non moderators/admins.
- Exposed Manage User button in profile page for admins/tab admins to go straight to user settings of forum. (Same as accessing through Manager Users)
- Changed Moderate Forums screen to show only those forums with posts that need moderated.
- Changed Moderate Forums screen to list Moderated Forums by Group Sort order and then Forum Sort Order. (Display similar to initial Forum mod view)
- Corrected Manage Forum to reset cache on update.
- Corrected user/post/thread stats to work properly.
- Added ability to enable/disable a forum from the Manage Forums view area.
- Corrected all links in module and email templates to use NavigateURL and params.  This works for both FURLS and non FURLS.
- Corrected DNNSilver email template to be more readable.
- Corrected many DNNSilver forum theme elements to look proper.
- Set Group, Thread, Posts views to show created date as date/time consistantly and not approved date/time.
- Added check to all URLReferrer items to make sure request object is not nothing.
- Organized the way controls are loaded into the page/control life cycles to avoid elements not being available and throwing object reference errors.
- Added a specific ID to all Solpart Menu elements.
- Made DNNSilver skin look same in Firefox and IE.  (As much as possible) tested on Safari as well.
- Made better use of caching to enhance performance.
- Added module setting to show/hide User Online. (Must be enabled in host settings, also per user setting)
- Added module setting to enable/disable post ranking (Rate Thread)
- Added module setting to enable/disable Poster Location shown in post view (Three options: To All, To Admin, None)
- Corrected problem which hid thread if a post needed moderated.
- Fixed 'Delete Post' problem where it was deleted but remained in last post cache.  Series of deletes now occurs.
- Fixed error when no results were returned by a forum search.
- Changed all instances in code of Int16 to Int32, where applicable, as high volume sites would go past this limitation.
- Fix in Search, if you selected multiple users or multiple forums to search for, it results in zero rows coming back. 
- Added alternating css styles for thread view.  (Seen in thread view, moderate posts view)
- Removed IPortable since no code to support was there, will not show in module actions menu now.
- Wrapped all outgoing SMTP in Try/Catch to avoid issue if not configured in host settings, or bad email addresses.
- Made 'My Posts' reachable and usable from configuration section.
- Added Feature of Pre Configured Forum module and Default forum group and forum.  (Allows configured and ready to use module by simply placing module on tab)
- Fixed EnableModEmailNotification, was not being sent to database.  Also fixed bug that didn't properly use this newer feature.
- Moved Skin folder to Themes folder to match with renaming started in vresion 03.10.01
- Localized Moderate Post grid headers.
- Removed unused images in DotNetNuke and DNNSilver themes.
- Changed it so moderators can only edit, delete, move posts in forums which they are moderators of.  In a non-moderated forum, only admin/tab admin can edit others posts. (authors of original post as well)
- Changed so HasAdminPermission function includes Tab admin for this as well.  (Just means a tab admin is treated exactly as a site admin by module).
- Corrected MyPosts to work everywhere, wasn't picking userID up properly before.


Version 03.10.01 Notes: 

CHANGES/ENHANCEMENTS/BUGS:

- Added Forum Module Settings (accessible via module settings) to allow forum groups to be on any tab pointing to a master forum. - Thanks Shaun.
- Added action navbar for easier and consistant navigation for users who are logged in and not logged in.
- Fixed "My Posts" layout issue via action navbar addition.
- Closed dropped post issue as SetFocus on subject elminiated it.
- Module actions are more now consistant in Solpart Action Menu, Container action links, and new navbar. (This removes dependancy on container design)
- Corrected items which could not be localized but should have been localized. 
- Added ability to hide entire forum stats footer.  It is hidden in "children" forums regardless of choice.
- Added EnableModNotification in Forum_Users so moderators can choose if they want to receive email notifications for moderation. (default is yes, this will not stop notifications currently enabled unless the user goes and edits the setting in My Settings)  This required several changes involving database and moderators along with user settings.
- Added ability for moderators to set any user to "unmoderated" (IsTrusted) status via that user's profile page. (Only site admins, tab admins, moderators can see this checkbox)
- Added check to make sure only site admins, tab admins, moderators and original posters can edit posts. (original poster can edit only their posts)
- Fixed issue with non admins updating their profile and loosing their system avatars.
- Added ability for moderators to see "Edit", "Move", "Delete" for each post in a thread.  This gives moderators more flexibility. (User must have permissions to post in the same forum they are moderator of to see this inline)
- Made all ID areas not visible as users didn't need to know ID's and they couldn't be edited. (ie. ForumID in Manage Forum, GroupID, etc.)
- Added response email and require it for deletion of posts.
- Added check in post delete to verify user has proper permissions.
- Fixed issue where if one post in a thread needs moderated, entire thread is not visible. 
- Adjusted css and fixed layout problems.
- Renamed Forum Skins to Forum Themes to avoid confusion.


Version 03.00.13 Notes:

CHANGES/ENHANCEMENTS/BUGS:

- Fixed email notification (with DNN 3.0.13 or later)
- System avatar works with new enhancement. (See Below)
- Added Upload Image, s_attachment.gif, which was missing from install.
- Added System Avatar gallery configurable via Forum Configuration "Page", enhanced Gallery Integration to support this.
- Fixed handler on Post Moderation (edit, approve, etc.)
- Added missing image rating_x images to skin and install.
- Added SetFocus function to PostEdit & BlogEdit so focus is set on subject. (To aid in forgeting subject of new posts, and FTB dropped post problem)
- Fixed What's New to show content.
- Fixed view counting seen for threads. (Changes in 3.0.11 sql altered this to not work)
- Attachment bug corrected with new gallery. (each attachment to a post of collectively inclusive)
- Pinned Posts now only shown to tab or site admin for unmoderated forums.  Shows to those groups and forum moderators in moderated forums.
- Added "My Posts" similar to ASP.NET Forums "My Forums" which utilizes forum search. (To add feature for page size aka posts seen in "My Posts")
- Added missing content validation for PostEdit.ascx.
- Added option to blog to not show the category section (Navigator), only accessible via Solpart Category menu using this feature which is disabled by default.
- Changed Forum and Blog Configuration to no longer show source directory of install. (It SHOULD never change and if need be it could not have been done here anyways)


Version 03.00.12 Notes:

CHANGES/ENHANCEMENTS/BUGS:

- Changed/Fixed Localization issues.
- Corrected Missing XML Feed icon.
- Corrected Started/Last Post author profile mixup.
- Created By User in Manage Forum fixed.


Version 03.00.11 Notes:

CHANGES/ENHANCEMENTS/BUGS:

- Added more module help definitions in resx files.
- Added missing action menu localization definitions.
- Changed EnableDisplayInMemberList column in Forum_Users table, code, add/update stored procedures to protect against privacy issues by default. 
- Fixed Signature size in add/update sprocs to use 1024 table value instead of 255 limit.
- Added ViewDescending for users to view oldest or newest post first. (Their personal choosing)
- Changed asp buttons to linkbuttons to match normal core look.
- Corrected What's New to avoid users seeing "Private" forum posts in What's new that they are not authorized to view.
- Disabled ability to use javascript in forum/blog posts.
- Added Seperation from post and signature using horizontal line.
- Added validator to Blog Subject.
- Changed it so that if galleries were not configured, users will not see add smiley button in post edit or blog edit.
- Corrected missing image paths.
- Fixed attachment to forum/blog post (event handler was missing)
- Added validator for Forum post subject.
- Changed forum/blog skinning to use Forum_ prefix for css classes.
- Added DNNGray skin. (seperate download)
- Fixed Section head problem in Post Replies.  Was inside table it was to close and table was missing runat server.
- Fixed ss_forum.gif to s_forum.gif and fixed path problems.
- Changed spacing between Breadcrumb menu & Moderate/New Thead button and forum/thread table body. (
