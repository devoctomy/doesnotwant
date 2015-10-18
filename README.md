# doesnotwant

I love Spotify, I use it pretty much every day, but as a paying customer I am unhappy with not being able to block music that I do not want to listen to.  I want to be able to block individual tracks as well as certain artists out-right.  Spotify just doesn't have that capability built in *yet*.

That's where DoesNotWant comes in.  Simple launch the application and it will run silently in the background, when a track or artist comes on that you do not want, simply double click the DoesNotWant icon in the system tray area and then press the filter button to the right of the currently playing track in the DoesNotWant window, or right click the icon in the system tray icon, and select "Create Filter From Currently Playing...".  Both methods will pop up a filter creation dialog.

## Blocking Individual tracks

To block an individual track, just click the "This track only" button in the filter creation dialog.  The track will be added to your list of filters and then immediately skipped.

## Blocking artists

To block an artist you have 2 possible methods.  One of which will block the artist by their Spotify URI, that's the unique identifier for that artist.  Although that may work 99% of the time, if the artist you do not like is featuring in someone elses track, it may not, in which case you will need to filter the artist by their name.  This will simply perform a case insensitive match against the track artist name and the value you have entered.

To block using either of these methods, just click the "This artist, or an artist on this track" button in the filter creation dialog.

### By Artist URI

Select the "This artists URI" option in the next step of the filter creation dialog, and then click "OK".

### By Artist Name

Select the "This artists name" option in the next step of the filter creation dialog, make sure that the name in the textbox below the option is specific enough to match that artist, and also short versions of the artists name.  Then click "OK".

## Unblocking

To unblock / remove a filter, simply double click simply open the DoesNotWant window, scroll through the list of filters you have configured, locate the one you would like to remove, and click the thumbs up icon to the right of it.

## Running DoesNotWant In The Background

To let DoesNotWant run in the backround, simple click the "OK" button in the main window, this will hide it.  In order to make it visible again you can either double click the DoesNotWant icon in the system tray area, or right click the icon and select "Show" from the context menu.

> If you would like to close DoesNotWant, simply click "Exit" in the main window, or right click the DoesNotWant icon in the system tray area, and then click "Exit" from the context menu.

## Screenshots

![Screenshot 1](http://devoctomy.s3.amazonaws.com/installers/DoesNotWant/screenshot-1.PNG)
> DoesNotWant main window and filter creation dialog

## Pre-Build Installers

Please be aware that these installers are not yet part of a continuous integration process so may be out of date if I have forgotten to rebuild upload them.

[DoesNotWant - Latest Debug Build](http://devoctomy.s3.amazonaws.com/installers/DoesNotWant/DoesNotWant_debug.exe)

[DoesNotWant - Latest Release Build (Recommended)](http://devoctomy.s3.amazonaws.com/installers/DoesNotWant/DoesNotWant_release.exe)
