# Create your own battle bot

To identify the bots in the game we suggest that you follow the conventions `[Your Initials].[Bot Name]` (where `[Your Initials]` is really anything that identifies you uniquely)

1. Fork this repository
2. Edit the `Redgate.BattleBot_1.0` project and rename the assembly to `[Your Initials].[BotName]_1.0`
3. You should find an example bot inside the `BattleBot.cs`
   * either edit this file
     * Change the _namespace_ to be `[Your Initials]`
     * Change the _class name_ to be `[BotName]`
   * or create a new class called `[BotName]`
     * Give it a _namespace_ of `[Your initials]`
4. Build

You should now be ready to experiment on different behaviours and approaches.

# Running your bot

You are going to need to have downloaded and installed:

* [The Robocode runner](https://sourceforge.net/projects/robocode/files/latest/download)
* [The .NET interop](https://sourceforge.net/projects/robocode/files/robocode/1.9.3.0/robocode.dotnet-1.9.3.0-setup.jar/download)

(obviously you will need a JRE - I know, sorry, but maybe if you are using Rider you might already have one)

By default these install ino `C:\robocode`, so to run the battle UI:

* Open a command prompt
* Go to `C:\robocode`
* run `robocode.bat`

You should then magically have a UI for running the battles. To add your `dll` to the system:

* Go to `Options->Preferences`
* Select the **Development Preferences** tab
* Click _Add_
* Select the directory containing your assembly

**_NOTE:_** You should be able to rebuild your robot between battles without having to restart the app

To run a battle:

* Go to `Battle->New`
* You should see your initials/unique identifier in the _packages_ list
* You should see your bot in the _robots_ list
* Add your robot and as many opponents as you care about
* Click **Start Battle**
