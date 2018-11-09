<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SpellCheckerCustomDictionarySample.Default" %>

<%@ Register assembly="DevExpress.Web.ASPxSpellChecker.v15.2, Version=15.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxSpellChecker" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Dictionary Sample
    </title>
</head>
<body>
     <dx:ASPxGlobalEvents ID="ASPxGlobalEvents1" runat="server">
        <ClientSideEvents ControlsInitialized="function(s, e) { if (!e.isCallback) checkButton.SetEnabled(true); }" />
    </dx:ASPxGlobalEvents>
    
    <form id="form1" runat="server">
    <div>
    <dx:ASPxButton ID="checkButton" runat="server" ClientInstanceName="checkButton" ClientEnabled="false"
        Text="Check Spelling ..." AutoPostBack="False">
        <ClientSideEvents Click="function(s, e) { spellchecker.CheckElement(ASPxMemo1); }" />
    </dx:ASPxButton>
        <br />
        <dx:ASPxMemo ID="ASPxMemo1" runat="server" Height="372px" Width="637px" Text="After several months of dificult coding, we installed Silverlight vesion on our own desktop machines, paying particular attention to floppy disk speed. However, Gaussian electromagnetic distubances in our XBox network caused unstable experimental results. &#13;&#10;">
        </dx:ASPxMemo>
        &nbsp;
        </div>
<dx:ASPxSpellChecker ID="ASPxSpellChecker1" runat="server" Culture="English (United States)" ClientInstanceName="spellchecker" 
        OnWordAdded="ASPxSpellChecker1_WordAdded"  OnCustomDictionaryLoading="ASPxSpellChecker1_CustomDictionaryLoading">
            <SettingsSpelling IgnoreMixedCaseWords="False" IgnoreUpperCaseWords="False" />
            <Dictionaries>
<dx:ASPxSpellCheckerISpellDictionary AlphabetPath="~/Dictionaries/EnglishAlphabet.txt" GrammarPath="~/Dictionaries/english.aff" DictionaryPath="~/Dictionaries/american.xlg" CacheKey="ispellDic" Culture="English (United States)" EncodingName="Western European (Windows)"></dx:ASPxSpellCheckerISpellDictionary>
<dx:ASPxSpellCheckerCustomDictionary AlphabetPath="~/Dictionaries/EnglishAlphabet.txt" DictionaryPath="~/Dictionaries/CustomEnglish.dic" CacheKey="customDic1" Culture="English (United States)" EncodingName="Western European (Windows)"></dx:ASPxSpellCheckerCustomDictionary>
</Dictionaries>
            <ClientSideEvents BeforeCheck="function(s, e) {	checkButton.SetEnabled(false); }"
                AfterCheck="function(s, e) { checkButton.SetEnabled(true); }" />
        </dx:ASPxSpellChecker>
    </form>
    
</body>
</html>
