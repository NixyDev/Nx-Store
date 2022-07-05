local CoreGui = game:GetService("CoreGui")

if not CoreGui:FindFirstChild("RTXCore") then

local UserInput = game:GetService("UserInputService")

local Lighting = game:GetService("Lighting")

local StarterGui = game:GetService("StarterGui")

local isModON = false

-- Saves

local Saved_ClockTime = Lighting.ClockTime

local Saved_Latitude = Lighting.GeographicLatitude

local Saved_Shadows = Lighting.GlobalShadows

local Saved_FOV = workspace.CurrentCamera.FieldOfView

local Saved_WaterReflect = workspace.Terrain.WaterReflectance

local Saved_WaterTransparency = workspace.Terrain.WaterTransparency

local Saved_WaterWaveSide = workspace.Terrain.WaterWaveSize

local Saved_WaterSpeed = workspace.Terrain.WaterWaveSpeed

local Saved_ShadowsSoftness = Lighting.ShadowSoftness


-- Design

local RTXCore = Instance.new("ScreenGui")
RTXCore.Name = "RTXCore"
RTXCore.Parent = CoreGui
RTXCore.DisplayOrder = 200000000
RTXCore.ResetOnSpawn = false
RTXCore.IgnoreGuiInset = true
RTXCore.Enabled = false

local Base = Instance.new("Frame")
Base.Parent = RTXCore
Base.Name = "Base"
Base.BackgroundColor3 = Color3.fromRGB(0,0,0)
Base.Position = UDim2.new(0.026, 0,0.295, 0)
Base.Size = UDim2.new(0, 188,0, 360)
Instance.new("UICorner", Base)
Base.UICorner.CornerRadius = UDim.new(0,5)


local StatusBase = Instance.new("Frame")
StatusBase.Parent = Base
StatusBase.Name = "StatusBase"
StatusBase.BackgroundTransparency = 1
StatusBase.Position = UDim2.new(0.234, 0,0.197, 0)
StatusBase.Size = UDim2.new(0, 100,0, 65)
Instance.new("UICorner", StatusBase)
StatusBase.UICorner.CornerRadius = UDim.new(0,2)


local Turn = Instance.new("TextLabel")
Turn.Parent = StatusBase
Turn.Name = "Turn"
Turn.BackgroundTransparency = 1
Turn.Position = UDim2.new(0.12, 0,0.169, 0)
Turn.Size = UDim2.new(0, 76,0, 42)
Turn.Text = "OFF"
Turn.Font = Enum.Font.GothamBlack
Turn.TextScaled = true
Turn.TextColor3 = Color3.fromRGB(37, 39, 43)


local Guiname = Instance.new("TextLabel")
Guiname.Parent = Base
Guiname.Name = "Guiname"
Guiname.BackgroundTransparency = 1
Guiname.Position = UDim2.new(0.149, 0,0.077, 0)
Guiname.Size = UDim2.new(0, 132,0, 25)
Guiname.Text = "Graphics Mod"
Guiname.Font = Enum.Font.Gotham
Guiname.TextSize = 16
Guiname.TextColor3 = Color3.fromRGB(223, 235, 252)


local CloseButton = Instance.new("TextButton")
CloseButton.Parent = Base
CloseButton.Name = "Closebton"
CloseButton.BackgroundColor3 = Color3.fromRGB(184, 27, 30)
CloseButton.Position = UDim2.new(0.868, 0,0.039, 0)
CloseButton.Size = UDim2.new(0, 13,0, 13)
CloseButton.Text = " "
Instance.new("UICorner", CloseButton)
CloseButton.UICorner.CornerRadius = UDim.new(0,2)


local OFFButton = Instance.new("TextButton")
OFFButton.Parent = Base
OFFButton.Name = "OFFbton"
OFFButton.BackgroundTransparency = 1
OFFButton.Position = UDim2.new(0.197, 0,0.867, 0)
OFFButton.Size = UDim2.new(0, 113,0, 25)
OFFButton.Text = "OFF"
OFFButton.TextColor3 = Color3.fromRGB(209, 18, 22)
OFFButton.TextSize = 16
OFFButton.Font = Enum.Font.Gotham

local Options = Instance.new("Frame")
Options.Parent = Base
Options.Name = "Options"
Options.BackgroundTransparency = 1
Options.Position = UDim2.new(0.101, 0,0.433, 0)
Options.Size = UDim2.new(0, 149,0, 102)

local FOVtxt = Instance.new("TextLabel")
FOVtxt.Parent = Options
FOVtxt.Name = "FOVtxt"
FOVtxt.BackgroundTransparency = 1
FOVtxt.Position = UDim2.new(0.06, 0,0.098, 0)
FOVtxt.Size = UDim2.new(0, 46,0, 17)
FOVtxt.Text = "FOV"
FOVtxt.Font = Enum.Font.Gotham
FOVtxt.TextScaled = true
FOVtxt.TextColor3 = Color3.fromRGB(202, 213, 230)

local EnterFOV = Instance.new("TextBox")
EnterFOV.Parent = Options
EnterFOV.Name = "EnterFOV"
EnterFOV.BackgroundColor3 = Color3.fromRGB(4, 4, 4)
EnterFOV.Position = UDim2.new(0.638, 0,0.049, 0)
EnterFOV.Size = UDim2.new(0, 36,0, 27)
EnterFOV.Text = "70"
EnterFOV.Font = Enum.Font.GothamBlack
EnterFOV.TextSize = 14
EnterFOV.ClearTextOnFocus = false
EnterFOV.TextColor3 = Color3.fromRGB(215, 227, 244)
Instance.new("UICorner", EnterFOV)
EnterFOV.UICorner.CornerRadius = UDim.new(0,3)

local Hourtxt = Instance.new("TextLabel")
Hourtxt.Parent = Options
Hourtxt.Name = "Hourtxt"
Hourtxt.BackgroundTransparency = 1
Hourtxt.Position = UDim2.new(0.06, 0,0.412, 0)
Hourtxt.Size = UDim2.new(0, 46,0, 17)
Hourtxt.Text = "Hour"
Hourtxt.Font = Enum.Font.Gotham
Hourtxt.TextScaled = true
Hourtxt.TextColor3 = Color3.fromRGB(202, 213, 230)

local EnterHour = Instance.new("TextBox")
EnterHour.Parent = Options
EnterHour.Name = "EnterHour"
EnterHour.BackgroundColor3 = Color3.fromRGB(4, 4, 4)
EnterHour.Position = UDim2.new(0.638, 0,0.363, 0)
EnterHour.Size = UDim2.new(0, 36,0, 27)
EnterHour.Text = "14"
EnterHour.Font = Enum.Font.GothamBlack
EnterHour.TextSize = 14
EnterHour.ClearTextOnFocus = false
EnterHour.TextColor3 = Color3.fromRGB(215, 227, 244)
Instance.new("UICorner", Options.EnterHour)
Options.EnterHour.UICorner.CornerRadius = UDim.new(0,3)

local ONButton = Instance.new("TextButton")
ONButton.Parent = Base
ONButton.Name = "ONbton"
ONButton.BackgroundTransparency = 1
ONButton.Position = UDim2.new(0.197, 0,0.767, 0)
ONButton.Size = UDim2.new(0, 113,0, 25)
ONButton.Text = "ON/Apply"
ONButton.TextColor3 = Color3.fromRGB(0, 199, 106)
ONButton.TextSize = 15
ONButton.Font = Enum.Font.Gotham
Instance.new("UICorner", ONButton)
ONButton.UICorner.CornerRadius = UDim.new(0,8)



local RTXFolder = Instance.new("Folder")
RTXFolder.Name = "RTXFolder"
RTXFolder.Parent = CoreGui

local RTXEffect_SunRays = Instance.new("SunRaysEffect")
RTXEffect_SunRays.Name = "RTXSunRays"
RTXEffect_SunRays.Parent = RTXFolder
RTXEffect_SunRays.Spread = 1
RTXEffect_SunRays.Intensity = 0.158

local RTXEffect_Blur = Instance.new("BlurEffect")
RTXEffect_Blur.Parent = RTXFolder
RTXEffect_Blur.Name = "RTXBlur"
RTXEffect_Blur.Size = 4

local RTXEffect_Bloom = Instance.new("BloomEffect")
RTXEffect_Bloom.Parent = RTXFolder
RTXEffect_Bloom.Name = "RTXBloom"
RTXEffect_Bloom.Intensity = 1
RTXEffect_Bloom.Size = 24
RTXEffect_Bloom.Threshold = 2

local RTXEffect_Sky = Instance.new("Sky")
RTXEffect_Sky.Parent = RTXFolder
RTXEffect_Sky.Name = "RTXSky"

local RTXEffect_Atmosphere = Instance.new("Atmosphere")
RTXEffect_Atmosphere.Parent = RTXFolder
RTXEffect_Atmosphere.Name = "RTXAtmosphere"
RTXEffect_Atmosphere.Density = 0.333
RTXEffect_Atmosphere.Offset = 0

local RTXEffect_Color = Instance.new("ColorCorrectionEffect")
RTXEffect_Color.Parent = RTXFolder
RTXEffect_Color.Name = "RTXColor"
RTXEffect_Color.Contrast = 0.2
RTXEffect_Color.Saturation = 0.2

local RTXEffect_Light = Instance.new("PointLight")
RTXEffect_Light.Name = "RTXLight"
RTXEffect_Light.Parent = RTXFolder
RTXEffect_Light.Brightness = 1.32
RTXEffect_Light.Color = Color3.fromRGB(245,255,212)
RTXEffect_Light.Enabled = true
RTXEffect_Light.Range = 36
RTXEffect_Light.Shadows = true


UserInput.InputBegan:Connect(function(key)
	if key.KeyCode == Enum.KeyCode.F2 then
		if Base.Visible == false then
			Base.Visible = true
		else
			Base.Visible = false
		end
	end
end)

function TurnRTXON()	
	
    settings().Rendering.QualityLevel = Enum.QualityLevel.Level21
	settings().Rendering.EditQualityLevel = Enum.QualityLevel.Level21
	
	if isModON == false then
	RTXEffect_Sky:Clone().Parent = Lighting
	RTXEffect_Blur:Clone().Parent = Lighting
	RTXEffect_Bloom:Clone().Parent = Lighting
	RTXEffect_Color:Clone().Parent = Lighting
	RTXEffect_SunRays:Clone().Parent = Lighting
	end
	
	Lighting.GlobalShadows = true
	Lighting.ShadowSoftness = 0
	
	workspace.Terrain.WaterReflectance = 0
	workspace.Terrain.WaterTransparency = 1
	workspace.Terrain.WaterWaveSize = 1
	workspace.Terrain.WaterWaveSpeed = 15
	
	Lighting.ClockTime = EnterHour.Text
	
	if Lighting.ClockTime > 20 then
		pcall(function()
			RTXEffect_Light:Clone().Parent = game.Players.LocalPlayer.Character.Head
		end)
	end
	
	workspace.CurrentCamera.FieldOfView = EnterFOV.Text
	
	Turn.Text = "ON"
	Turn.TextColor3 = Color3.fromRGB(0,255,100)
	
	isModON = true
	
end

function TurnRTXOFF()
	
	isModON = false
	
	settings().Rendering.QualityLevel = Enum.QualityLevel.Level01
	settings().Rendering.QualityLevel = Enum.QualityLevel.Level01
	
	pcall(function()
		Lighting.RTXSunRays:Destroy()
		Lighting.RTXBlur:Destroy()
		Lighting.RTXBloom:Destroy()
		Lighting.RTXColor:Destroy()
		Lighting.RTXSky:Destroy()
		Lighting.RTXAtmosphere:Destroy()
		game.Players.LocalPlayer.Character.Head.RTXLight:Destroy()
	end)
	
	Lighting.ClockTime = Saved_ClockTime
	Lighting.GeographicLatitude = Saved_Latitude
	Lighting.GlobalShadows = Saved_Shadows
	
	workspace.CurrentCamera.FieldOfView = Saved_FOV
	
	workspace.Terrain.WaterReflectance = Saved_WaterReflect
	workspace.Terrain.WaterTransparency = Saved_WaterTransparency
	workspace.Terrain.WaterWaveSize = Saved_WaterWaveSide
	workspace.Terrain.WaterWaveSpeed = Saved_WaterSpeed
	
	Turn.Text = "OFF"
	Turn.TextColor3 = Color3.fromRGB(37, 39, 43)
	
end

ONButton.MouseButton1Click:Connect(TurnRTXON)
OFFButton.MouseButton1Click:Connect(TurnRTXOFF)

UserInput.InputBegan:Connect(function(key)
	if key.KeyCode == Enum.KeyCode.F8 then
		if isModON == false then
			TurnRTXON()
		else
			TurnRTXOFF()
		end
	end
end)

pcall(function()
	StarterGui:SetCore("SendNotification",{
		Title = "Graphics Mod",
		Text = "Loading Assets",
		Duration = 1.5
	})
	
	wait(1.6)
	
	StarterGui:SetCore("SendNotification",{
		Title = "Graphics Mod",
		Text = "Starting",
		Duration = 1
	})
	
	wait(1)
	
	RTXCore.Enabled = true
	
end)
	
end