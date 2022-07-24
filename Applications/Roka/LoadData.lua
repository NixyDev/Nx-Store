local Games = {286090429}


function SendNotify()
    local Ad = Instance.new("BoolValue")
    Ad.Parent = game

    game:GetService("StarterGui"):SetCore("SendNotification" ,{
        Title = "Mapa"
        Text = "Quieres Meterle a Dora?\n".."[F1] Claro, [F2] NO"
        Duration = 6
    })

    game:GetService("UserInputService").InputBegan:Connect(function(Key)
        if Key.KeyCode == Enum.KeyCode.F1 then
            if game.Value then

                if game.PlaceId == 286090429 then
                    loadstring(game:HttpGet("https://raw.githubusercontent.com/CriShoux/OwlHub/master/OwlHub.txt"))()
                    Ad:Destroy()
                end

            end
        end
    end)
end

for Index, SupportedGame in pairs(Games) do
    if game.PlaceId == SupportedGame then
        SendNotify()
    end
end
