parser grammar SampleParser;

options {
    superClass = Antlr4.Next.Parser;
    tokenVocab=SampleLexer;
}


ruleA: A B C;
