settings().Rendering.QualityLevel = Enum.QualityLevel.Level01
settings().Rendering.EditQualityLevel = Enum.QualityLevel.Level01
settings().Rendering.GraphicsMode = Enum.GraphicsMode.OpenGL
settings().Rendering.FrameRateManager = Enum.FramerateManagerMode.Automatic


local Lighting = game:GetService("Lighting")
Lighting.GlobalShadows = false
Lighting.ClockTime = 17
Lighting.FogEnd = 10000000

local StarterGui = game:GetService("StarterGui")

workspace.Camera.FieldOfView = 100
workspace.Terrain.WaterReflectance = 0
workspace.Terrain.WaterTransparency = 0
workspace.Terrain.WaterWaveSize = 0
workspace.Terrain.WaterWaveSpeed = 0

local Unlock, FailUnlock = pcall(function()
	set_fps_cap(480)
end)

for _, Object in pairs(game:GetDescendants()) do
	
	if Object:IsA("Part") then
		Object.Material = Enum.Material.Plastic
	end
	
	if Object:IsA("WedgePart") then
		Object.Material = Enum.Material.Plastic
	end
	
	if Object:IsA("Decal") then
		Object.Texture = "rbxassetid://45651056123156651611"
	end
	
	if Object:IsA("Texture") then
		Object.Texture = "rbxassetid://45651056123156651611"
	end
	
	if Object:IsA("MeshPart") then
		Object.TextureID = "rbxassetid://45651056123156651611"
		local can, cannot = pcall(function()
			--Object.RenderFidelity = Enum.RenderFidelity.Performance
		end)
	end
	
	if Object:IsA("CornerWedgePart") then
		Object.Material = Enum.Material.Plastic	
	end
	
	if Object:IsA("TrussPart") then
		Object.Material = Enum.Material.Plastic
	end

        if Object:IsA("UnionOperation") then
		Object.Material = Enum.Material.Plastic
	end
	
	if Object:IsA("Fire") then
		Object:Destroy()
	end
	
	if Object:IsA("Smoke") then
		Object:Destroy()
	end
	
	if Object:IsA("ParticleEmitter") then
		Object:Destroy()
	end
	
	if Object:IsA("SurfaceAppearance") then
		Object:Destroy()
	end
	
	if Object:IsA("BlurEffect") then
		Object:Destroy()
	end
	
	if Object:IsA("BloomEffect") then
		Object:Destroy()
	end
	
	if Object:IsA("ColorCorrectionEffect") then
		Object:Destroy()
	end
	
	if Object:IsA("DepthOfFieldEffect") then
		Object:Destroy()
	end
	
	if Object:IsA("SunRaysEffect") then
		Object:Destroy()
	end
	
	if Object:IsA("Sky") then
		Object:Destroy()
	end
	
	if Object:IsA("Atmosphere") then
		Object:Destroy()
	end
	
	if Object:IsA("Clouds") then
		Object:Destroy()
	end
	
	if Object:IsA("Highlight") then
		Object:Destroy()
	end
	
	if Object:IsA("Sparkles") then
		Object:Destroy()
	end
end

local can, fail = pcall(function()
	StarterGui:SetCore("SendNotification",{
		Title = "Optimized",
		Text = "Graphics Settings Applied",
		Icon = "http://www.roblox.com/asset/?id=6771709231",
		Duration = 3.3
	})
end)