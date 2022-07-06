rconsoleclear()

local PlayersService = game:GetService("Players")

local UserInput = game:GetService("UserInputService")

local TargetPly

rconsolename("Doxeador Picapiedra5000")

rconsoleinfo("Escribe el nombre del jugador")

TargetPly = PlayersService:FindFirstChild(tostring(rconsoleinput()))

rconsoleclear()

rconsoleinfo("Informacion de "..tostring(TargetPly))

rconsoleinfo("Nivel: "..tostring(TargetPly.CareerStatsCache.Level.Value))
rconsoleinfo("Kills Totales: "..tostring(TargetPly.CareerStatsCache.Kills.Value))
rconsoleinfo("Score Total: "..tostring(TargetPly.CareerStatsCache.Score.Value.."\n"))

rconsoleinfo("Efecto de Muerte: "..tostring(TargetPly.Data.KillEffect.Value))
rconsoleinfo("Meele Equipado: "..tostring(TargetPly.Data.Melee.Value))
rconsoleinfo("Anunciador Equipado: "..tostring(TargetPly.Data.Announcer.Value.."\n"))

rconsoleinfo("Emote Slot 1: "..tostring(TargetPly.Data.Emotes[1].Value))
rconsoleinfo("Emote Slot 2: "..tostring(TargetPly.Data.Emotes[2].Value))
rconsoleinfo("Emote Slot 3: "..tostring(TargetPly.Data.Emotes[3].Value))
rconsoleinfo("Emote Slot 4: "..tostring(TargetPly.Data.Emotes[4].Value))
rconsoleinfo("Emote Slot 5: "..tostring(TargetPly.Data.Emotes[5].Value))
rconsoleinfo("Emote Slot 6: "..tostring(TargetPly.Data.Emotes[2].Value.."\n"))

rconsoleinfo("Valor del FOV: "..tostring(TargetPly.Settings.FOV.Value))
rconsoleinfo("Texturas Activadas: "..tostring(TargetPly.Settings.NoTextures.Value))
rconsoleinfo("Ragdolls Activados: "..tostring(TargetPly.Settings.RagDolls.Value))
rconsoleinfo("Sombras Activadas: "..tostring(TargetPly.Settings.Shadows.Value))
rconsoleinfo("Subtitulos Activados: "..tostring(TargetPly.Settings.Subtitles.Value))
rconsoleinfo("ViewportCharacter Activado: "..tostring(TargetPly.Settings.ViewportCharacter.Value))
rconsoleinfo("AutoReload Activado: "..tostring(TargetPly.Settings.AutoReload.Value))
rconsoleinfo("Anunciador Activado: "..tostring(TargetPly.Settings.Announcer.Value))
rconsoleinfo("Enmascar Nombres Activado: "..tostring(TargetPly.Settings.MaskUsernames.Value))
rconsoleinfo("Skins Basicas Activadas: "..tostring(TargetPly.Settings.BasicSkins.Value))
rconsoleinfo("Vibracion del Gamepad Activada: "..tostring(TargetPly.Settings.GamepadVibrations.Value))
rconsoleinfo("Silenciar Megafonos Activado: "..tostring(TargetPly.Settings.MuteMegaphones.Value))
rconsoleinfo("Rasaltado del Texto Activado: "..tostring(TargetPly.Settings.MenuStroke.Value))
rconsoleinfo("Overlay de TeamLeader Activado: "..tostring(TargetPly.Settings.TeamLeaderDisplay.Value))
rconsoleinfo("Mostrar DisplayNames: "..tostring(TargetPly.Settings.ShowDisplayNames.Value))
rconsoleinfo("Particulas en el Ambiente Activado: "..tostring(TargetPly.Settings.ParticlePhysics.Value))

rconsoleinfo("Headshots Realizados: "..tostring(TargetPly.ScoreFolder.Headshots.Value))
rconsoleinfo("Murio un total de: "..tostring(TargetPly.ScoreFolder.Deaths.Value))
rconsoleinfo("Dominaciones: "..tostring(TargetPly.ScoreFolder.Dominations.Value))
rconsoleinfo("Kills Asistidas: "..tostring(TargetPly.ScoreFolder.Dominations.Value))
rconsoleinfo("Kills Hechas: "..tostring(TargetPly.ScoreFolder.Kills.Value))
rconsoleinfo("Venganzas Hechas: "..tostring(TargetPly.ScoreFolder.Revenges.Value))
rconsoleinfo("Streaks Hechos: "..tostring(TargetPly.ScoreFolder.Streak.Value))
--rconsoleinfo("Arma Primaria: "..tostring(TargetPly.CoopStatus.Primary.Value))
rconsoleinfo("Ultima lectura de Ping: "..tostring(TargetPly.Ping.Value))
--rconsoleinfo("Color del Menu: "..tostring(TargetPly.DesignColor.Value))

UserInput.InputBegan:Connect(function(key)
	if key.KeyCode == Enum.KeyCode.F2 then
		rconsoleclear()
	end
end)