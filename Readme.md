# ASP.NET Web Forms Spell Checker - Load a custom dictionary and update it during spell check operations

This example demonstrates how to load a custom dictionary once a spelling check operation is started and save the words added by a user. Handle the [CustomDictionaryLoading](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxSpellChecker.ASPxSpellChecker.CustomDictionaryLoading) event to load a custom dictionary from the stream. Once a word is added to the custom dictionary (using the 'Add to Dictionary' button on the Check Spelling form), the [WordAdded](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxSpellChecker.ASPxSpellChecker.WordAdded)> event is raised. After that, the updated custom dictionary is saved to its original location.

## Files to Review

* [Default.aspx](./CS/SpellCheckerCustomDictionarySample/Default.aspx) (VB: [Default.aspx](./VB/SpellCheckerCustomDictionarySample/Default.aspx))
* [Default.aspx.cs](./CS/SpellCheckerCustomDictionarySample/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/SpellCheckerCustomDictionarySample/Default.aspx.vb))

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-load-a-user-specific-dictionary-and-update-it-during-spelling-check-e3002&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-load-a-user-specific-dictionary-and-update-it-during-spelling-check-e3002&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
