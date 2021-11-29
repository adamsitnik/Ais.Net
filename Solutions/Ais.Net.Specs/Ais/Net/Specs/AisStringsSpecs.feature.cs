﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Ais.Net.Specs
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AisStringsSpecs")]
    public partial class AisStringsSpecsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AisStringsSpecs.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Ais/Net/Specs", "AisStringsSpecs", "\tIn order to work with strings in AIS messages\r\n\tAs a developer\r\n\tI want to be ab" +
                    "le to convert between AIS\'s text representations and ASCII", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Convert AIS 6-bit character to ASCII")]
        [NUnit.Framework.TestCaseAttribute("0", "\'@\'", null)]
        [NUnit.Framework.TestCaseAttribute("1", "\'A\'", null)]
        [NUnit.Framework.TestCaseAttribute("2", "\'B\'", null)]
        [NUnit.Framework.TestCaseAttribute("3", "\'C\'", null)]
        [NUnit.Framework.TestCaseAttribute("4", "\'D\'", null)]
        [NUnit.Framework.TestCaseAttribute("5", "\'E\'", null)]
        [NUnit.Framework.TestCaseAttribute("6", "\'F\'", null)]
        [NUnit.Framework.TestCaseAttribute("7", "\'G\'", null)]
        [NUnit.Framework.TestCaseAttribute("8", "\'H\'", null)]
        [NUnit.Framework.TestCaseAttribute("9", "\'I\'", null)]
        [NUnit.Framework.TestCaseAttribute("10", "\'J\'", null)]
        [NUnit.Framework.TestCaseAttribute("11", "\'K\'", null)]
        [NUnit.Framework.TestCaseAttribute("12", "\'L\'", null)]
        [NUnit.Framework.TestCaseAttribute("13", "\'M\'", null)]
        [NUnit.Framework.TestCaseAttribute("14", "\'N\'", null)]
        [NUnit.Framework.TestCaseAttribute("15", "\'O\'", null)]
        [NUnit.Framework.TestCaseAttribute("16", "\'P\'", null)]
        [NUnit.Framework.TestCaseAttribute("17", "\'Q\'", null)]
        [NUnit.Framework.TestCaseAttribute("18", "\'R\'", null)]
        [NUnit.Framework.TestCaseAttribute("19", "\'S\'", null)]
        [NUnit.Framework.TestCaseAttribute("20", "\'T\'", null)]
        [NUnit.Framework.TestCaseAttribute("21", "\'U\'", null)]
        [NUnit.Framework.TestCaseAttribute("22", "\'V\'", null)]
        [NUnit.Framework.TestCaseAttribute("23", "\'W\'", null)]
        [NUnit.Framework.TestCaseAttribute("24", "\'X\'", null)]
        [NUnit.Framework.TestCaseAttribute("25", "\'Y\'", null)]
        [NUnit.Framework.TestCaseAttribute("26", "\'Z\'", null)]
        [NUnit.Framework.TestCaseAttribute("27", "\'[\'", null)]
        [NUnit.Framework.TestCaseAttribute("28", "\'\\\'", null)]
        [NUnit.Framework.TestCaseAttribute("29", "\']\'", null)]
        [NUnit.Framework.TestCaseAttribute("30", "\'^\'", null)]
        [NUnit.Framework.TestCaseAttribute("31", "\'_\'", null)]
        [NUnit.Framework.TestCaseAttribute("32", "\' \'", null)]
        [NUnit.Framework.TestCaseAttribute("33", "\'!\'", null)]
        [NUnit.Framework.TestCaseAttribute("34", "\'\"\'", null)]
        [NUnit.Framework.TestCaseAttribute("35", "\'#\'", null)]
        [NUnit.Framework.TestCaseAttribute("36", "\'$\'", null)]
        [NUnit.Framework.TestCaseAttribute("37", "\'%\'", null)]
        [NUnit.Framework.TestCaseAttribute("38", "\'&\'", null)]
        [NUnit.Framework.TestCaseAttribute("39", "\'\'\'", null)]
        [NUnit.Framework.TestCaseAttribute("40", "\'(\'", null)]
        [NUnit.Framework.TestCaseAttribute("41", "\')\'", null)]
        [NUnit.Framework.TestCaseAttribute("42", "\'*\'", null)]
        [NUnit.Framework.TestCaseAttribute("43", "\'+\'", null)]
        [NUnit.Framework.TestCaseAttribute("44", "\',\'", null)]
        [NUnit.Framework.TestCaseAttribute("45", "\'-\'", null)]
        [NUnit.Framework.TestCaseAttribute("46", "\'.\'", null)]
        [NUnit.Framework.TestCaseAttribute("47", "\'/\'", null)]
        [NUnit.Framework.TestCaseAttribute("48", "\'0\'", null)]
        [NUnit.Framework.TestCaseAttribute("49", "\'1\'", null)]
        [NUnit.Framework.TestCaseAttribute("50", "\'2\'", null)]
        [NUnit.Framework.TestCaseAttribute("51", "\'3\'", null)]
        [NUnit.Framework.TestCaseAttribute("52", "\'4\'", null)]
        [NUnit.Framework.TestCaseAttribute("53", "\'5\'", null)]
        [NUnit.Framework.TestCaseAttribute("54", "\'6\'", null)]
        [NUnit.Framework.TestCaseAttribute("55", "\'7\'", null)]
        [NUnit.Framework.TestCaseAttribute("56", "\'8\'", null)]
        [NUnit.Framework.TestCaseAttribute("57", "\'9\'", null)]
        [NUnit.Framework.TestCaseAttribute("58", "\':\'", null)]
        [NUnit.Framework.TestCaseAttribute("59", "\';\'", null)]
        [NUnit.Framework.TestCaseAttribute("60", "\'<\'", null)]
        [NUnit.Framework.TestCaseAttribute("61", "\'=\'", null)]
        [NUnit.Framework.TestCaseAttribute("62", "\'>\'", null)]
        [NUnit.Framework.TestCaseAttribute("63", "\'?\'", null)]
        public virtual void ConvertAIS6_BitCharacterToASCII(string aisChar, string asciiChar, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("aisChar", aisChar);
            argumentsOfScenario.Add("asciiChar", asciiChar);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Convert AIS 6-bit character to ASCII", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
 testRunner.When(string.Format("I convert the AIS character value {0} to ASCII", aisChar), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then(string.Format("the converted ASCII value should be {0}", asciiChar), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
