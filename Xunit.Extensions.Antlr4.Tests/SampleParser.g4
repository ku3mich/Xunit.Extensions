parser grammar SampleParser;

options {
    superClass = Antlr4.Parser;
    tokenVocab=SampleLexer;
}


ruleA: A B C;
