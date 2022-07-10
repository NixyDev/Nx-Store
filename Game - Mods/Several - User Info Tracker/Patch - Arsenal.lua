rconsoleclear()

local PlayersService = game:GetService("Players")

local UserInput = game:GetService("UserInputService")

local TargetPly

rconsolename("Info Tracker - Arsenal")

rconsoleinfo("Type player name to track")

TargetPly = PlayersService:FindFirstChild(tostring(rconsoleinput()))

rconsoleclear()

rconsoleinfo("Info about "..tostring(TargetPly))

rconsoleinfo("Level: "..tostring(TargetPly.CareerStatsCache.Level.Value))
rconsoleinfo("Total Kills: "..tostring(TargetPly.CareerStatsCache.Kills.Value))
rconsoleinfo("Total Score: "..tostring(TargetPly.CareerStatsCache.Score.Value.."\n"))

rconsoleinfo("Kill Effect: "..tostring(TargetPly.Data.KillEffect.Value))
rconsoleinfo("Meele Equipped: "..tostring(TargetPly.Data.Melee.Value))
rconsoleinfo("Announcer Equipped: "..tostring(TargetPly.Data.Announcer.Value.."\n"))

rconsoleinfo("Emote Slot 1: "..tostring(TargetPly.Data.Emotes[1].Value))
rconsoleinfo("Emote Slot 2: "..tostring(TargetPly.Data.Emotes[2].Value))
rconsoleinfo("Emote Slot 3: "..tostring(TargetPly.Data.Emotes[3].Value))
rconsoleinfo("Emote Slot 4: "..tostring(TargetPly.Data.Emotes[4].Value))
rconsoleinfo("Emote Slot 5: "..tostring(TargetPly.Data.Emotes[5].Value))
rconsoleinfo("Emote Slot 6: "..tostring(TargetPly.Data.Emotes[2].Value.."\n"))

rconsoleinfo("FOV Value: "..tostring(TargetPly.Settings.FOV.Value))
rconsoleinfo("Textures ON: "..tostring(TargetPly.Settings.NoTextures.Value))
rconsoleinfo("Ragdolls ON: "..tostring(TargetPly.Settings.RagDolls.Value))
rconsoleinfo("Shadows ON: "..tostring(TargetPly.Settings.Shadows.Value))
rconsoleinfo("Subtitles ON: "..tostring(TargetPly.Settings.Subtitles.Value))
rconsoleinfo("ViewportCharacter ON: "..tostring(TargetPly.Settings.ViewportCharacter.Value))
rconsoleinfo("AutoReload ON: "..tostring(TargetPly.Settings.AutoReload.Value))
rconsoleinfo("Announcer ON: "..tostring(TargetPly.Settings.Announcer.Value))
rconsoleinfo("Mask names ON: "..tostring(TargetPly.Settings.MaskUsernames.Value))
rconsoleinfo("Basic Skins ON: "..tostring(TargetPly.Settings.BasicSkins.Value))
rconsoleinfo("Gamepad Vibration ON: "..tostring(TargetPly.Settings.GamepadVibrations.Value))
rconsoleinfo("Mute Radios ON: "..tostring(TargetPly.Settings.MuteMegaphones.Value))
rconsoleinfo("Text Contrast ON: "..tostring(TargetPly.Settings.MenuStroke.Value))
rconsoleinfo("TeamLeader Overlay ON: "..tostring(TargetPly.Settings.TeamLeaderDisplay.Value))
rconsoleinfo("Show DisplayNames ON: "..tostring(TargetPly.Settings.ShowDisplayNames.Value))
rconsoleinfo("Physics Particles ON: "..tostring(TargetPly.Settings.ParticlePhysics.Value))

rconsoleinfo("Headshots in the Round: "..tostring(TargetPly.ScoreFolder.Headshots.Value))
rconsoleinfo("Was killed in the Round: "..tostring(TargetPly.ScoreFolder.Deaths.Value))
rconsoleinfo("Dominations in the Round: "..tostring(TargetPly.ScoreFolder.Dominations.Value))
rconsoleinfo("Asisted Kills in the Round: "..tostring(TargetPly.ScoreFolder.Dominations.Value))
rconsoleinfo("Kills in the Round: "..tostring(TargetPly.ScoreFolder.Kills.Value))
rconsoleinfo("Revenges in the Round: "..tostring(TargetPly.ScoreFolder.Revenges.Value))
rconsoleinfo("Streaks Done: "..tostring(TargetPly.ScoreFolder.Streak.Value))
--rconsoleinfo("Arma Primaria: "..tostring(TargetPly.CoopStatus.Primary.Value))
rconsoleinfo("Last Ping Read: "..tostring(TargetPly.Ping.Value))
--rconsoleinfo("Color del Menu: "..tostring(TargetPly.DesignColor.Value))

UserInput.InputBegan:Connect(function(key)
	if key.KeyCode == Enum.KeyCode.F2 then
		rconsoleclear()
	end
end)
