local StarterGui = game:GetService("StarterGui")
local Bindable = Instance.new("BindableFunction")

local Sound = Instance.new("Sound", game.CoreGui)
Sound.SoundId = "rbxassetid://9622150802"
Sound.Volume = 3.6

function SendNotification(Message)
	StarterGui:SetCore("SendNotification",{
		Title = "Roka";
		Text = "Quieres ejecutar los scripts para "..tostring(Message).."?";
		Icon = "rbxassetid://8436917300";
		Button1 = "Si";
		Button2 = "No";
		Duration = 9999999999999999999999999999999999999999999;
		Callback = Bindable
	})
end

Bindable.OnInvoke = function(Response)
	
	if game.GameId == 115797356 then
		if Response == "Si" then
			Sound:Stop()
			Sound:Destroy()
			loadstring(game:HttpGet('https://raw.githubusercontent.com/venosu/Hex-Hub/main/hexhub.lua'))()
			loadstring(game:HttpGet('https://raw.githubusercontent.com/NixyDev/Mods/main/Universal_Aimlock.lua'))()
		else
			Sound:Stop()
			Sound:Destroy()
		end
		
	elseif game.GameId == 111958650 then
		if Response == "Si" then
			Sound:Stop()
			Sound:Destroy()
			loadstring(game:HttpGet("https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt"))()
		else
			Sound:Stop()
			Sound:Destroy()
		end
	
	elseif game.PlaceId == 4282985734 then
		if Response == "Si" then
			Sound:Stop()
			Sound:Destroy()
			loadstring(game:HttpGet("https://projecthook.xyz/scripts/free.lua"))()
		else
			Sound:Stop()
			Sound:Destroy()
		end
		
		elseif game.GameId == 703124385 or game.PlaceId == 189707 then
		if Response == "Si" then
			Sound:Stop()
			Sound:Destroy()
			loadstring("\108\111\97\100\115\116\114\105\110\103\40\103\97\109\101\58\72\116\116\112\71\101\116\40\40\39\104\116\116\112\115\58\47\47\103\105\115\116\46\103\105\116\104\117\98\117\115\101\114\99\111\110\116\101\110\116\46\99\111\109\47\109\101\111\122\111\110\101\89\84\47\98\102\48\51\55\100\102\102\57\102\48\97\55\48\48\49\55\51\48\52\100\100\100\54\55\102\100\99\100\51\55\48\47\114\97\119\47\101\49\52\101\55\52\102\52\50\53\98\48\54\48\100\102\53\50\51\51\52\51\99\102\51\48\98\55\56\55\48\55\52\101\98\51\99\53\100\50\47\97\114\99\101\117\115\37\50\53\50\48\120\37\50\53\50\48\102\108\121\37\50\53\50\48\50\37\50\53\50\48\111\98\102\108\117\99\97\116\111\114\39\41\44\116\114\117\101\41\41\40\41\10\10")()
		else
			Sound:Stop()
			Sound:Destroy()
		end
	end
	
end


if game.GameId == 115797356 then
	SendNotification("Counter Blox")
	Sound:Play()

elseif game.GameId == 111958650 then
	SendNotification("Arsenal")
	Sound:Play()

elseif game.PlaceId == 4282985734 then
	SendNotification("Combat Warriors")
	Sound:Play()
	
elseif game.GameId == 703124385 or game.PlaceId == 189707 then
    if game.GameId == 	703124385 then
        SendNotification("Tower of Hell")
        Sound:Play()	
    end

     if game.PlaceId == 189707 then
	SendNotification("Natural Disaster")
        Sound:Play()
     end		
end