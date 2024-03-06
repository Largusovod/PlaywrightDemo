﻿using Microsoft.Playwright;

using var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Firefox.LaunchAsync(new()
{
    Headless = false,
    SlowMo = 10,
});
var page = await browser.NewPageAsync();
await page.GotoAsync("https://playwright.dev/dotnet");
await page.ScreenshotAsync(new()
{
    Path = "screenshot.png"
});
