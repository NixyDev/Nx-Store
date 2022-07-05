game:GetService("StarterGui"):SetCore("SendNotification",{
   Title = "Less Hud";
   Text = "[Loaded] Made by Nixy";
   Duration = 3
})

--[Disable original hud options]--
local CurrentClient = game:GetService "Players".LocalPlayer
local PlayerGui = CurrentClient:WaitForChild "PlayerGui"
local SG_Package = PlayerGui:WaitForChild "SG_Package"

SG_Package.MainGui.frame_lobbyMenu.text_kickDisabled.Font = "Gotham"

SG_Package.MainGui.NarrationText.Visible = false

SG_Package.MainGui.frame_lobbyMenu.button_restartHeist.buttonText.Font = "Gotham"
SG_Package.MainGui.frame_lobbyMenu.button_restartHeist.buttonText.TextScaled = false
SG_Package.MainGui.frame_lobbyMenu.button_restartHeist.buttonText.TextSize = 10

SG_Package.MainGui.frame_lobbyMenu.info_missionStats.text_bagsSecured.Font = "GothamMedium"
SG_Package.MainGui.frame_lobbyMenu.info_missionStats.text_bagsSecured.TextColor3 = Color3.fromRGB(255, 190, 0)
SG_Package.MainGui.frame_lobbyMenu.info_missionStats.text_bagsSecured.TextScaled = false

SG_Package.MainGui.frame_lobbyMenu.info_missionStats.text_cashSecured.Font = "GothamMedium"
SG_Package.MainGui.frame_lobbyMenu.info_missionStats.text_cashSecured.TextColor3 = Color3.fromRGB(0, 255, 100)
SG_Package.MainGui.frame_lobbyMenu.info_missionStats.text_cashSecured.TextScaled = false

SG_Package.MainGui.frame_lobbyMenu.info_missionStats.text_bodyBags.Font = "GothamMedium"
SG_Package.MainGui.frame_lobbyMenu.info_missionStats.text_bodyBags.TextColor3 = Color3.fromRGB(0, 150, 255)
SG_Package.MainGui.frame_lobbyMenu.info_missionStats.text_bodyBags.TextScaled = false

SG_Package.MainGui.frame_crosshairs.Visible = false
SG_Package.MainGui.Kills.Visible = false
SG_Package.MainGui.Hostages.Visible = false
SG_Package.MainGui.TimeLeft.Visible = false
SG_Package.MainGui.Objective.Visible = false
SG_Package.MainGui.ObjectiveStatus.Visible = false

SG_Package.MainGui.PoliceAssault.icon_assault.Image = "nil"
SG_Package.MainGui.PoliceAssault.icon_assault.text_assault.Text = ""

SG_Package.MainGui.CasingModeRestricted.TextScaled = false
SG_Package.MainGui.CasingModeRestricted.TextSize = 20
SG_Package.MainGui.CasingModeRestricted.TextColor3 = Color3.fromRGB(255, 0, 30)
SG_Package.MainGui.CasingModeRestricted.Font = "Gotham"

SG_Package.MainGui.CasingModeError.TextScaled = false
SG_Package.MainGui.CasingModeError.TextSize = 16
SG_Package.MainGui.CasingModeError.Font = "Gotham"

SG_Package.MainGui.CasingMode.CloseCasing.TextScaled = false
SG_Package.MainGui.CasingMode.CloseCasing.TextSize = 15
SG_Package.MainGui.CasingMode.CloseCasing.Font = "GothamMedium"

SG_Package.MainGui.Caught.text_label.Text = "Alarm Triggered"
SG_Package.MainGui.Caught.text_label.TextColor3 = Color3.fromRGB(255, 179, 0)
SG_Package.MainGui.Caught.text_label.TextSize = 15
SG_Package.MainGui.Caught.text_label.TextScaled = false
SG_Package.MainGui.Caught.text_label.TextWrapped = false
SG_Package.MainGui.Caught.text_label.Font = "Gotham"

SG_Package.MainGui.Caught.CaughtText.Font = "GothamMedium"
SG_Package.MainGui.Caught.CaughtText.TextScaled = false
SG_Package.MainGui.Caught.CaughtText.TextSize = 17
SG_Package.MainGui.Caught.CaughtText.TextWrapped = false
SG_Package.MainGui.Caught.CaughtText.TextColor3 = Color3.fromRGB(190,190,190)

SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_healthBG.info_health.BackgroundColor3 = Color3.fromRGB(0, 255, 100)
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_healthBG.info_health.BorderSizePixel = 0
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_healthBG.text_health.Visible = false

SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_shieldBG.info_shield.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_shieldBG.info_shield.BorderSizePixel = 0
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.text_shield.Visible = false

SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_weapons.primaryAmmo.Font = "Gotham"
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_weapons.secondaryAmmo.Font = "Gotham"
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_weapons.primaryAmmoTotal.Font = "Gotham"
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_weapons.secondaryAmmoTotal.Font = "Gotham"


--[Desing]--


-- Core
--[
local ScreenHandler = Instance.new "ScreenGui"
ScreenHandler.Name = "MinimalHud"
ScreenHandler.Parent = PlayerGui
ScreenHandler.IgnoreGuiInset = true
ScreenHandler.ResetOnSpawn = false
ScreenHandler.DisplayOrder = 9999999
ScreenHandler.Enabled = false
--]

-- Narration
--[
local NarratorLabel = Instance.new "TextLabel"
NarratorLabel.TextTransparency = 1
NarratorLabel.BackgroundTransparency = 1
NarratorLabel.Name = "NarratorLabel"
NarratorLabel.Parent = ScreenHandler
NarratorLabel.Position = UDim2.new(0.278, 0,0.793, 0)
NarratorLabel.Size = UDim2.new(0, 606,0, 64)
NarratorLabel.TextColor3 = Color3.fromRGB(255, 255, 255)
NarratorLabel.Font = "GothamMedium"
NarratorLabel.Text = "narrator_lines"
NarratorLabel.TextSize = 15
NarratorLabel.TextWrapped = true
NarratorLabel.TextYAlignment = "Top"
--]


-- Crosshair
--[
local CrosshairImg = Instance.new "ImageLabel"
CrosshairImg.Name = "CrosshairImg"
CrosshairImg.Parent = ScreenHandler
CrosshairImg.Position = UDim2.new(0.493, 0,0.485, 0)
CrosshairImg.Size = UDim2.new(0, 20,0, 20)
CrosshairImg.Image = "http://www.roblox.com/asset/?id=7262331135"
CrosshairImg.BackgroundTransparency = 1
--]


-- Objetive Reminder
--[
local ObjetiveReminder_Handler = Instance.new "Frame"
ObjetiveReminder_Handler.Name = "ObjetiveReminder"
ObjetiveReminder_Handler.Parent = ScreenHandler
ObjetiveReminder_Handler.Position = UDim2.new(0.753, 0,0.104, 0)
ObjetiveReminder_Handler.Size = UDim2.new(0, 282,0, 69)
ObjetiveReminder_Handler.BackgroundTransparency = 1

local ObjetiveReminder_Title = Instance.new "TextLabel"
ObjetiveReminder_Title.BackgroundTransparency = 1
ObjetiveReminder_Title.Name = "Title"
ObjetiveReminder_Title.Parent = ObjetiveReminder_Handler
ObjetiveReminder_Title.Position = UDim2.new(0.145, 0,0.191, 0)
ObjetiveReminder_Title.Size = UDim2.new(0, 200,0, 25)
ObjetiveReminder_Title.TextColor3 = Color3.fromRGB(255, 255, 255)
ObjetiveReminder_Title.Font = "GothamMedium"
ObjetiveReminder_Title.Text = "Objective Updated"
ObjetiveReminder_Title.TextSize = 17 

local ObjetiveReminder_NewObjetive = Instance.new "TextLabel"
ObjetiveReminder_NewObjetive.BackgroundTransparency = 1
ObjetiveReminder_NewObjetive.Name = "Title"
ObjetiveReminder_NewObjetive.Parent = ObjetiveReminder_Handler
ObjetiveReminder_NewObjetive.Position = UDim2.new(-0.099, 0,0.541, 0)
ObjetiveReminder_NewObjetive.Size = UDim2.new(0, 338,0, 18)
ObjetiveReminder_NewObjetive.TextColor3 = Color3.fromRGB(255, 255, 255)
ObjetiveReminder_NewObjetive.Font = "Gotham"
ObjetiveReminder_NewObjetive.Text = "objetive_name"
ObjetiveReminder_NewObjetive.TextSize = 15
--]
--DivBars: Objetive Handler
--[
local DivBarUpper_ObjetiveReminder = Instance.new "Frame"
DivBarUpper_ObjetiveReminder.Name = "DivBar"
DivBarUpper_ObjetiveReminder.Parent = ObjetiveReminder_Handler
DivBarUpper_ObjetiveReminder.Position = UDim2.new(0, 0,0, 0)
DivBarUpper_ObjetiveReminder.Size = UDim2.new(0, 80,0, 0)
DivBarUpper_ObjetiveReminder.BorderColor3 = Color3.fromRGB(255,255,255)

local DivBarBottom_ObjetiveReminder = Instance.new "Frame"
DivBarBottom_ObjetiveReminder.Name = "DivBar"
DivBarBottom_ObjetiveReminder.Parent = ObjetiveReminder_Handler
DivBarBottom_ObjetiveReminder.Position = UDim2.new(0.716, 0,1, 0)
DivBarBottom_ObjetiveReminder.Size = UDim2.new(0, 80,0, 0)
DivBarBottom_ObjetiveReminder.BorderColor3 = Color3.fromRGB(255,255,255)
--]


-- Heist Info
--[
local HeistInfo_Handler = Instance.new "Frame"
HeistInfo_Handler.Name = "HeistInfo"
HeistInfo_Handler.Parent = ScreenHandler
HeistInfo_Handler.Position = UDim2.new(0.034, 0,0.118, 0)
HeistInfo_Handler.Size = UDim2.new(0, 258,0, 50)
HeistInfo_Handler.BackgroundTransparency = 1

local HeistInfo_Timer = Instance.new "TextLabel"
HeistInfo_Timer.BackgroundTransparency = 1
HeistInfo_Timer.Name = "Timer"
HeistInfo_Timer.Parent = HeistInfo_Handler
HeistInfo_Timer.Position = UDim2.new(0.062, 0,0.2, 0)
HeistInfo_Timer.Size = UDim2.new(0, 72,0, 30)
HeistInfo_Timer.TextColor3 = Color3.fromRGB(255, 255, 255)
HeistInfo_Timer.Font = "GothamMedium"
HeistInfo_Timer.Text = "00:00"
HeistInfo_Timer.TextSize = 17
HeistInfo_Timer.TextXAlignment = "Left"

local HeistInfo_HeistName = Instance.new "TextLabel"
HeistInfo_HeistName.BackgroundTransparency = 1
HeistInfo_HeistName.Name = "HeistName"
HeistInfo_HeistName.Parent = HeistInfo_Handler
HeistInfo_HeistName.Position = UDim2.new(0.655, 0,0.2, 0)
HeistInfo_HeistName.Size = UDim2.new(0, 72,0, 30)
HeistInfo_HeistName.TextColor3 = Color3.fromRGB(255, 255, 255)
HeistInfo_HeistName.Font = "Gotham"
HeistInfo_HeistName.Text = "heist_name"
HeistInfo_HeistName.TextSize = 16
HeistInfo_HeistName.TextXAlignment = "Right"

local HeistInfo_HostagesIcon = Instance.new "ImageLabel"
HeistInfo_HostagesIcon.Name = "Hostages"
HeistInfo_HostagesIcon.Parent = HeistInfo_Handler
HeistInfo_HostagesIcon.BackgroundTransparency = 1
HeistInfo_HostagesIcon.Image = "http://www.roblox.com/asset/?id=3354164012"
HeistInfo_HostagesIcon.Position = UDim2.new(0.023, 0,1.34, 0)
HeistInfo_HostagesIcon.Size = UDim2.new(0, 22,0, 22)
local HeistInfo_HostagesCount = Instance.new "TextLabel"
HeistInfo_HostagesCount.BackgroundTransparency = 1
HeistInfo_HostagesCount.Name = "Count"
HeistInfo_HostagesCount.Parent = HeistInfo_HostagesIcon
HeistInfo_HostagesCount.Position = UDim2.new(1.364, 0,0, 0)
HeistInfo_HostagesCount.Size = UDim2.new(0, 31,0, 22)
HeistInfo_HostagesCount.TextColor3 = Color3.fromRGB(255, 255, 255)
HeistInfo_HostagesCount.Font = "GothamMedium"
HeistInfo_HostagesCount.Text = "0"
HeistInfo_HostagesCount.TextSize = 18
HeistInfo_HostagesCount.TextXAlignment = "Left"

local HeistInfo_KillsIcon = Instance.new "ImageLabel"
HeistInfo_KillsIcon.Name = "Kills"
HeistInfo_KillsIcon.Parent = HeistInfo_Handler
HeistInfo_KillsIcon.BackgroundTransparency = 1
HeistInfo_KillsIcon.Image = "http://www.roblox.com/asset/?id=2992801749"
HeistInfo_KillsIcon.Position = UDim2.new(0.368, 0,1.34, 0)
HeistInfo_KillsIcon.Size = UDim2.new(0, 22,0, 22)
local HeistInfo_KillsCount = Instance.new "TextLabel"
HeistInfo_KillsCount.BackgroundTransparency = 1
HeistInfo_KillsCount.Name = "Count"
HeistInfo_KillsCount.Parent = HeistInfo_KillsIcon
HeistInfo_KillsCount.Position = UDim2.new(1.364, 0,0, 0)
HeistInfo_KillsCount.Size = UDim2.new(0, 31,0, 22)
HeistInfo_KillsCount.TextColor3 = Color3.fromRGB(255, 255, 255)
HeistInfo_KillsCount.Font = "GothamMedium"
HeistInfo_KillsCount.Text = "0"
HeistInfo_KillsCount.TextSize = 18
HeistInfo_KillsCount.TextXAlignment = "Left"

--]
--DivBars: Objetive Handler
--[
local DivBarUpper_HeistInfo = Instance.new "Frame"
DivBarUpper_HeistInfo.Name = "DivBar"
DivBarUpper_HeistInfo.Parent = HeistInfo_Handler
DivBarUpper_HeistInfo.Position = UDim2.new(0.694, 0,0, 0)
DivBarUpper_HeistInfo.Size = UDim2.new(0, 79,0, 0)
DivBarUpper_HeistInfo.BorderColor3 = Color3.fromRGB(255,255,255)

local DivBarBottom_HeistInfo = Instance.new "Frame"
DivBarBottom_HeistInfo.Name = "DivBar"
DivBarBottom_HeistInfo.Parent = HeistInfo_Handler
DivBarBottom_HeistInfo.Position = UDim2.new(0, 0,1, 0)
DivBarBottom_HeistInfo.Size = UDim2.new(0, 79,0, 0)
DivBarBottom_HeistInfo.BorderColor3 = Color3.fromRGB(255,255,255)
--]


-- Assault Indicator
--[
local AssaultIndicator_Handler = Instance.new "Frame"
AssaultIndicator_Handler.Name = "AssaultIndicator"
AssaultIndicator_Handler.Parent = ScreenHandler
AssaultIndicator_Handler.Position = UDim2.new(0.399, 0,0.083, 0)
AssaultIndicator_Handler.Size = UDim2.new(0, 274,0, 38)
AssaultIndicator_Handler.BackgroundTransparency = 1

local AssaultIndicator_Status = Instance.new "TextLabel"
AssaultIndicator_Status.BackgroundTransparency = 1
AssaultIndicator_Status.Name = "AssaultText"
AssaultIndicator_Status.Parent = AssaultIndicator_Handler
AssaultIndicator_Status.Position = UDim2.new(0.135, 0,0.211, 0)
AssaultIndicator_Status.Size = UDim2.new(0, 200,0, 22)
AssaultIndicator_Status.TextColor3 = Color3.fromRGB(255, 179, 0)
AssaultIndicator_Status.Font = "GothamMedium"
AssaultIndicator_Status.Text = "-//Assault in Progress//-"
AssaultIndicator_Status.TextSize = 16

--[
local DivBarUpper_AssaultIndicator = Instance.new "Frame"
DivBarUpper_AssaultIndicator.Name = "DivBar"
DivBarUpper_AssaultIndicator.Parent = AssaultIndicator_Handler
DivBarUpper_AssaultIndicator.Position = UDim2.new(0, 0,0, 0)
DivBarUpper_AssaultIndicator.Size = UDim2.new(0, 84,0, 0)
DivBarUpper_AssaultIndicator.BorderColor3 = Color3.fromRGB(255, 179, 0)

local DivBarBottom_AssaultIndicator = Instance.new "Frame"
DivBarBottom_AssaultIndicator.Name = "DivBar"
DivBarBottom_AssaultIndicator.Parent = AssaultIndicator_Handler
DivBarBottom_AssaultIndicator.Position = UDim2.new(0.693, 0,1, 0)
DivBarBottom_AssaultIndicator.Size = UDim2.new(0, 84,0, 0)
DivBarBottom_AssaultIndicator.BorderColor3 = Color3.fromRGB(255, 179, 0)
--]


-- [Functions] --

--Set up
---
ObjetiveReminder_Title.TextTransparency = 1
ObjetiveReminder_NewObjetive.TextTransparency = 1

DivBarUpper_ObjetiveReminder.BackgroundTransparency = 1
DivBarBottom_ObjetiveReminder.BackgroundTransparency = 1
---

---
AssaultIndicator_Status.TextTransparency = 1
DivBarUpper_AssaultIndicator.BackgroundTransparency = 1
DivBarBottom_AssaultIndicator.BackgroundTransparency = 1
---

ScreenHandler.Enabled = true

function SetNewObjetive(objetive)
	
	DivBarUpper_ObjetiveReminder.Position = UDim2.new(0, 0,0, 0)
	DivBarBottom_ObjetiveReminder.Position = UDim2.new(0.716, 0,1, 0)
	ObjetiveReminder_NewObjetive.Text = objetive
	
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency - 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency - 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency - 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency - 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency - 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency - 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency - 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency - 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency - 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency - 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency - 0.1
	
	wait(.7)
	
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency - 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency - 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency - 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency - 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency - 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency - 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency - 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency - 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency - 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency - 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency - 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency - 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency - 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency - 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency - 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency - 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency - 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency - 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency - 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency - 0.1
	
	DivBarUpper_ObjetiveReminder:TweenPosition(
		UDim2.new(0.528, 0,0, 0),
		"Out",
		"Quart",
		9
	)
	
	DivBarBottom_ObjetiveReminder:TweenPosition(
		UDim2.new(0.188, 0,1, 0),
		"Out",
		"Quart",
		9
	)
	
	wait(3)
	
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency + 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency + 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency + 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency + 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency + 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency + 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency + 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency + 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency + 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency + 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency + 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency + 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency + 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency + 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency + 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency + 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency + 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency + 0.1
	wait()
	ObjetiveReminder_Title.TextTransparency = ObjetiveReminder_Title.TextTransparency + 0.1
	ObjetiveReminder_NewObjetive.TextTransparency = ObjetiveReminder_NewObjetive.TextTransparency + 0.1
	
	wait(.7)
	
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency + 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency + 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency + 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency + 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency + 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency + 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency + 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency + 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency + 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_ObjetiveReminder.BackgroundTransparency = DivBarUpper_ObjetiveReminder.BackgroundTransparency + 0.1
	DivBarBottom_ObjetiveReminder.BackgroundTransparency = DivBarBottom_ObjetiveReminder.BackgroundTransparency + 0.1
	
	wait(5.5)	

end

function StartAssault()
	DivBarUpper_AssaultIndicator.Position = UDim2.new(0, 0,0, 0)
	DivBarUpper_AssaultIndicator.Size = UDim2.new(0, 274,0, 0)
	
	DivBarBottom_AssaultIndicator.Position = UDim2.new(0.693, 0,1, 0)
	DivBarBottom_AssaultIndicator.Size = UDim2.new(0, 274,0, 0)
	
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency - 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency - 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency - 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency - 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency - 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency - 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency - 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency - 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency - 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency - 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency - 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency - 0.1
	
	DivBarUpper_AssaultIndicator:TweenSize(
		UDim2.new(0, 84,0, 0),
		"Out",
		"Quart",
		1.8
	)
	
	DivBarBottom_AssaultIndicator:TweenSize(
		UDim2.new(0, 84,0, 0),
		"Out",
		"Quart",
		1.8
	)
	
	wait(.7)
	
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency - 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency - 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency - 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency - 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency - 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency - 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency - 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency - 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency - 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency - 0.1
end

function StopAssault()
	
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency + 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency + 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency + 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency + 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency + 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency + 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency + 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency + 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency + 0.1
	wait()
	AssaultIndicator_Status.TextTransparency = AssaultIndicator_Status.TextTransparency + 0.1
	
	DivBarUpper_AssaultIndicator:TweenPosition(
		UDim2.new(0.693, 0,0, 0),
		"Out",
		"Quart",
		1.2
	)
	
	DivBarBottom_AssaultIndicator:TweenPosition(
		UDim2.new(-0, 0,1, 0),
		"Out",
		"Quart",
		1.2
	)
	
	wait(.8)
	
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency + 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency + 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency + 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency + 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency + 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency + 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency + 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency + 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency + 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency + 0.1
	wait()
	DivBarUpper_AssaultIndicator.BackgroundTransparency = DivBarUpper_AssaultIndicator.BackgroundTransparency + 0.1
	DivBarBottom_AssaultIndicator.BackgroundTransparency = DivBarBottom_AssaultIndicator.BackgroundTransparency + 0.1
end

-- In-Game variables and Changes

--Timer
SG_Package.MainGui.TimeLeft.Show.Changed:Connect(function(Property)
    if Property == "Text" then
        HeistInfo_Timer.Text = SG_Package.MainGui.TimeLeft.Show.Text
    end
end)

--Kills
SG_Package.MainGui.Kills.amount.Changed:Connect(function(Property)
    if Property == "Text" then
        HeistInfo_KillsCount.Text = SG_Package.MainGui.Kills.amount.Text
    end
end)

--Hostages
SG_Package.MainGui.Hostages.amount.Changed:Connect(function(Property)
    if Property == "Text" then
        HeistInfo_HostagesCount.Text = SG_Package.MainGui.Hostages.amount.Text
    end
end)

--Objetive
SG_Package.MainGui.Objective.text_objectiveMain.Changed:Connect(function(Property)
    if Property == "Text" then
        SetNewObjetive(SG_Package.MainGui.Objective.text_objectiveMain.Text)
    end
end)

--Start Assault
SG_Package.MainGui.PoliceAssault.Changed:Connect(function(Property)
    if Property == "Visible" then
        if SG_Package.MainGui.PoliceAssault.Visible == true then
            StartAssault()
        end
        
        if SG_Package.MainGui.PoliceAssault.Visible == false then
            StopAssault()
        end
    end
end)

--Narration
SG_Package.MainGui.NarrationText.ChildAdded:Connect(function(object)

    NarratorLabel.Text = SG_Package.MainGui.NarrationText.TextLabel.Text
    SG_Package.MainGui.NarrationText.TextLabel.Visible = false
    SG_Package.MainGui.NarrationText.TextLabel.TextTransparency = false

    NarratorLabel.TextTransparency = NarratorLabel.TextTransparency - 0.1
                wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency - 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency - 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency - 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency - 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency - 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency - 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency - 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency - 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency - 0.1

	wait(5)

	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency + 0.1
	        wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency + 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency + 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency + 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency + 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency + 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency + 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency + 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency + 0.1
		wait()
	NarratorLabel.TextTransparency = NarratorLabel.TextTransparency + 0.1

	wait(3)
end)

--Loops
while wait(.2) do

HeistInfo_HeistName.Text = SG_Package.MainGui.frame_lobbyMenu.info_heist.label_heistTitle.Text

SG_Package.MainGui.frame_crosshairs.Visible = false
SG_Package.MainGui.Kills.Visible = false
SG_Package.MainGui.Hostages.Visible = false
SG_Package.MainGui.TimeLeft.Visible = false
SG_Package.MainGui.Objective.Visible = false
SG_Package.MainGui.ObjectiveStatus.Visible = false

SG_Package.MainGui.PoliceAssault.icon_assault.Image = "nil"
SG_Package.MainGui.PoliceAssault.icon_assault.text_assault.Text = ""

SG_Package.MainGui.CasingModeRestricted.TextScaled = false
SG_Package.MainGui.CasingModeRestricted.TextSize = 20
SG_Package.MainGui.CasingModeRestricted.TextColor3 = Color3.fromRGB(255, 0, 30)
SG_Package.MainGui.CasingModeRestricted.Font = "Gotham"

SG_Package.MainGui.CasingModeError.TextScaled = false
SG_Package.MainGui.CasingModeError.TextSize = 16
SG_Package.MainGui.CasingModeError.Font = "Gotham"

SG_Package.MainGui.CasingMode.CloseCasing.TextScaled = false
SG_Package.MainGui.CasingMode.CloseCasing.TextSize = 15
SG_Package.MainGui.CasingMode.CloseCasing.Font = "GothamMedium"

SG_Package.MainGui.Caught.text_label.Text = "Alarm Triggered"
SG_Package.MainGui.Caught.text_label.TextColor3 = Color3.fromRGB(255, 179, 0)
SG_Package.MainGui.Caught.text_label.TextSize = 15
SG_Package.MainGui.Caught.text_label.TextScaled = false
SG_Package.MainGui.Caught.text_label.TextWrapped = false
SG_Package.MainGui.Caught.text_label.Font = "Gotham"

SG_Package.MainGui.Caught.CaughtText.Font = "GothamMedium"
SG_Package.MainGui.Caught.CaughtText.TextScaled = false
SG_Package.MainGui.Caught.CaughtText.TextSize = 17
SG_Package.MainGui.Caught.CaughtText.TextWrapped = false
SG_Package.MainGui.Caught.CaughtText.TextColor3 = Color3.fromRGB(190,190,190)

SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_healthBG.info_health.BackgroundColor3 = Color3.fromRGB(0, 255, 100)
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_healthBG.info_health.BorderSizePixel = 0
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_healthBG.text_health.Visible = false

SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_shieldBG.info_shield.BackgroundColor3 = Color3.fromRGB(255, 255, 255)
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_shieldBG.info_shield.BorderSizePixel = 0
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.text_shield.Visible = false

SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_weapons.primaryAmmo.Font = "Gotham"
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_weapons.secondaryAmmo.Font = "Gotham"
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_weapons.primaryAmmoTotal.Font = "Gotham"
SG_Package.MainGui:WaitForChild "PlayerStats".LocalPlayerStats.info_weapons.secondaryAmmoTotal.Font = "Gotham"


end