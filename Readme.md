<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/SpellCheckerCustomDictionarySample/Default.aspx) (VB: [Default.aspx](./VB/SpellCheckerCustomDictionarySample/Default.aspx))
* [Default.aspx.cs](./CS/SpellCheckerCustomDictionarySample/Default.aspx.cs) (VB: [Default.aspx](./VB/SpellCheckerCustomDictionarySample/Default.aspx))
<!-- default file list end -->
# How to load a user-specific dictionary and update it during spelling check


<p>This example demonstrates how to load a user-specific dictionary when spelling check is started and save the words added by the end-user.<br />
The <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxSpellCheckerASPxSpellChecker_CustomDictionaryLoadingtopic"><u>CustomDictionaryLoading</u></a> event enables you to load a custom dictionary from the stream when the spelling check begins. <br />
The <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxSpellCheckerASPxSpellChecker_WordAddedtopic"><u>WordAdded</u></a> event is fired after a word is added to the custom dictionary (using the 'Add to Dictionary' button located on the Check Spelling form). Then the updated custom dictionary is saved to its original location.<br />
</p>

<br/>


