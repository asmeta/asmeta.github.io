// attenzione questo genera emf sotto src di questo progetto
// e un progetto fs,.resource.fsm
SYNTAXDEF fsm
FOR <http://www.asmeta.org/fsm> 
START Fsm

OPTIONS {
	reloadGeneratorModel = "true";
	generateCodeFromGeneratorModel = "true";
	overrideManifest = "false";
    overrideClasspath = "false";
	overrideProjectFile = "false";
	tokenspace = "1";
	usePredefinedTokens = "true";
//	defaultTokenName ="name";
	
} 
TOKENS {
	DEFINE COMMENT $'//'(~('\n'|'\r'|'\uffff'))*$;
//	DEFINE NAME $(('a'..'z')|('A'..'Z')) (('a'..'z')|('A'..'Z')|('0'..'9'))*$;
//	DEFINE WHITESPACE $(' '|'\t'|'\f')$;
//	DEFINE LINEBREAKS $('\r\n'|'\r'|'\n')$;
}
 
TOKENSTYLES {
	"COMMENT" COLOR #008200, ITALIC;
	"QUOTED_34_34" COLOR #404040;	
}
 


RULES {

	Fsm   ::= "fsm" name['"','"']  ("inputAlphabet" inputAlphabet[])? ("outputAlphabet" outputAlphabet[])? "states" (states)+ ";" "transitions" (transitions)*;
	
	State ::= isStart[]? name[]; 
	
	Transition ::=  name[] ":" from[] "-" input[] ("/" output[])? "->" to[] ";";
}