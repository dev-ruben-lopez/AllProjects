-----------------------------------------------------------------------------------------
--
-- main.lua
--
-----------------------------------------------------------------------------------------
local physics = require( "physics" )
physics.start()
-- Your code here

local background = display.newImageRect("background.png",750,1334)
background.x = display.contentCenterX
background.y = display.contentCenterY


local platform = display.newImageRect("platform.png",700,60)
platform.x = display.contentCenterX
platform.y = display.contentHeight

local ballon = display.newImageRect("balloon.png", 112,112)
ballon.x = display.contentCenterX
ballon.y = display.contentCenterY
ballon.alpha = 0.8


physics.addBody(platform,"static")
physics.addBody(ballon,"dynamic", {radius=55, bounce=0.3})



-- Functions
local function pushBalloon()
    ballon:applyLinearImpulse( 0, -0.75, ballon.x, ballon.y )
end



--events
ballon:addEventListener( "tap", pushBalloon )