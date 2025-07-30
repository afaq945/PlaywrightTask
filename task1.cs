using Microsoft.Playwright.NUnit;
using Microsoft.Playwright;

[Parallelizable(ParallelScope.Self)]
[TestFixture]
public class Task1 : PageTest
{
    [Test]
    public async Task MyTest()
    {
    
        await Page.GotoAsync("https://demo.snipeitapp.com/login");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Username" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Username" }).FillAsync("admin");
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Password" }).ClickAsync();
        await Page.GetByRole(AriaRole.Textbox, new() { Name = "Password" }).FillAsync("password");
        await Page.GetByRole(AriaRole.Button, new() { Name = "Login" }).ClickAsync();
        await Page.GetByText("Create New", new() { Exact = true }).ClickAsync();
        await Page.GetByRole(AriaRole.Navigation).GetByText("Asset", new() { Exact = true }).ClickAsync();
        await Page.Locator("#select2-company_select-container").ClickAsync();
        await Page.GetByText("Hamill, Satterfield and").ClickAsync();
        await Page.Locator("#select2-model_select_id-container").ClickAsync();
        await Page.GetByRole(AriaRole.Searchbox).FillAsync("mac");
        await Page.GetByText("Laptops - Macbook Pro 13\"").ClickAsync();
        await Page.GetByLabel("Select Status").GetByText("Select Status").ClickAsync();
        await Page.GetByRole(AriaRole.Option, new() { Name = "Ready to Deploy" }).ClickAsync();
        await Page.GetByLabel("Select a User").GetByText("Select a User").ClickAsync();
        await Page.GetByText("Abshire, Brandon (dmarvin) - #").ClickAsync();
        await Page.Locator("#submit_button").ClickAsync();
        await Page.GetByRole(AriaRole.Cell, new() { Name = " (AW07134186) - Macbook Pro 13\" asset" }).GetByRole(AriaRole.Link).ClickAsync();
        await Page.GetByRole(AriaRole.Link, new() { Name = "History" }).ClickAsync();
        await Page.GetByRole(AriaRole.Cell, new() { Name = " (AW07134186) - Macbook Pro 13\" asset" }).GetByRole(AriaRole.Link).ClickAsync();
    }
}
