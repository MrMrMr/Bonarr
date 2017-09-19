<p align="center">
<img src="/Logo/text256.png" alt="Bonarr">
</p>

Bonarr is an __independent__ fork of [Radarr](https://github.com/Radarr/Radarr) reworked for automatically downloading adult movies via Usenet and BitTorrent.

The project was inspired by Radarr's awesome ability to automate the process of downloading movies, but with a special twist: this time, you can automatically download adult movies to watch! Radarr has the ability to download adult movies found on TMDb, but many users began to complain that their kids could use it to download things they didn't want them to, or worse: automatic downloads could embarassingly show up in any automated system without some safeguards. 

Bonarr will have zero restrictions on what content is downloaded, and we are going to re-work the core to include cool adult-oriented features such as fetish, categorization, and labels from popular adult API sources that will help you find and prefer specific movies or clips based on your preferences.

## Getting Started

Bonarr is currently exactly the same as Radarr. As we move forward with the project, this section will be updated to include specific usage instructions on how to configure Bonarr specific functionality. Setting up Bonarr is the same process as documented on [Radarr's Wiki](https://github.com/Radarr/Radarr/wiki/).

## Downloads

[![GitHub Releases](https://img.shields.io/badge/downloads-releases-brightgreen.svg?maxAge=60&style=flat-square)](https://github.com/djzeratul/Bonarr/releases)

## Features

### Current Features

* Support for major platforms: Windows, Linux, macOS, Raspberry Pi, etc.
* Automatic failed download handling will try another release if one fails
* Manual search so you can pick any release or to see why a release was not downloaded automatically
* Full integration with SABnzbd and NZBGet
* Automatically searching for releases as well as RSS Sync
* Automatically importing downloaded movies
* All indexers supported by Sonarr also supported
* New PassThePopcorn Indexer
* QBittorrent, Deluge, rTorrent, Transmission and uTorrent download client (Other clients are coming)
* New TorrentPotato Indexer
* Torznab Indexer now supports Movies (Works well with [Jackett](https://github.com/Jackett/Jackett))
* Scanning PreDB to know when a new release is available
* Importing movies from various online sources, such as IMDb Watchlists (A complete list can be found [here](https://github.com/Radarr/Radarr/issues/114))
* Full integration with Kodi, Plex (notification, library update)
* And a beautiful UI

### Planned Features

* Supporting custom folder structures, such as sort by category subfolder (\*)
* Category view, to help organize movies into discernable categories.
* Movie sets, for adult movies with many sequels.
* Fetish preferences, for documented fetishes on adult movie API sites.
* 

**Note:** All features marked with (\*) are set to be in the first release of Bonarr.

#### [Feature Requests](http://feathub.com/djzeratul/Bonarr)

## Configuring the Development Environment

### Requirements

* [Visual Studio Community](https://www.visualstudio.com/vs/community/) or [MonoDevelop](http://www.monodevelop.com)
* [Git](https://git-scm.com/downloads)
* [Node.js](https://nodejs.org/en/download/)

### Setup

* Make sure all the required software mentioned above are installed
* Clone the repository into your development machine ([*info*](https://help.github.com/desktop/guides/contributing/working-with-your-remote-repository-on-github-or-github-enterprise))
* Grab the submodules `git submodule init && git submodule update`
* Install the required Node Packages `npm install`
* Start gulp to monitor your dev environment for any changes that need post processing using `npm start` command.

> **Notice**  
> Gulp must be running at all times while you are working with Radarr client source files.

### Development

* Open `NzbDrone.sln` in Visual Studio or run the build.sh script, if Mono is installed
* Make sure `NzbDrone.Console` is set as the startup project

### License

* [GNU GPL v3](http://www.gnu.org/licenses/gpl.html)
* Copyright 2010-2017
