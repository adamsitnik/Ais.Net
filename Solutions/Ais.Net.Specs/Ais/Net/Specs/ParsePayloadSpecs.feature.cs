﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.7.0.0
//      SpecFlow Generator Version:3.7.0.0
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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.7.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ParsePayloadSpecs")]
    public partial class ParsePayloadSpecsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ParsePayloadSpecs.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Ais/Net/Specs", "ParsePayloadSpecs", "    In order process AIS messages from an nm4 file\r\n    As a developer\r\n    I wan" +
                    "t the NmeaPayloadParser to be able report the message type", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Peek message type without decoding in full")]
        [NUnit.Framework.TestCaseAttribute("1000000000000000000000000000", "0", "1", null)]
        [NUnit.Framework.TestCaseAttribute("13nW5<00000IoPlSbE`:P8EH0534", "0", "1", null)]
        [NUnit.Framework.TestCaseAttribute("2000000000000000000000000000", "0", "2", null)]
        [NUnit.Framework.TestCaseAttribute("24c`1`001pPEGSLR:=df3@4620SQ", "0", "2", null)]
        [NUnit.Framework.TestCaseAttribute("3000000000000000000000000000", "0", "3", null)]
        [NUnit.Framework.TestCaseAttribute("33m9UtPP@50wwE:VJW6LS67H01<@", "0", "3", null)]
        [NUnit.Framework.TestCaseAttribute("50000000000000000000000000000000000000000000000000000000000000000000000", "2", "5", null)]
        [NUnit.Framework.TestCaseAttribute("53m8lk`00000hS;;SP0Hu<p61HTdTpL00000000F0H<654@pt0;@0000000000000000000", "2", "5", null)]
        [NUnit.Framework.TestCaseAttribute("B000000000000000000000000000", "0", "18", null)]
        [NUnit.Framework.TestCaseAttribute("B3o8B<00F8:0h694gOtbgwqUoP06", "0", "18", null)]
        [NUnit.Framework.TestCaseAttribute("H000000000000000000000000000", "0", "24", null)]
        [NUnit.Framework.TestCaseAttribute("H3m9b308tL5<d`4E80000000000", "2", "24", null)]
        public virtual void PeekMessageTypeWithoutDecodingInFull(string payload, string padding, string type, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("payload", payload);
            argumentsOfScenario.Add("padding", padding);
            argumentsOfScenario.Add("type", type);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Peek message type without decoding in full", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 15
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
#line 16
 testRunner.When(string.Format("I peek at the payload \'{0}\' with padding of {1}", payload, padding), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then(string.Format("the message type returned by peek should be {0}", type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
