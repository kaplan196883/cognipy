using System;
using Tools;
namespace CogniPy.CNL.EN
{
    //%+paragraph+102
    public partial class paragraph : PartialSymbol
    {
        public override string yyname_endl { get { return "paragraph"; } }
        public override int yynum_endl { get { return 102; } }
    }
    //%+sentence+103
    public partial class sentence : PartialSymbol
    {
        public override string yyname_endl { get { return "sentence"; } }
        public override int yynum_endl { get { return 103; } }
    }
    //%+annotation+104
    public partial class annotation : sentence
    {
        public override string yyname_endl { get { return "annotation"; } }
        public override int yynum_endl { get { return 104; } }
    }
    //%+subsumption+105
    public partial class subsumption : sentence
    {
        public override string yyname_endl { get { return "subsumption"; } }
        public override int yynum_endl { get { return 105; } }
    }
    //%+nosubsumption+106
    public partial class nosubsumption : sentence
    {
        public override string yyname_endl { get { return "nosubsumption"; } }
        public override int yynum_endl { get { return 106; } }
    }
    //%+subsumption_if+107
    public partial class subsumption_if : sentence
    {
        public override string yyname_endl { get { return "subsumption_if"; } }
        public override int yynum_endl { get { return 107; } }
    }
    //%+datatypedef+108
    public partial class datatypedef : sentence
    {
        public override string yyname_endl { get { return "datatypedef"; } }
        public override int yynum_endl { get { return 108; } }
    }
    //%+equivalence2+109
    public partial class equivalence2 : sentence
    {
        public override string yyname_endl { get { return "equivalence2"; } }
        public override int yynum_endl { get { return 109; } }
    }
    //%+exclusives+110
    public partial class exclusives : sentence
    {
        public override string yyname_endl { get { return "exclusives"; } }
        public override int yynum_endl { get { return 110; } }
    }
    //%+exclusiveunion+111
    public partial class exclusiveunion : sentence
    {
        public override string yyname_endl { get { return "exclusiveunion"; } }
        public override int yynum_endl { get { return 111; } }
    }
    //%+rolesubsumption+112
    public partial class rolesubsumption : sentence
    {
        public override string yyname_endl { get { return "rolesubsumption"; } }
        public override int yynum_endl { get { return 112; } }
    }
    //%+roleequivalence2+113
    public partial class roleequivalence2 : sentence
    {
        public override string yyname_endl { get { return "roleequivalence2"; } }
        public override int yynum_endl { get { return 113; } }
    }
    //%+roledisjoint2+114
    public partial class roledisjoint2 : sentence
    {
        public override string yyname_endl { get { return "roledisjoint2"; } }
        public override int yynum_endl { get { return 114; } }
    }
    //%+datarolesubsumption+115
    public partial class datarolesubsumption : sentence
    {
        public override string yyname_endl { get { return "datarolesubsumption"; } }
        public override int yynum_endl { get { return 115; } }
    }
    //%+dataroleequivalence2+116
    public partial class dataroleequivalence2 : sentence
    {
        public override string yyname_endl { get { return "dataroleequivalence2"; } }
        public override int yynum_endl { get { return 116; } }
    }
    //%+dataroledisjoint2+117
    public partial class dataroledisjoint2 : sentence
    {
        public override string yyname_endl { get { return "dataroledisjoint2"; } }
        public override int yynum_endl { get { return 117; } }
    }
    //%+haskey+118
    public partial class haskey : sentence
    {
        public override string yyname_endl { get { return "haskey"; } }
        public override int yynum_endl { get { return 118; } }
    }
    //%+subject+119
    public partial class subject : PartialSymbol
    {
        public override string yyname_endl { get { return "subject"; } }
        public override int yynum_endl { get { return 119; } }
    }
    //%+subjectEvery+120
    public partial class subjectEvery : subject
    {
        public override string yyname_endl { get { return "subjectEvery"; } }
        public override int yynum_endl { get { return 120; } }
    }
    //%+subjectEverything+121
    public partial class subjectEverything : subject
    {
        public override string yyname_endl { get { return "subjectEverything"; } }
        public override int yynum_endl { get { return 121; } }
    }
    //%+subjectBigName+122
    public partial class subjectBigName : subject
    {
        public override string yyname_endl { get { return "subjectBigName"; } }
        public override int yynum_endl { get { return 122; } }
    }
    //%+subjectThe+123
    public partial class subjectThe : subject
    {
        public override string yyname_endl { get { return "subjectThe"; } }
        public override int yynum_endl { get { return 123; } }
    }
    //%+nosubject+124
    public partial class nosubject : PartialSymbol
    {
        public override string yyname_endl { get { return "nosubject"; } }
        public override int yynum_endl { get { return 124; } }
    }
    //%+subjectNo+125
    public partial class subjectNo : nosubject
    {
        public override string yyname_endl { get { return "subjectNo"; } }
        public override int yynum_endl { get { return 125; } }
    }
    //%+subjectNothing+126
    public partial class subjectNothing : nosubject
    {
        public override string yyname_endl { get { return "subjectNothing"; } }
        public override int yynum_endl { get { return 126; } }
    }
    //%+objectRoleExpr+127
    public partial class objectRoleExpr : PartialSymbol
    {
        public override string yyname_endl { get { return "objectRoleExpr"; } }
        public override int yynum_endl { get { return 127; } }
    }
    //%+objectRoleExpr1+128
    public partial class objectRoleExpr1 : objectRoleExpr
    {
        public override string yyname_endl { get { return "objectRoleExpr1"; } }
        public override int yynum_endl { get { return 128; } }
    }
    //%+objectRoleExpr2+129
    public partial class objectRoleExpr2 : objectRoleExpr
    {
        public override string yyname_endl { get { return "objectRoleExpr2"; } }
        public override int yynum_endl { get { return 129; } }
    }
    //%+objectRoleExpr3+130
    public partial class objectRoleExpr3 : objectRoleExpr
    {
        public override string yyname_endl { get { return "objectRoleExpr3"; } }
        public override int yynum_endl { get { return 130; } }
    }
    //%+modality+131
    public partial class modality : PartialSymbol
    {
        public override string yyname_endl { get { return "modality"; } }
        public override int yynum_endl { get { return 131; } }
    }
    //%+isBeAre+132
    public partial class isBeAre : PartialSymbol
    {
        public override string yyname_endl { get { return "isBeAre"; } }
        public override int yynum_endl { get { return 132; } }
    }
    //%+aAn+133
    public partial class aAn : PartialSymbol
    {
        public override string yyname_endl { get { return "aAn"; } }
        public override int yynum_endl { get { return 133; } }
    }
    //%+valueOrThing+134
    public partial class valueOrThing : PartialSymbol
    {
        public override string yyname_endl { get { return "valueOrThing"; } }
        public override int yynum_endl { get { return 134; } }
    }
    //%+instance+135
    public partial class instance : PartialSymbol
    {
        public override string yyname_endl { get { return "instance"; } }
        public override int yynum_endl { get { return 135; } }
    }
    //%+instanceThe+136
    public partial class instanceThe : instance
    {
        public override string yyname_endl { get { return "instanceThe"; } }
        public override int yynum_endl { get { return 136; } }
    }
    //%+instanceBigName+137
    public partial class instanceBigName : instance
    {
        public override string yyname_endl { get { return "instanceBigName"; } }
        public override int yynum_endl { get { return 137; } }
    }
    //%+instanceList+138
    public partial class instanceList : PartialSymbol
    {
        public override string yyname_endl { get { return "instanceList"; } }
        public override int yynum_endl { get { return 138; } }
    }
    //%+chain+139
    public partial class chain : PartialSymbol
    {
        public override string yyname_endl { get { return "chain"; } }
        public override int yynum_endl { get { return 139; } }
    }
    //%+orObjectRoleExprChain+140
    public partial class orObjectRoleExprChain : PartialSymbol
    {
        public override string yyname_endl { get { return "orObjectRoleExprChain"; } }
        public override int yynum_endl { get { return 140; } }
    }
    //%+andanyrolechain+141
    public partial class andanyrolechain : PartialSymbol
    {
        public override string yyname_endl { get { return "andanyrolechain"; } }
        public override int yynum_endl { get { return 141; } }
    }
    //%+oobject+142
    public partial class oobject : PartialSymbol
    {
        public override string yyname_endl { get { return "oobject"; } }
        public override int yynum_endl { get { return 142; } }
    }
    //%+oobjectA+143
    public partial class oobjectA : oobject
    {
        public override string yyname_endl { get { return "oobjectA"; } }
        public override int yynum_endl { get { return 143; } }
    }
    //%+oobjectInstance+144
    public partial class oobjectInstance : oobject
    {
        public override string yyname_endl { get { return "oobjectInstance"; } }
        public override int yynum_endl { get { return 144; } }
    }
    //%+oobjectRelated+145
    public partial class oobjectRelated : oobject
    {
        public override string yyname_endl { get { return "oobjectRelated"; } }
        public override int yynum_endl { get { return 145; } }
    }
    //%+oobjectOnly+146
    public partial class oobjectOnly : oobjectRelated
    {
        public override string yyname_endl { get { return "oobjectOnly"; } }
        public override int yynum_endl { get { return 146; } }
    }
    //%+oobjectOnlyInstance+147
    public partial class oobjectOnlyInstance : oobjectRelated
    {
        public override string yyname_endl { get { return "oobjectOnlyInstance"; } }
        public override int yynum_endl { get { return 147; } }
    }
    //%+oobjectCardinal+148
    public partial class oobjectCardinal : oobjectRelated
    {
        public override string yyname_endl { get { return "oobjectCardinal"; } }
        public override int yynum_endl { get { return 148; } }
    }
    //%+oobjectCmp+149
    public partial class oobjectCmp : oobjectCardinal
    {
        public override string yyname_endl { get { return "oobjectCmp"; } }
        public override int yynum_endl { get { return 149; } }
    }
    //%+oobjectCmpInstance+150
    public partial class oobjectCmpInstance : oobjectCardinal
    {
        public override string yyname_endl { get { return "oobjectCmpInstance"; } }
        public override int yynum_endl { get { return 150; } }
    }
    //%+oobjectBnd+151
    public partial class oobjectBnd : oobjectRelated
    {
        public override string yyname_endl { get { return "oobjectBnd"; } }
        public override int yynum_endl { get { return 151; } }
    }
    //%+oobjectOnlyBnd+152
    public partial class oobjectOnlyBnd : oobjectRelated
    {
        public override string yyname_endl { get { return "oobjectOnlyBnd"; } }
        public override int yynum_endl { get { return 152; } }
    }
    //%+oobjectCmpBnd+153
    public partial class oobjectCmpBnd : oobjectCardinal
    {
        public override string yyname_endl { get { return "oobjectCmpBnd"; } }
        public override int yynum_endl { get { return 153; } }
    }
    //%+oobjectSelf+154
    public partial class oobjectSelf : oobjectRelated
    {
        public override string yyname_endl { get { return "oobjectSelf"; } }
        public override int yynum_endl { get { return 154; } }
    }
    //%+oobjectSomething+155
    public partial class oobjectSomething : oobject
    {
        public override string yyname_endl { get { return "oobjectSomething"; } }
        public override int yynum_endl { get { return 155; } }
    }
    //%+oobjectNothing+156
    public partial class oobjectNothing : oobject
    {
        public override string yyname_endl { get { return "oobjectNothing"; } }
        public override int yynum_endl { get { return 156; } }
    }
    //%+oobjectOnlyNothing+157
    public partial class oobjectOnlyNothing : oobjectRelated
    {
        public override string yyname_endl { get { return "oobjectOnlyNothing"; } }
        public override int yynum_endl { get { return 157; } }
    }
    //%+oobjectSomethingThat+158
    public partial class oobjectSomethingThat : oobject
    {
        public override string yyname_endl { get { return "oobjectSomethingThat"; } }
        public override int yynum_endl { get { return 158; } }
    }
    //%+oobjectOnlySomethingThat+159
    public partial class oobjectOnlySomethingThat : oobjectRelated
    {
        public override string yyname_endl { get { return "oobjectOnlySomethingThat"; } }
        public override int yynum_endl { get { return 159; } }
    }
    //%+role+160
    public partial class role : PartialSymbol
    {
        public override string yyname_endl { get { return "role"; } }
        public override int yynum_endl { get { return 160; } }
    }
    //%+roleWithXY+161
    public partial class roleWithXY : PartialSymbol
    {
        public override string yyname_endl { get { return "roleWithXY"; } }
        public override int yynum_endl { get { return 161; } }
    }
    //%+notRoleWithXY+162
    public partial class notRoleWithXY : PartialSymbol
    {
        public override string yyname_endl { get { return "notRoleWithXY"; } }
        public override int yynum_endl { get { return 162; } }
    }
    //%+single+163
    public partial class single : PartialSymbol
    {
        public override string yyname_endl { get { return "single"; } }
        public override int yynum_endl { get { return 163; } }
    }
    //%+singleName+164
    public partial class singleName : single
    {
        public override string yyname_endl { get { return "singleName"; } }
        public override int yynum_endl { get { return 164; } }
    }
    //%+singleThing+165
    public partial class singleThing : single
    {
        public override string yyname_endl { get { return "singleThing"; } }
        public override int yynum_endl { get { return 165; } }
    }
    //%+singleNameThat+166
    public partial class singleNameThat : single
    {
        public override string yyname_endl { get { return "singleNameThat"; } }
        public override int yynum_endl { get { return 166; } }
    }
    //%+singleThingThat+167
    public partial class singleThingThat : single
    {
        public override string yyname_endl { get { return "singleThingThat"; } }
        public override int yynum_endl { get { return 167; } }
    }
    //%+singleOneOf+168
    public partial class singleOneOf : single
    {
        public override string yyname_endl { get { return "singleOneOf"; } }
        public override int yynum_endl { get { return 168; } }
    }
    //%+that+169
    public partial class that : PartialSymbol
    {
        public override string yyname_endl { get { return "that"; } }
        public override int yynum_endl { get { return 169; } }
    }
    //%+thatOrLoop+170
    public partial class thatOrLoop : that
    {
        public override string yyname_endl { get { return "thatOrLoop"; } }
        public override int yynum_endl { get { return 170; } }
    }
    //%+andloop+171
    public partial class andloop : PartialSymbol
    {
        public override string yyname_endl { get { return "andloop"; } }
        public override int yynum_endl { get { return 171; } }
    }
    //%+orloop+172
    public partial class orloop : PartialSymbol
    {
        public override string yyname_endl { get { return "orloop"; } }
        public override int yynum_endl { get { return 172; } }
    }
    //%+comparer+173
    public partial class comparer : PartialSymbol
    {
        public override string yyname_endl { get { return "comparer"; } }
        public override int yynum_endl { get { return 173; } }
    }
    //%+word_number+174
    public partial class word_number : PartialSymbol
    {
        public override string yyname_endl { get { return "word_number"; } }
        public override int yynum_endl { get { return 174; } }
    }
    //%+dataval+175
    public partial class dataval : PartialSymbol
    {
        public override string yyname_endl { get { return "dataval"; } }
        public override int yynum_endl { get { return 175; } }
    }
    //%+Number+176
    public partial class Number : dataval
    {
        public override string yyname_endl { get { return "Number"; } }
        public override int yynum_endl { get { return 176; } }
    }
    //%+StrData+177
    public partial class StrData : dataval
    {
        public override string yyname_endl { get { return "StrData"; } }
        public override int yynum_endl { get { return 177; } }
    }
    //%+Float+178
    public partial class Float : dataval
    {
        public override string yyname_endl { get { return "Float"; } }
        public override int yynum_endl { get { return 178; } }
    }
    //%+Bool+179
    public partial class Bool : dataval
    {
        public override string yyname_endl { get { return "Bool"; } }
        public override int yynum_endl { get { return 179; } }
    }
    //%+DateTimeData+180
    public partial class DateTimeData : dataval
    {
        public override string yyname_endl { get { return "DateTimeData"; } }
        public override int yynum_endl { get { return 180; } }
    }
    //%+Duration+181
    public partial class Duration : dataval
    {
        public override string yyname_endl { get { return "Duration"; } }
        public override int yynum_endl { get { return 181; } }
    }
    //%+facet+182
    public partial class facet : PartialSymbol
    {
        public override string yyname_endl { get { return "facet"; } }
        public override int yynum_endl { get { return 182; } }
    }
    //%+facetList+183
    public partial class facetList : PartialSymbol
    {
        public override string yyname_endl { get { return "facetList"; } }
        public override int yynum_endl { get { return 183; } }
    }
    //%+abstractbound+184
    public partial class abstractbound : PartialSymbol
    {
        public override string yyname_endl { get { return "abstractbound"; } }
        public override int yynum_endl { get { return 184; } }
    }
    //%+boundFacets+185
    public partial class boundFacets : abstractbound
    {
        public override string yyname_endl { get { return "boundFacets"; } }
        public override int yynum_endl { get { return 185; } }
    }
    //%+boundVal+186
    public partial class boundVal : abstractbound
    {
        public override string yyname_endl { get { return "boundVal"; } }
        public override int yynum_endl { get { return 186; } }
    }
    //%+datavalList+187
    public partial class datavalList : PartialSymbol
    {
        public override string yyname_endl { get { return "datavalList"; } }
        public override int yynum_endl { get { return 187; } }
    }
    //%+boundOneOf+188
    public partial class boundOneOf : abstractbound
    {
        public override string yyname_endl { get { return "boundOneOf"; } }
        public override int yynum_endl { get { return 188; } }
    }
    //%+boundTop+189
    public partial class boundTop : abstractbound
    {
        public override string yyname_endl { get { return "boundTop"; } }
        public override int yynum_endl { get { return 189; } }
    }
    //%+boundTotal+190
    public partial class boundTotal : abstractbound
    {
        public override string yyname_endl { get { return "boundTotal"; } }
        public override int yynum_endl { get { return 190; } }
    }
    //%+boundDataType+191
    public partial class boundDataType : abstractbound
    {
        public override string yyname_endl { get { return "boundDataType"; } }
        public override int yynum_endl { get { return 191; } }
    }
    //%+boundIdent+192
    public partial class boundIdent : abstractbound
    {
        public override string yyname_endl { get { return "boundIdent"; } }
        public override int yynum_endl { get { return 192; } }
    }
    //%+boundAnd+193
    public partial class boundAnd : abstractbound
    {
        public override string yyname_endl { get { return "boundAnd"; } }
        public override int yynum_endl { get { return 193; } }
    }
    //%+boundOr+194
    public partial class boundOr : abstractbound
    {
        public override string yyname_endl { get { return "boundOr"; } }
        public override int yynum_endl { get { return 194; } }
    }
    //%+boundNot+195
    public partial class boundNot : abstractbound
    {
        public override string yyname_endl { get { return "boundNot"; } }
        public override int yynum_endl { get { return 195; } }
    }
    //%+andComma+196
    public partial class andComma : PartialSymbol
    {
        public override string yyname_endl { get { return "andComma"; } }
        public override int yynum_endl { get { return 196; } }
    }
    //%+orComma+197
    public partial class orComma : PartialSymbol
    {
        public override string yyname_endl { get { return "orComma"; } }
        public override int yynum_endl { get { return 197; } }
    }
    //%+beAre+198
    public partial class beAre : PartialSymbol
    {
        public override string yyname_endl { get { return "beAre"; } }
        public override int yynum_endl { get { return 198; } }
    }
    //%+doesNot+199
    public partial class doesNot : PartialSymbol
    {
        public override string yyname_endl { get { return "doesNot"; } }
        public override int yynum_endl { get { return 199; } }
    }
    //%+doesNotBy+200
    public partial class doesNotBy : PartialSymbol
    {
        public override string yyname_endl { get { return "doesNotBy"; } }
        public override int yynum_endl { get { return 200; } }
    }
    //%+swrlrule+201
    public partial class swrlrule : sentence
    {
        public override string yyname_endl { get { return "swrlrule"; } }
        public override int yynum_endl { get { return 201; } }
    }
    //%+clause+202
    public partial class clause : PartialSymbol
    {
        public override string yyname_endl { get { return "clause"; } }
        public override int yynum_endl { get { return 202; } }
    }
    //%+condition+203
    public partial class condition : PartialSymbol
    {
        public override string yyname_endl { get { return "condition"; } }
        public override int yynum_endl { get { return 203; } }
    }
    //%+condition_is+204
    public partial class condition_is : condition
    {
        public override string yyname_endl { get { return "condition_is"; } }
        public override int yynum_endl { get { return 204; } }
    }
    //%+condition_exists+205
    public partial class condition_exists : condition
    {
        public override string yyname_endl { get { return "condition_exists"; } }
        public override int yynum_endl { get { return 205; } }
    }
    //%+condition_definition+206
    public partial class condition_definition : condition
    {
        public override string yyname_endl { get { return "condition_definition"; } }
        public override int yynum_endl { get { return 206; } }
    }
    //%+condition_role+207
    public partial class condition_role : condition
    {
        public override string yyname_endl { get { return "condition_role"; } }
        public override int yynum_endl { get { return 207; } }
    }
    //%+condition_data_property+208
    public partial class condition_data_property : condition
    {
        public override string yyname_endl { get { return "condition_data_property"; } }
        public override int yynum_endl { get { return 208; } }
    }
    //%+condition_data_property_bound+209
    public partial class condition_data_property_bound : condition
    {
        public override string yyname_endl { get { return "condition_data_property_bound"; } }
        public override int yynum_endl { get { return 209; } }
    }
    //%+condition_data_bound+210
    public partial class condition_data_bound : condition
    {
        public override string yyname_endl { get { return "condition_data_bound"; } }
        public override int yynum_endl { get { return 210; } }
    }
    //%+condition_builtin+211
    public partial class condition_builtin : condition
    {
        public override string yyname_endl { get { return "condition_builtin"; } }
        public override int yynum_endl { get { return 211; } }
    }
    //%+clause_result+212
    public partial class clause_result : PartialSymbol
    {
        public override string yyname_endl { get { return "clause_result"; } }
        public override int yynum_endl { get { return 212; } }
    }
    //%+condition_result+213
    public partial class condition_result : PartialSymbol
    {
        public override string yyname_endl { get { return "condition_result"; } }
        public override int yynum_endl { get { return 213; } }
    }
    //%+condition_result_is+214
    public partial class condition_result_is : condition_result
    {
        public override string yyname_endl { get { return "condition_result_is"; } }
        public override int yynum_endl { get { return 214; } }
    }
    //%+condition_result_definition+215
    public partial class condition_result_definition : condition_result
    {
        public override string yyname_endl { get { return "condition_result_definition"; } }
        public override int yynum_endl { get { return 215; } }
    }
    //%+condition_result_role+216
    public partial class condition_result_role : condition_result
    {
        public override string yyname_endl { get { return "condition_result_role"; } }
        public override int yynum_endl { get { return 216; } }
    }
    //%+condition_result_data_property+217
    public partial class condition_result_data_property : condition_result
    {
        public override string yyname_endl { get { return "condition_result_data_property"; } }
        public override int yynum_endl { get { return 217; } }
    }
    //%+condition_result_builtin+218
    public partial class condition_result_builtin : condition_result
    {
        public override string yyname_endl { get { return "condition_result_builtin"; } }
        public override int yynum_endl { get { return 218; } }
    }
    //%+objectr+219
    public partial class objectr : PartialSymbol
    {
        public override string yyname_endl { get { return "objectr"; } }
        public override int yynum_endl { get { return 219; } }
    }
    //%+objectr_nio+220
    public partial class objectr_nio : objectr
    {
        public override string yyname_endl { get { return "objectr_nio"; } }
        public override int yynum_endl { get { return 220; } }
    }
    //%+objectr_io+221
    public partial class objectr_io : objectr
    {
        public override string yyname_endl { get { return "objectr_io"; } }
        public override int yynum_endl { get { return 221; } }
    }
    //%+notidentobject+222
    public partial class notidentobject : PartialSymbol
    {
        public override string yyname_endl { get { return "notidentobject"; } }
        public override int yynum_endl { get { return 222; } }
    }
    //%+identobject+223
    public partial class identobject : PartialSymbol
    {
        public override string yyname_endl { get { return "identobject"; } }
        public override int yynum_endl { get { return 223; } }
    }
    //%+identobject_name+224
    public partial class identobject_name : identobject
    {
        public override string yyname_endl { get { return "identobject_name"; } }
        public override int yynum_endl { get { return 224; } }
    }
    //%+identobject_inst+225
    public partial class identobject_inst : identobject
    {
        public override string yyname_endl { get { return "identobject_inst"; } }
        public override int yynum_endl { get { return 225; } }
    }
    //%+instancer+226
    public partial class instancer : PartialSymbol
    {
        public override string yyname_endl { get { return "instancer"; } }
        public override int yynum_endl { get { return 226; } }
    }
    //%+datavaler+227
    public partial class datavaler : PartialSymbol
    {
        public override string yyname_endl { get { return "datavaler"; } }
        public override int yynum_endl { get { return 227; } }
    }
    //%+datavalvar+228
    public partial class datavalvar : datavaler
    {
        public override string yyname_endl { get { return "datavalvar"; } }
        public override int yynum_endl { get { return 228; } }
    }
    //%+datavalval+229
    public partial class datavalval : datavaler
    {
        public override string yyname_endl { get { return "datavalval"; } }
        public override int yynum_endl { get { return 229; } }
    }
    //%+exerule+230
    public partial class exerule : sentence
    {
        public override string yyname_endl { get { return "exerule"; } }
        public override int yynum_endl { get { return 230; } }
    }
    //%+code+231
    public partial class code : sentence
    {
        public override string yyname_endl { get { return "code"; } }
        public override int yynum_endl { get { return 231; } }
    }
    //%+exeargs+232
    public partial class exeargs : PartialSymbol
    {
        public override string yyname_endl { get { return "exeargs"; } }
        public override int yynum_endl { get { return 232; } }
    }
    //%+swrlrulefor+233
    public partial class swrlrulefor : sentence
    {
        public override string yyname_endl { get { return "swrlrulefor"; } }
        public override int yynum_endl { get { return 233; } }
    }
    //%+builtin+234
    public partial class builtin : PartialSymbol
    {
        public override string yyname_endl { get { return "builtin"; } }
        public override int yynum_endl { get { return 234; } }
    }
    //%+builtin_cmp+235
    public partial class builtin_cmp : builtin
    {
        public override string yyname_endl { get { return "builtin_cmp"; } }
        public override int yynum_endl { get { return 235; } }
    }
    //%+builtin_list+236
    public partial class builtin_list : builtin
    {
        public override string yyname_endl { get { return "builtin_list"; } }
        public override int yynum_endl { get { return 236; } }
    }
    //%+builtin_bin+237
    public partial class builtin_bin : builtin
    {
        public override string yyname_endl { get { return "builtin_bin"; } }
        public override int yynum_endl { get { return 237; } }
    }
    //%+builtin_unary_cmp+238
    public partial class builtin_unary_cmp : builtin
    {
        public override string yyname_endl { get { return "builtin_unary_cmp"; } }
        public override int yynum_endl { get { return 238; } }
    }
    //%+builtin_unary_free+239
    public partial class builtin_unary_free : builtin
    {
        public override string yyname_endl { get { return "builtin_unary_free"; } }
        public override int yynum_endl { get { return 239; } }
    }
    //%+builtin_substr+240
    public partial class builtin_substr : builtin
    {
        public override string yyname_endl { get { return "builtin_substr"; } }
        public override int yynum_endl { get { return 240; } }
    }
    //%+builtin_trans+241
    public partial class builtin_trans : builtin
    {
        public override string yyname_endl { get { return "builtin_trans"; } }
        public override int yynum_endl { get { return 241; } }
    }
    //%+builtin_duration+242
    public partial class builtin_duration : builtin
    {
        public override string yyname_endl { get { return "builtin_duration"; } }
        public override int yynum_endl { get { return 242; } }
    }
    //%+builtin_datetime+243
    public partial class builtin_datetime : builtin
    {
        public override string yyname_endl { get { return "builtin_datetime"; } }
        public override int yynum_endl { get { return 243; } }
    }
    //%+builtin_alpha+244
    public partial class builtin_alpha : builtin
    {
        public override string yyname_endl { get { return "builtin_alpha"; } }
        public override int yynum_endl { get { return 244; } }
    }
    //%+builtin_annot+245
    public partial class builtin_annot : builtin
    {
        public override string yyname_endl { get { return "builtin_annot"; } }
        public override int yynum_endl { get { return 245; } }
    }
    //%+builtin_exe+246
    public partial class builtin_exe : builtin
    {
        public override string yyname_endl { get { return "builtin_exe"; } }
        public override int yynum_endl { get { return 246; } }
    }
    //%+datavalerPlusList+247
    public partial class datavalerPlusList : PartialSymbol
    {
        public override string yyname_endl { get { return "datavalerPlusList"; } }
        public override int yynum_endl { get { return 247; } }
    }
    //%+datavalerTimesList+248
    public partial class datavalerTimesList : PartialSymbol
    {
        public override string yyname_endl { get { return "datavalerTimesList"; } }
        public override int yynum_endl { get { return 248; } }
    }
    //%+datavalerFollowedByList+249
    public partial class datavalerFollowedByList : PartialSymbol
    {
        public override string yyname_endl { get { return "datavalerFollowedByList"; } }
        public override int yynum_endl { get { return 249; } }
    }
    //%+duration+250
    public partial class duration : PartialSymbol
    {
        public override string yyname_endl { get { return "duration"; } }
        public override int yynum_endl { get { return 250; } }
    }
    //%+duration_m+251
    public partial class duration_m : duration
    {
        public override string yyname_endl { get { return "duration_m"; } }
        public override int yynum_endl { get { return 251; } }
    }
    //%+duration_w+252
    public partial class duration_w : duration
    {
        public override string yyname_endl { get { return "duration_w"; } }
        public override int yynum_endl { get { return 252; } }
    }

    public class paragraph_566245c87df54ee3bb78d5606c0fc1e8 : paragraph
    {
        public paragraph_566245c87df54ee3bb78d5606c0fc1e8(Parser yyq) : base(yyq,
          ((sentence)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class paragraph_c73a4bfe7c064b4c84855e3199998995 : paragraph
    {
        public paragraph_c73a4bfe7c064b4c84855e3199998995(Parser yyq) : base(yyq,
          ((paragraph)(yyq.StackAt(1).m_value))
          ,
          ((sentence)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class annotation_44947d7626e243a382eb0069325b2d2c : annotation
    {
        public annotation_44947d7626e243a382eb0069325b2d2c(Parser yyq) : base(yyq,
          ((COMMENT)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class subsumption_e11b8feca52a432982c43c7eef4e9fff : subsumption
    {
        public subsumption_e11b8feca52a432982c43c7eef4e9fff(Parser yyq) : base(yyq,
          ((subject)(yyq.StackAt(3).m_value))
          ,
          ((modality)(yyq.StackAt(2).m_value))
          .yytext,
          ((orloop)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class nosubsumption_241070898bd34b07be44ae8b03b9fa25 : nosubsumption
    {
        public nosubsumption_241070898bd34b07be44ae8b03b9fa25(Parser yyq) : base(yyq,
          ((nosubject)(yyq.StackAt(3).m_value))
          ,
          ((modality)(yyq.StackAt(2).m_value))
          .yytext,
          ((orloop)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class datatypedef_ede858d8e5dc4afdaaf6f887b2464fad : datatypedef
    {
        public datatypedef_ede858d8e5dc4afdaaf6f887b2464fad(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(4).m_value))
          .yytext,
          ((abstractbound)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class rolesubsumption_7af6523e728b450da936b5061ba53008 : rolesubsumption
    {
        public rolesubsumption_7af6523e728b450da936b5061ba53008(Parser yyq) : base(yyq,
          ((role)(yyq.StackAt(4).m_value))
          ,
          ((roleWithXY)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class rolesubsumption_7b44428ea8344fcebe9eb5d6b1c5c84f : rolesubsumption
    {
        public rolesubsumption_7b44428ea8344fcebe9eb5d6b1c5c84f(Parser yyq) : base(yyq,
          ((chain)(yyq.StackAt(4).m_value))
          ,
          ((roleWithXY)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class datarolesubsumption_53b8fa47c596440a848c3686d84ff9fa : datarolesubsumption
    {
        public datarolesubsumption_53b8fa47c596440a848c3686d84ff9fa(Parser yyq) : base(yyq,
          ((role)(yyq.StackAt(8).m_value))
          ,
          ((role)(yyq.StackAt(3).m_value))
          )
        { }
    }

    public class roledisjoint2_0e157aedc4c4420286bc66850f27b4a2 : roledisjoint2
    {
        public roledisjoint2_0e157aedc4c4420286bc66850f27b4a2(Parser yyq) : base(yyq,
          ((role)(yyq.StackAt(4).m_value))
          ,
          ((notRoleWithXY)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class dataroledisjoint2_443ae1c9dfc34907879db58e54a43552 : dataroledisjoint2
    {
        public dataroledisjoint2_443ae1c9dfc34907879db58e54a43552(Parser yyq) : base(yyq,
          ((role)(yyq.StackAt(9).m_value))
          ,
          ((role)(yyq.StackAt(3).m_value))
          )
        { }
    }

    public class equivalence2_2ece582c05814d189b07e26b3fc415f0 : equivalence2
    {
        public equivalence2_2ece582c05814d189b07e26b3fc415f0(Parser yyq) : base(yyq,
          ((orloop)(yyq.StackAt(3).m_value))
          ,
          ((modality)(yyq.StackAt(4).m_value))
          .yytext,
          ((orloop)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class roleequivalence2_7329660247a3423dbbe6d751ea254a7f : roleequivalence2
    {
        public roleequivalence2_7329660247a3423dbbe6d751ea254a7f(Parser yyq) : base(yyq,
          ((role)(yyq.StackAt(4).m_value))
          ,
          ((roleWithXY)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class dataroleequivalence2_79e8e3c6387c49ab995139ad18214122 : dataroleequivalence2
    {
        public dataroleequivalence2_79e8e3c6387c49ab995139ad18214122(Parser yyq) : base(yyq,
          ((role)(yyq.StackAt(8).m_value))
          ,
          ((role)(yyq.StackAt(3).m_value))
          )
        { }
    }

    public class exclusiveunion_9d3feb24afc04ba0a619553526a44646 : exclusiveunion
    {
        public exclusiveunion_9d3feb24afc04ba0a619553526a44646(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(3).m_value))
          .yytext,
          ((orObjectRoleExprChain)(yyq.StackAt(1).m_value))
          ,
          ((modality)(yyq.StackAt(6).m_value))
          .yytext)
        { }
    }

    public class exclusives_91ffa52d905549b0aaea515988ac0301 : exclusives
    {
        public exclusives_91ffa52d905549b0aaea515988ac0301(Parser yyq) : base(yyq,
          ((orObjectRoleExprChain)(yyq.StackAt(2).m_value))
          ,
          ((modality)(yyq.StackAt(4).m_value))
          .yytext)
        { }
    }

    public class haskey_42d75fdf80ab4593b47edf7159d47307 : haskey
    {
        public haskey_42d75fdf80ab4593b47edf7159d47307(Parser yyq) : base(yyq,
          ((objectRoleExpr)(yyq.StackAt(3).m_value))
          ,
          ((andanyrolechain)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class swrlrule_943c8bac97c94c82a87e57602514c1d5 : swrlrule
    {
        public swrlrule_943c8bac97c94c82a87e57602514c1d5(Parser yyq) : base(yyq,
          ((clause)(yyq.StackAt(4).m_value))
          ,
          ((clause_result)(yyq.StackAt(1).m_value))
          ,
          ((modality2)(yyq.StackAt(2).m_value))
          .yytext)
        { }
    }

    public class swrlrulefor_132bd0b2a4b14ab5959beb871c7597d2 : swrlrulefor
    {
        public swrlrulefor_132bd0b2a4b14ab5959beb871c7597d2(Parser yyq) : base(yyq,
          ((clause)(yyq.StackAt(11).m_value))
          ,
          ((valueOrThing)(yyq.StackAt(7).m_value))
          .yytext,
          ((NAT)(yyq.StackAt(5).m_value))
          .yytext,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((clause_result)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class exerule_0b3d9235c9f049308eaa150fa7fe6dc5 : exerule
    {
        public exerule_0b3d9235c9f049308eaa150fa7fe6dc5(Parser yyq) : base(yyq,
          ((clause)(yyq.StackAt(6).m_value))
          ,
          ((exeargs)(yyq.StackAt(3).m_value))
          ,
          ((STR)(yyq.StackAt(1).m_value))
          .yytext)
        { }
    }

    public class code_cbe070844a604bcd8667f1542c831241 : code
    {
        public code_cbe070844a604bcd8667f1542c831241(Parser yyq) : base(yyq,
          ((CODE)(yyq.StackAt(1).m_value))
          .yytext)
        { }
    }

    public class valueOrThing_11693110f638425bb998c8487484accb : valueOrThing
    {
        public valueOrThing_11693110f638425bb998c8487484accb(Parser yyq) : base(yyq) { }
    }

    public class valueOrThing_b292e5effebc4cf08f68227d444765da : valueOrThing
    {
        public valueOrThing_b292e5effebc4cf08f68227d444765da(Parser yyq) : base(yyq) { }
    }

    public class valueOrThing_b292e5effebc4cf08f68227d444765da_e394101d548f4b1790b3a7fb2cffaaec : valueOrThing_b292e5effebc4cf08f68227d444765da
    {
        public valueOrThing_b292e5effebc4cf08f68227d444765da_e394101d548f4b1790b3a7fb2cffaaec(Parser yyq) : base(yyq) { yytext = "value"; }
    }

    public class valueOrThing_992d64a96a1d4f6cb4906f802c44e3ce : valueOrThing
    {
        public valueOrThing_992d64a96a1d4f6cb4906f802c44e3ce(Parser yyq) : base(yyq) { }
    }

    public class valueOrThing_606f91515c9a4f178ebde2e9e15da180 : valueOrThing
    {
        public valueOrThing_606f91515c9a4f178ebde2e9e15da180(Parser yyq) : base(yyq) { }
    }

    public class valueOrThing_606f91515c9a4f178ebde2e9e15da180_a0194531c9a046758b0864b1beb8f1b0 : valueOrThing_606f91515c9a4f178ebde2e9e15da180
    {
        public valueOrThing_606f91515c9a4f178ebde2e9e15da180_a0194531c9a046758b0864b1beb8f1b0(Parser yyq) : base(yyq) { yytext = "thing"; }
    }

    public class clause_4afb50346dbc4e0ab977917496ae7465 : clause
    {
        public clause_4afb50346dbc4e0ab977917496ae7465(Parser yyq) : base(yyq,
          ((condition)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class clause_896721228f0749b1835787e438800b80 : clause
    {
        public clause_896721228f0749b1835787e438800b80(Parser yyq) : base(yyq,
          ((clause)(yyq.StackAt(2).m_value))
          ,
          ((condition)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class clause_result_e4966a20715f4ad6a9f4eaeb33a5ea99 : clause_result
    {
        public clause_result_e4966a20715f4ad6a9f4eaeb33a5ea99(Parser yyq) : base(yyq,
          ((condition_result)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class clause_result_34e19e77573e4cee91a7ff6f0b710780 : clause_result
    {
        public clause_result_34e19e77573e4cee91a7ff6f0b710780(Parser yyq) : base(yyq,
          ((clause_result)(yyq.StackAt(2).m_value))
          ,
          ((condition_result)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class condition_role_450ed8e2227a42cfb94f34d571c49138 : condition_role
    {
        public condition_role_450ed8e2227a42cfb94f34d571c49138(Parser yyq) : base(yyq,
          ((objectr)(yyq.StackAt(2).m_value))
          ,
          ((NAME)(yyq.StackAt(1).m_value))
          .yytext,
          ((objectr)(yyq.StackAt(0).m_value))
          , condition_kind.None)
        { }
    }

    public class condition_role_a276b189029044c990d6e87acfb16909 : condition_role
    {
        public condition_role_a276b189029044c990d6e87acfb16909(Parser yyq) : base(yyq,
          ((objectr)(yyq.StackAt(4).m_value))
          ,
          ((NAME)(yyq.StackAt(2).m_value))
          .yytext,
          ((objectr)(yyq.StackAt(0).m_value))
          , condition_kind.Inv)
        { }
    }

    public class condition_exists_3b7fabca36e94c648fb58c8d856e7ff8 : condition_exists
    {
        public condition_exists_3b7fabca36e94c648fb58c8d856e7ff8(Parser yyq) : base(yyq,
          ((objectr)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class condition_definition_835c47f908394e68b1462e376f670837 : condition_definition
    {
        public condition_definition_835c47f908394e68b1462e376f670837(Parser yyq) : base(yyq,
          ((objectr)(yyq.StackAt(2).m_value))
          ,
          ((oobject)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class condition_is_9851cdc5ee4547de8f6f21edbb5ef45e : condition_is
    {
        public condition_is_9851cdc5ee4547de8f6f21edbb5ef45e(Parser yyq) : base(yyq,
          ((objectr)(yyq.StackAt(2).m_value))
          ,
          ((objectr)(yyq.StackAt(0).m_value))
          , condition_kind.None)
        { }
    }

    public class condition_is_2c5c8b2d68c842e797705cfc4be4ccfc : condition_is
    {
        public condition_is_2c5c8b2d68c842e797705cfc4be4ccfc(Parser yyq) : base(yyq,
          ((objectr)(yyq.StackAt(2).m_value))
          ,
          ((objectr)(yyq.StackAt(0).m_value))
          , condition_kind.Not)
        { }
    }

    public class condition_data_property_4a412d9875d24be4b511f3ce4fe6af7f : condition_data_property
    {
        public condition_data_property_4a412d9875d24be4b511f3ce4fe6af7f(Parser yyq) : base(yyq,
          ((objectr)(yyq.StackAt(7).m_value))
          ,
          ((NAME)(yyq.StackAt(6).m_value))
          .yytext,
          ((NAT)(yyq.StackAt(1).m_value))
          .yytext)
        { }
    }

    public class condition_data_property_bound_199281df83cd4401ae5f574544961b1e : condition_data_property_bound
    {
        public condition_data_property_bound_199281df83cd4401ae5f574544961b1e(Parser yyq) : base(yyq,
          ((objectr)(yyq.StackAt(2).m_value))
          ,
          ((NAME)(yyq.StackAt(1).m_value))
          .yytext,
          ((abstractbound)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class condition_data_bound_81d74be785d9496f86106ac984df9d6e : condition_data_bound
    {
        public condition_data_bound_81d74be785d9496f86106ac984df9d6e(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((abstractbound)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class condition_builtin_404e871395204a49aad4da7fe66997d1 : condition_builtin
    {
        public condition_builtin_404e871395204a49aad4da7fe66997d1(Parser yyq) : base(yyq,
          ((builtin)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class condition_result_role_3118228cc5a84fa1ac3397d77a6a5a83 : condition_result_role
    {
        public condition_result_role_3118228cc5a84fa1ac3397d77a6a5a83(Parser yyq) : base(yyq,
          ((identobject)(yyq.StackAt(2).m_value))
          ,
          ((NAME)(yyq.StackAt(1).m_value))
          .yytext,
          ((identobject)(yyq.StackAt(0).m_value))
          , condition_kind.None)
        { }
    }

    public class condition_result_role_08f60b79e87347629c40e05c00ba7320 : condition_result_role
    {
        public condition_result_role_08f60b79e87347629c40e05c00ba7320(Parser yyq) : base(yyq,
          ((identobject)(yyq.StackAt(4).m_value))
          ,
          ((NAME)(yyq.StackAt(2).m_value))
          .yytext,
          ((identobject)(yyq.StackAt(0).m_value))
          , condition_kind.Inv)
        { }
    }

    public class condition_result_is_92cac4ab014b429fbecd05c009e4f3d3 : condition_result_is
    {
        public condition_result_is_92cac4ab014b429fbecd05c009e4f3d3(Parser yyq) : base(yyq,
          ((identobject)(yyq.StackAt(2).m_value))
          ,
          ((identobject)(yyq.StackAt(0).m_value))
          , condition_kind.None)
        { }
    }

    public class condition_result_is_a76c128b6c4a4fd080e8207bb5686aaf : condition_result_is
    {
        public condition_result_is_a76c128b6c4a4fd080e8207bb5686aaf(Parser yyq) : base(yyq,
          ((identobject)(yyq.StackAt(2).m_value))
          ,
          ((identobject)(yyq.StackAt(0).m_value))
          , condition_kind.Not)
        { }
    }

    public class condition_result_definition_bfa38c97338d412b851ae3a69b9cfb92 : condition_result_definition
    {
        public condition_result_definition_bfa38c97338d412b851ae3a69b9cfb92(Parser yyq) : base(yyq,
          ((identobject)(yyq.StackAt(2).m_value))
          ,
          ((oobject)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class condition_result_data_property_cd2208eb47554d05a88bc19b0e0f3557 : condition_result_data_property
    {
        public condition_result_data_property_cd2208eb47554d05a88bc19b0e0f3557(Parser yyq) : base(yyq,
          ((identobject)(yyq.StackAt(3).m_value))
          ,
          ((NAME)(yyq.StackAt(2).m_value))
          .yytext,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class exeargs_26c6dfa4d57a4228aafb1dd705608024 : exeargs
    {
        public exeargs_26c6dfa4d57a4228aafb1dd705608024(Parser yyq) : base(yyq,
          ((identobject)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class exeargs_56a109c849ca4fffb7c041d5d1b34493 : exeargs
    {
        public exeargs_56a109c849ca4fffb7c041d5d1b34493(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class exeargs_dedb7be397514b3b8032978e42985b45 : exeargs
    {
        public exeargs_dedb7be397514b3b8032978e42985b45(Parser yyq) : base(yyq,
          ((exeargs)(yyq.StackAt(2).m_value))
          ,
          ((identobject)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class exeargs_09198c24a4c54171b54a3ac103990da0 : exeargs
    {
        public exeargs_09198c24a4c54171b54a3ac103990da0(Parser yyq) : base(yyq,
          ((exeargs)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class notidentobject_29d7f93464bb49ee924c71f88475ad54 : notidentobject
    {
        public notidentobject_29d7f93464bb49ee924c71f88475ad54(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class notidentobject_21178b2016ee43dd9b7828f754df3ee4 : notidentobject
    {
        public notidentobject_21178b2016ee43dd9b7828f754df3ee4(Parser yyq) : base(yyq, null) { }
    }

    public class notidentobject_b94aa5042b0b4cd0b7fb47c31cd21884 : notidentobject
    {
        public notidentobject_b94aa5042b0b4cd0b7fb47c31cd21884(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(3).m_value))
          .yytext,
          ((NAT)(yyq.StackAt(1).m_value))
          .yytext)
        { }
    }

    public class notidentobject_a31997c075994d7399c36d4cff248073 : notidentobject
    {
        public notidentobject_a31997c075994d7399c36d4cff248073(Parser yyq) : base(yyq, null,
          ((NAT)(yyq.StackAt(1).m_value))
          .yytext)
        { }
    }

    public class identobject_name_e753f510c632415caecfe92fdfe04132 : identobject_name
    {
        public identobject_name_e753f510c632415caecfe92fdfe04132(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class identobject_name_a74993c3e8ef4b53b4e341ce3a3d454b : identobject_name
    {
        public identobject_name_a74993c3e8ef4b53b4e341ce3a3d454b(Parser yyq) : base(yyq, null) { }
    }

    public class identobject_name_db6df83e230f4c83b0a33be8be59c8ee : identobject_name
    {
        public identobject_name_db6df83e230f4c83b0a33be8be59c8ee(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(3).m_value))
          .yytext,
          ((NAT)(yyq.StackAt(1).m_value))
          .yytext)
        { }
    }

    public class identobject_name_2f71ecb76d814507b89088016afc756b : identobject_name
    {
        public identobject_name_2f71ecb76d814507b89088016afc756b(Parser yyq) : base(yyq, null,
          ((NAT)(yyq.StackAt(1).m_value))
          .yytext)
        { }
    }

    public class identobject_inst_3841f77f0f734bcd853061126e5a07ae : identobject_inst
    {
        public identobject_inst_3841f77f0f734bcd853061126e5a07ae(Parser yyq) : base(yyq,
          ((instancer)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class instancer_67fb63a2276c44c580c90318fac84b88 : instancer
    {
        public instancer_67fb63a2276c44c580c90318fac84b88(Parser yyq) : base(yyq,
          ((BIGNAME)(yyq.StackAt(0).m_value))
          .yytext, false)
        { }
    }

    public class instancer_b276f0b0160f40d786e314b752ebe195 : instancer
    {
        public instancer_b276f0b0160f40d786e314b752ebe195(Parser yyq) : base(yyq,
          ((VERYBIGNAME)(yyq.StackAt(0).m_value))
          .yytext, true)
        { }
    }

    public class objectr_nio_3e0d3830f09c478b96444fef526d4ef2 : objectr_nio
    {
        public objectr_nio_3e0d3830f09c478b96444fef526d4ef2(Parser yyq) : base(yyq,
          ((notidentobject)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class objectr_io_ee9983a723fd4267a9248edc2a281b7b : objectr_io
    {
        public objectr_io_ee9983a723fd4267a9248edc2a281b7b(Parser yyq) : base(yyq,
          ((identobject)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class datavalvar_d0dde5e18b8948c094af05fe960f9d8d : datavalvar
    {
        public datavalvar_d0dde5e18b8948c094af05fe960f9d8d(Parser yyq) : base(yyq,
          ((NAT)(yyq.StackAt(1).m_value))
          .yytext)
        { }
    }

    public class datavalval_bafc195f566548d79632b7bf2b97db37 : datavalval
    {
        public datavalval_bafc195f566548d79632b7bf2b97db37(Parser yyq) : base(yyq,
          ((dataval)(yyq.StackAt(0).m_value))
          )
        { }
    }
    public partial class comparer2 : PartialSymbol
    {
        public override string yyname_endl { get { return "comparer2"; } }
        public override int yynum_endl { get { return 320; } }
    }

    public class comparer2_587ff1bbf2da4e7d8b88417a53cfb5e7 : comparer2
    {
        public comparer2_587ff1bbf2da4e7d8b88417a53cfb5e7(Parser yyq) : base(yyq) { }
    }

    public class comparer2_b0fe676e97734f1ba55ea7231f35b8bc : comparer2
    {
        public comparer2_b0fe676e97734f1ba55ea7231f35b8bc(Parser yyq) : base(yyq) { }
    }

    public class comparer2_b0fe676e97734f1ba55ea7231f35b8bc_48f64b1ce3024ea4a87b7d0a4a07a4f6 : comparer2_b0fe676e97734f1ba55ea7231f35b8bc
    {
        public comparer2_b0fe676e97734f1ba55ea7231f35b8bc_48f64b1ce3024ea4a87b7d0a4a07a4f6(Parser yyq) : base(yyq) { yytext = "="; }
    }

    public class comparer2_42749d2044714b4d8ee198f3be859206 : comparer2
    {
        public comparer2_42749d2044714b4d8ee198f3be859206(Parser yyq) : base(yyq) { }
    }

    public class comparer2_edb3d005808a42149810185952208fc5 : comparer2
    {
        public comparer2_edb3d005808a42149810185952208fc5(Parser yyq) : base(yyq) { }
    }

    public class comparer2_edb3d005808a42149810185952208fc5_8e3c464b3c1d4fd8ba1e6951f15c7a9e : comparer2_edb3d005808a42149810185952208fc5
    {
        public comparer2_edb3d005808a42149810185952208fc5_8e3c464b3c1d4fd8ba1e6951f15c7a9e(Parser yyq) : base(yyq) { yytext = "≠"; }
    }

    public class comparer2_6be5d1975f4a46fd94c2f08da7d7a9cf : comparer2
    {
        public comparer2_6be5d1975f4a46fd94c2f08da7d7a9cf(Parser yyq) : base(yyq) { }
    }

    public class comparer2_214406d730e745df9f734e109290ad77 : comparer2
    {
        public comparer2_214406d730e745df9f734e109290ad77(Parser yyq) : base(yyq) { }
    }

    public class comparer2_214406d730e745df9f734e109290ad77_dc3359640dd04db190bf53abb66fde9a : comparer2_214406d730e745df9f734e109290ad77
    {
        public comparer2_214406d730e745df9f734e109290ad77_dc3359640dd04db190bf53abb66fde9a(Parser yyq) : base(yyq)
        {
            yytext = (
((COMPARER2)(yyq.StackAt(0).m_value))
.yytext == "lower-or-equal-to" ? "≤" : (
((COMPARER2)(yyq.StackAt(0).m_value))
.yytext == "greater-or-equal-to" ? "≥" : (
((COMPARER2)(yyq.StackAt(0).m_value))
.yytext == "lower-than" ? "<" : ">")));
        }
    }

    public class comparer2_ae23ce61f8ed473db910fce732481f63 : comparer2
    {
        public comparer2_ae23ce61f8ed473db910fce732481f63(Parser yyq) : base(yyq) { }
    }

    public class comparer2_469cb9c5f35a4878b84b753ed5aa6a1a : comparer2
    {
        public comparer2_469cb9c5f35a4878b84b753ed5aa6a1a(Parser yyq) : base(yyq) { }
    }

    public class comparer2_469cb9c5f35a4878b84b753ed5aa6a1a_daf2c9c6e5c8422a9e71782ad63f1af4 : comparer2_469cb9c5f35a4878b84b753ed5aa6a1a
    {
        public comparer2_469cb9c5f35a4878b84b753ed5aa6a1a_daf2c9c6e5c8422a9e71782ad63f1af4(Parser yyq) : base(yyq)
        {
            yytext =
((CMP)(yyq.StackAt(0).m_value))
.yytext;
        }
    }

    public class comparer2_ce1a6ff8e277483c96f9740c7e35cb79 : comparer2
    {
        public comparer2_ce1a6ff8e277483c96f9740c7e35cb79(Parser yyq) : base(yyq) { }
    }

    public class comparer2_11e106ec73574e0d8853ad29dfb3ed8e : comparer2
    {
        public comparer2_11e106ec73574e0d8853ad29dfb3ed8e(Parser yyq) : base(yyq) { }
    }

    public class comparer2_11e106ec73574e0d8853ad29dfb3ed8e_27b290a48ef545c1848fd6f340bf8239 : comparer2_11e106ec73574e0d8853ad29dfb3ed8e
    {
        public comparer2_11e106ec73574e0d8853ad29dfb3ed8e_27b290a48ef545c1848fd6f340bf8239(Parser yyq) : base(yyq) { yytext = "="; }
    }
    public partial class equalTo : PartialSymbol
    {
        public override string yyname_endl { get { return "equalTo"; } }
        public override int yynum_endl { get { return 336; } }
    }

    public class equalTo_bc50a34a422d45dc9f8aaab9e3c89df6 : equalTo
    {
        public equalTo_bc50a34a422d45dc9f8aaab9e3c89df6(Parser yyq) : base(yyq) { }
    }

    public class equalTo_da1a5ce4efaf479e89d992a3133720b7 : equalTo
    {
        public equalTo_da1a5ce4efaf479e89d992a3133720b7(Parser yyq) : base(yyq) { }
    }

    public class equalTo_da1a5ce4efaf479e89d992a3133720b7_c77ccc0f563e4beb95e9c323d6772ad7 : equalTo_da1a5ce4efaf479e89d992a3133720b7
    {
        public equalTo_da1a5ce4efaf479e89d992a3133720b7_c77ccc0f563e4beb95e9c323d6772ad7(Parser yyq) : base(yyq) { yytext = "="; }
    }

    public class equalTo_d7301e3cdc084c2f97a594538d3895f7 : equalTo
    {
        public equalTo_d7301e3cdc084c2f97a594538d3895f7(Parser yyq) : base(yyq) { }
    }

    public class equalTo_02e1029631bf4b709a469df03d37ec01 : equalTo
    {
        public equalTo_02e1029631bf4b709a469df03d37ec01(Parser yyq) : base(yyq) { }
    }

    public class equalTo_02e1029631bf4b709a469df03d37ec01_ab0683c73b1e47619b12824e51bd8938 : equalTo_02e1029631bf4b709a469df03d37ec01
    {
        public equalTo_02e1029631bf4b709a469df03d37ec01_ab0683c73b1e47619b12824e51bd8938(Parser yyq) : base(yyq) { yytext = "="; }
    }

    public class datavalerPlusList_cf96adeabac64a4f9768270e4f7b43a5 : datavalerPlusList
    {
        public datavalerPlusList_cf96adeabac64a4f9768270e4f7b43a5(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class datavalerPlusList_1027d4d7a1d44f248cbb749a7b8379c4 : datavalerPlusList
    {
        public datavalerPlusList_1027d4d7a1d44f248cbb749a7b8379c4(Parser yyq) : base(yyq,
          ((datavalerPlusList)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class datavalerTimesList_f5a5d38302574d3282fede0c80d42c45 : datavalerTimesList
    {
        public datavalerTimesList_f5a5d38302574d3282fede0c80d42c45(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class datavalerTimesList_b27ec15854c24ac89733734cf77072d2 : datavalerTimesList
    {
        public datavalerTimesList_b27ec15854c24ac89733734cf77072d2(Parser yyq) : base(yyq,
          ((datavalerTimesList)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class datavalerFollowedByList_f66a5ef8595548f28eecf225fee146ed : datavalerFollowedByList
    {
        public datavalerFollowedByList_f66a5ef8595548f28eecf225fee146ed(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class datavalerFollowedByList_31358cf7b46841b5b007904f15c8e113 : datavalerFollowedByList
    {
        public datavalerFollowedByList_31358cf7b46841b5b007904f15c8e113(Parser yyq) : base(yyq,
          ((datavalerFollowedByList)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }
    public partial class binOp : PartialSymbol
    {
        public override string yyname_endl { get { return "binOp"; } }
        public override int yynum_endl { get { return 349; } }
    }

    public class binOp_67f4ca57a0b3428d92570e2f1277da2c : binOp
    {
        public binOp_67f4ca57a0b3428d92570e2f1277da2c(Parser yyq) : base(yyq) { }
    }

    public class binOp_d03cb2932c8e4f0ab8095286123f6797 : binOp
    {
        public binOp_d03cb2932c8e4f0ab8095286123f6797(Parser yyq) : base(yyq) { }
    }

    public class binOp_d03cb2932c8e4f0ab8095286123f6797_6d013372786b4e7294e707369b187f39 : binOp_d03cb2932c8e4f0ab8095286123f6797
    {
        public binOp_d03cb2932c8e4f0ab8095286123f6797_6d013372786b4e7294e707369b187f39(Parser yyq) : base(yyq)
        {
            yytext =
((BINOP)(yyq.StackAt(0).m_value))
.yytext;
        }
    }

    public class binOp_a7b23d9bc410429f82a991f2001c95b2 : binOp
    {
        public binOp_a7b23d9bc410429f82a991f2001c95b2(Parser yyq) : base(yyq) { }
    }

    public class binOp_decd62613c0f4f7fafe385767da99fb4 : binOp
    {
        public binOp_decd62613c0f4f7fafe385767da99fb4(Parser yyq) : base(yyq) { }
    }

    public class binOp_decd62613c0f4f7fafe385767da99fb4_7a83a968f8894995b3f2e13a43e8f9f0 : binOp_decd62613c0f4f7fafe385767da99fb4
    {
        public binOp_decd62613c0f4f7fafe385767da99fb4_7a83a968f8894995b3f2e13a43e8f9f0(Parser yyq) : base(yyq) { yytext = "minus"; }
    }

    public class binOp_d4ec7f2581f64fb48b3c50d1edfdbce4 : binOp
    {
        public binOp_d4ec7f2581f64fb48b3c50d1edfdbce4(Parser yyq) : base(yyq) { }
    }

    public class binOp_bb9c172983b748b9857554319e6d40bb : binOp
    {
        public binOp_bb9c172983b748b9857554319e6d40bb(Parser yyq) : base(yyq) { }
    }

    public class binOp_bb9c172983b748b9857554319e6d40bb_72f21f793eb145a7ad1885c54a555683 : binOp_bb9c172983b748b9857554319e6d40bb
    {
        public binOp_bb9c172983b748b9857554319e6d40bb_72f21f793eb145a7ad1885c54a555683(Parser yyq) : base(yyq) { yytext = "minus"; }
    }
    public partial class unOp : PartialSymbol
    {
        public override string yyname_endl { get { return "unOp"; } }
        public override int yynum_endl { get { return 359; } }
    }

    public class unOp_580a60d4d1d54a1c9c8f5c9001e818b1 : unOp
    {
        public unOp_580a60d4d1d54a1c9c8f5c9001e818b1(Parser yyq) : base(yyq) { }
    }

    public class unOp_45c2620dc3744a0798b88be259a3133e : unOp
    {
        public unOp_45c2620dc3744a0798b88be259a3133e(Parser yyq) : base(yyq) { }
    }

    public class unOp_45c2620dc3744a0798b88be259a3133e_4966f022786945619ab8bac5dc1c4da7 : unOp_45c2620dc3744a0798b88be259a3133e
    {
        public unOp_45c2620dc3744a0798b88be259a3133e_4966f022786945619ab8bac5dc1c4da7(Parser yyq) : base(yyq) { yytext = "minus"; }
    }

    public class unOp_c4ccaad173814dd9849b1c02d3e4fce6 : unOp
    {
        public unOp_c4ccaad173814dd9849b1c02d3e4fce6(Parser yyq) : base(yyq) { }
    }

    public class unOp_c74ee41853af4d08897b08b21a8b04bb : unOp
    {
        public unOp_c74ee41853af4d08897b08b21a8b04bb(Parser yyq) : base(yyq) { }
    }

    public class unOp_c74ee41853af4d08897b08b21a8b04bb_f246cea1ed394396824a7e7a2da47609 : unOp_c74ee41853af4d08897b08b21a8b04bb
    {
        public unOp_c74ee41853af4d08897b08b21a8b04bb_f246cea1ed394396824a7e7a2da47609(Parser yyq) : base(yyq) { yytext = "minus"; }
    }

    public class unOp_fbfd003d2c10478f98392c2071fc6b30 : unOp
    {
        public unOp_fbfd003d2c10478f98392c2071fc6b30(Parser yyq) : base(yyq) { }
    }

    public class unOp_b29fb39a8a2c4ad6b274981f8a22136c : unOp
    {
        public unOp_b29fb39a8a2c4ad6b274981f8a22136c(Parser yyq) : base(yyq) { }
    }

    public class unOp_b29fb39a8a2c4ad6b274981f8a22136c_defeec6d3e904923b3dcb7daa4e43ad1 : unOp_b29fb39a8a2c4ad6b274981f8a22136c
    {
        public unOp_b29fb39a8a2c4ad6b274981f8a22136c_defeec6d3e904923b3dcb7daa4e43ad1(Parser yyq) : base(yyq)
        {
            yytext =
((UNOP)(yyq.StackAt(0).m_value))
.yytext;
        }
    }

    public class unOp_a56e6c90a8e24c09a709d29ba96464e4 : unOp
    {
        public unOp_a56e6c90a8e24c09a709d29ba96464e4(Parser yyq) : base(yyq) { }
    }

    public class unOp_7b7d90a7bb91439e9a99a97c9b68aaa3 : unOp
    {
        public unOp_7b7d90a7bb91439e9a99a97c9b68aaa3(Parser yyq) : base(yyq) { }
    }

    public class unOp_7b7d90a7bb91439e9a99a97c9b68aaa3_032a287ddb214419b8fd109c616d4a90 : unOp_7b7d90a7bb91439e9a99a97c9b68aaa3
    {
        public unOp_7b7d90a7bb91439e9a99a97c9b68aaa3_032a287ddb214419b8fd109c616d4a90(Parser yyq) : base(yyq)
        {
            yytext =
((NOT)(yyq.StackAt(0).m_value))
.yytext;
        }
    }
    public partial class unOp2 : PartialSymbol
    {
        public override string yyname_endl { get { return "unOp2"; } }
        public override int yynum_endl { get { return 372; } }
    }

    public class unOp2_5e29de36058a472b8e84736e6631ef1e : unOp2
    {
        public unOp2_5e29de36058a472b8e84736e6631ef1e(Parser yyq) : base(yyq) { }
    }

    public class unOp2_a6f44f374d46487b93ad3733d3c68a6c : unOp2
    {
        public unOp2_a6f44f374d46487b93ad3733d3c68a6c(Parser yyq) : base(yyq) { }
    }

    public class unOp2_a6f44f374d46487b93ad3733d3c68a6c_ba7f49eb4a3b484a9a6d606af1527be9 : unOp2_a6f44f374d46487b93ad3733d3c68a6c
    {
        public unOp2_a6f44f374d46487b93ad3733d3c68a6c_ba7f49eb4a3b484a9a6d606af1527be9(Parser yyq) : base(yyq)
        {
            yytext =
((UNOP2)(yyq.StackAt(0).m_value))
.yytext;
        }
    }

    public class builtin_cmp_946d7d48c4614d5f9794a4058d592831 : builtin_cmp
    {
        public builtin_cmp_946d7d48c4614d5f9794a4058d592831(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((comparer2)(yyq.StackAt(1).m_value))
          .yytext,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_list_1f1f215d473e40fbac3c2ea190bd875f : builtin_list
    {
        public builtin_list_1f1f215d473e40fbac3c2ea190bd875f(Parser yyq) : base(yyq,
          ((datavalerPlusList)(yyq.StackAt(2).m_value))
          .vals, "plus",
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_list_9da4d36c3fa049b3bc22c9f613fd1969 : builtin_list
    {
        public builtin_list_9da4d36c3fa049b3bc22c9f613fd1969(Parser yyq) : base(yyq,
          ((datavalerTimesList)(yyq.StackAt(2).m_value))
          .vals, "times",
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_list_e48ab73f344340b7b7bf105756aaa681 : builtin_list
    {
        public builtin_list_e48ab73f344340b7b7bf105756aaa681(Parser yyq) : base(yyq,
          ((datavalerFollowedByList)(yyq.StackAt(2).m_value))
          .vals, "followed-by",
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_bin_e973596f450e4814ab503802d183a2d2 : builtin_bin
    {
        public builtin_bin_e973596f450e4814ab503802d183a2d2(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(4).m_value))
          ,
          ((binOp)(yyq.StackAt(3).m_value))
          .yytext,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_unary_cmp_f42342a2c7e74153bd6fad912164a09e : builtin_unary_cmp
    {
        public builtin_unary_cmp_f42342a2c7e74153bd6fad912164a09e(Parser yyq) : base(yyq,
          ((unOp)(yyq.StackAt(3).m_value))
          .yytext,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_unary_free_129c9687f63741f982aa3fd65b1d0be0 : builtin_unary_free
    {
        public builtin_unary_free_129c9687f63741f982aa3fd65b1d0be0(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((unOp2)(yyq.StackAt(1).m_value))
          .yytext,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_substr_3c32f071139b4b7e9262c07f5e8d086e : builtin_substr
    {
        public builtin_substr_3c32f071139b4b7e9262c07f5e8d086e(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(4).m_value))
          , "from",
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_substr_a071f16bc3694a5da45731d98723f29c : builtin_substr
    {
        public builtin_substr_a071f16bc3694a5da45731d98723f29c(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(6).m_value))
          , "from",
          ((datavaler)(yyq.StackAt(4).m_value))
          ,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_substr_6b286ee63b70402c803dbfc771a3d878 : builtin_substr
    {
        public builtin_substr_6b286ee63b70402c803dbfc771a3d878(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(4).m_value))
          ,
          ((SUBSTRINGFIX)(yyq.StackAt(3).m_value))
          .yytext,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_trans_e14262332461450a95eba2859a129c66 : builtin_trans
    {
        public builtin_trans_e14262332461450a95eba2859a129c66(Parser yyq) : base(yyq,
          ((TRANSLATEDREPLACED)(yyq.StackAt(7).m_value))
          .yytext,
          ((datavaler)(yyq.StackAt(6).m_value))
          ,
          ((datavaler)(yyq.StackAt(4).m_value))
          ,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_duration_ba10ee6406b74fe6a00ea802f3072516 : builtin_duration
    {
        public builtin_duration_ba10ee6406b74fe6a00ea802f3072516(Parser yyq) : base(yyq,
          ((duration)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_datetime_2f4201d44eba4fd1a0014b982148a99f : builtin_datetime
    {
        public builtin_datetime_2f4201d44eba4fd1a0014b982148a99f(Parser yyq) : base(yyq,
          ((datetime)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_alpha_aef1c6f72a054960bdce448f4a84f3a0 : builtin_alpha
    {
        public builtin_alpha_aef1c6f72a054960bdce448f4a84f3a0(Parser yyq) : base(yyq,
          ((objectr)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_annot_d13e72dd7c9a4459bd0b16e8ce7559e3 : builtin_annot
    {
        public builtin_annot_d13e72dd7c9a4459bd0b16e8ce7559e3(Parser yyq) : base(yyq,
          ((objectr)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(5).m_value))
          ,
          ((datavaler)(yyq.StackAt(4).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class builtin_exe_38dcc13695b745029673f6bf43cce7a6 : builtin_exe
    {
        public builtin_exe_38dcc13695b745029673f6bf43cce7a6(Parser yyq) : base(yyq,
          ((STR)(yyq.StackAt(4).m_value))
          .yytext,
          ((exeargs)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class duration_m_55afbd56816a4d12b9ac108a3f2cc8cf : duration_m
    {
        public duration_m_55afbd56816a4d12b9ac108a3f2cc8cf(Parser yyq) : base(yyq, null, null,
          ((datavaler)(yyq.StackAt(7).m_value))
          ,
          ((datavaler)(yyq.StackAt(5).m_value))
          ,
          ((datavaler)(yyq.StackAt(3).m_value))
          ,
          ((datavaler)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class duration_m_7047a4fd6e37488cb3d6e52991e74677 : duration_m
    {
        public duration_m_7047a4fd6e37488cb3d6e52991e74677(Parser yyq) : base(yyq, null, null,
          ((datavaler)(yyq.StackAt(5).m_value))
          ,
          ((datavaler)(yyq.StackAt(3).m_value))
          ,
          ((datavaler)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class duration_m_6c11941f4548438387454a9601225be3 : duration_m
    {
        public duration_m_6c11941f4548438387454a9601225be3(Parser yyq) : base(yyq, null, null,
          ((datavaler)(yyq.StackAt(3).m_value))
          ,
          ((datavaler)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class duration_m_c42cc94093cd4389ba02e7236c12aca7 : duration_m
    {
        public duration_m_c42cc94093cd4389ba02e7236c12aca7(Parser yyq) : base(yyq, null, null,
          ((datavaler)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class duration_m_954e0a8601524bfcb8dd02dd40da7138 : duration_m
    {
        public duration_m_954e0a8601524bfcb8dd02dd40da7138(Parser yyq) : base(yyq, null, null, null,
          ((datavaler)(yyq.StackAt(5).m_value))
          ,
          ((datavaler)(yyq.StackAt(3).m_value))
          ,
          ((datavaler)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class duration_m_32c6f48867c3460fbf618a076eab8e73 : duration_m
    {
        public duration_m_32c6f48867c3460fbf618a076eab8e73(Parser yyq) : base(yyq, null, null, null,
          ((datavaler)(yyq.StackAt(3).m_value))
          ,
          ((datavaler)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class duration_m_d99f9c87cb8f49678638ec69894cf1ed : duration_m
    {
        public duration_m_d99f9c87cb8f49678638ec69894cf1ed(Parser yyq) : base(yyq, null, null, null,
          ((datavaler)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class duration_m_f51410a0fe5f4f27ba914db7cdb141c7 : duration_m
    {
        public duration_m_f51410a0fe5f4f27ba914db7cdb141c7(Parser yyq) : base(yyq, null, null, null, null,
          ((datavaler)(yyq.StackAt(3).m_value))
          ,
          ((datavaler)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class duration_m_8bc29c23fa0f414d9fa5214fbebd4ada : duration_m
    {
        public duration_m_8bc29c23fa0f414d9fa5214fbebd4ada(Parser yyq) : base(yyq, null, null, null, null,
          ((datavaler)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class duration_m_f0080b26096e4580ad7cf651e734477a : duration_m
    {
        public duration_m_f0080b26096e4580ad7cf651e734477a(Parser yyq) : base(yyq, null, null, null, null, null,
          ((datavaler)(yyq.StackAt(1).m_value))
          )
        { }
    }
    public partial class datetime : PartialSymbol
    {
        public override string yyname_endl { get { return "datetime"; } }
        public override int yynum_endl { get { return 388; } }
    }

    public class datetime_0c55c536432947bc95b1c0540e659c73 : datetime
    {
        public datetime_0c55c536432947bc95b1c0540e659c73(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(10).m_value))
          ,
          ((datavaler)(yyq.StackAt(8).m_value))
          ,
          ((datavaler)(yyq.StackAt(6).m_value))
          ,
          ((datavaler)(yyq.StackAt(4).m_value))
          ,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class datetime_9d175bd7e80948ccb573987c4312e831 : datetime
    {
        public datetime_9d175bd7e80948ccb573987c4312e831(Parser yyq) : base(yyq,
          ((datavaler)(yyq.StackAt(4).m_value))
          ,
          ((datavaler)(yyq.StackAt(2).m_value))
          ,
          ((datavaler)(yyq.StackAt(0).m_value))
          , null, null, null)
        { }
    }

    public class chain_f1d1e8479fab4525a8b3a49c2185acfd : chain
    {
        public chain_f1d1e8479fab4525a8b3a49c2185acfd(Parser yyq) : base(yyq,
          ((role)(yyq.StackAt(3).m_value))
          ,
          ((role)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class chain_5daba5ce21514b7b8d7cd821e7c45d4e : chain
    {
        public chain_5daba5ce21514b7b8d7cd821e7c45d4e(Parser yyq) : base(yyq,
          ((chain)(yyq.StackAt(3).m_value))
          ,
          ((role)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class orObjectRoleExprChain_5fc55687f5bb48589182786b97a199c8 : orObjectRoleExprChain
    {
        public orObjectRoleExprChain_5fc55687f5bb48589182786b97a199c8(Parser yyq) : base(yyq,
          ((objectRoleExpr)(yyq.StackAt(2).m_value))
          ,
          ((objectRoleExpr)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class orObjectRoleExprChain_1280932fed444a0dbbe66357a095bc98 : orObjectRoleExprChain
    {
        public orObjectRoleExprChain_1280932fed444a0dbbe66357a095bc98(Parser yyq) : base(yyq,
          ((orObjectRoleExprChain)(yyq.StackAt(2).m_value))
          ,
          ((objectRoleExpr)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class roleWithXY_bb5d6ff79bbc40df8487cf0d619e22e7 : roleWithXY
    {
        public roleWithXY_bb5d6ff79bbc40df8487cf0d619e22e7(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(1).m_value))
          .yytext, false)
        { }
    }

    public class roleWithXY_5c11be3751d74f2fafcd1c1dc41dc069 : roleWithXY
    {
        public roleWithXY_5c11be3751d74f2fafcd1c1dc41dc069(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(1).m_value))
          .yytext, true)
        { }
    }

    public class notRoleWithXY_b64e4dfa1d3648f2ba1cb621d93842c4 : notRoleWithXY
    {
        public notRoleWithXY_b64e4dfa1d3648f2ba1cb621d93842c4(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(1).m_value))
          .yytext, false)
        { }
    }

    public class notRoleWithXY_52cb25920ebd47df94420b8e97bb2a19 : notRoleWithXY
    {
        public notRoleWithXY_52cb25920ebd47df94420b8e97bb2a19(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(1).m_value))
          .yytext, true)
        { }
    }

    public class andanyrolechain_9cb513c982124810877effaecd901b05 : andanyrolechain
    {
        public andanyrolechain_9cb513c982124810877effaecd901b05(Parser yyq) : base(yyq,
          ((role)(yyq.StackAt(1).m_value))
          , false)
        { }
    }

    public class andanyrolechain_edab88b964b3415ea64a77e329d21f2b : andanyrolechain
    {
        public andanyrolechain_edab88b964b3415ea64a77e329d21f2b(Parser yyq) : base(yyq,
          ((role)(yyq.StackAt(2).m_value))
          , true)
        { }
    }

    public class andanyrolechain_0fb0bf0280ea497fa0987d6c7f3495a8 : andanyrolechain
    {
        public andanyrolechain_0fb0bf0280ea497fa0987d6c7f3495a8(Parser yyq) : base(yyq,
          ((andanyrolechain)(yyq.StackAt(4).m_value))
          ,
          ((role)(yyq.StackAt(1).m_value))
          , false)
        { }
    }

    public class andanyrolechain_ae905887b9044709890fb37bfff1f7d2 : andanyrolechain
    {
        public andanyrolechain_ae905887b9044709890fb37bfff1f7d2(Parser yyq) : base(yyq,
          ((andanyrolechain)(yyq.StackAt(5).m_value))
          ,
          ((role)(yyq.StackAt(2).m_value))
          , true)
        { }
    }

    public class subjectEvery_9a9d70377b6d4bbdb1976cff0484dd2c : subjectEvery
    {
        public subjectEvery_9a9d70377b6d4bbdb1976cff0484dd2c(Parser yyq) : base(yyq,
          ((single)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class subjectEverything_eafee055036a4f93a25c840d4b1400b8 : subjectEverything
    {
        public subjectEverything_eafee055036a4f93a25c840d4b1400b8(Parser yyq) : base(yyq) { }
    }

    public class subjectEverything_d8d0f8f1d0e7462c8d1f6773d656e8d3 : subjectEverything
    {
        public subjectEverything_d8d0f8f1d0e7462c8d1f6773d656e8d3(Parser yyq) : base(yyq,
          ((that)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class subjectBigName_d35cd74c001042809ecb7c047ee96c03 : subjectBigName
    {
        public subjectBigName_d35cd74c001042809ecb7c047ee96c03(Parser yyq) : base(yyq,
          ((BIGNAME)(yyq.StackAt(0).m_value))
          .yytext, false)
        { }
    }

    public class subjectBigName_e247709fad4f46e8af6b598ac4e69ed9 : subjectBigName
    {
        public subjectBigName_e247709fad4f46e8af6b598ac4e69ed9(Parser yyq) : base(yyq,
          ((VERYBIGNAME)(yyq.StackAt(0).m_value))
          .yytext, true)
        { }
    }

    public class subjectThe_59b29ef9aabf4c0887f1a24fb530874e : subjectThe
    {
        public subjectThe_59b29ef9aabf4c0887f1a24fb530874e(Parser yyq) : base(yyq, false,
          ((single)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class subjectThe_6508d4ff2b3946699f3af047d72e60e6 : subjectThe
    {
        public subjectThe_6508d4ff2b3946699f3af047d72e60e6(Parser yyq) : base(yyq, true,
          ((single)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class subjectNo_3aa0e323824548baae9acb988db41f47 : subjectNo
    {
        public subjectNo_3aa0e323824548baae9acb988db41f47(Parser yyq) : base(yyq,
          ((single)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class subjectNothing_7a10a8be0b3141b49936878cfa3c2393 : subjectNothing
    {
        public subjectNothing_7a10a8be0b3141b49936878cfa3c2393(Parser yyq) : base(yyq) { }
    }

    public class modality_418a797e33f8415090b8ccb9cf27e0ca : modality
    {
        public modality_418a797e33f8415090b8ccb9cf27e0ca(Parser yyq) : base(yyq) { }
    }

    public class modality_8f69bc2826e14a64b655e1d64d497a75 : modality
    {
        public modality_8f69bc2826e14a64b655e1d64d497a75(Parser yyq) : base(yyq) { }
    }

    public class modality_8f69bc2826e14a64b655e1d64d497a75_6e7d1c5cb95c495886cac24c6c505c9e : modality_8f69bc2826e14a64b655e1d64d497a75
    {
        public modality_8f69bc2826e14a64b655e1d64d497a75_6e7d1c5cb95c495886cac24c6c505c9e(Parser yyq) : base(yyq) { yytext = ""; }
    }

    public class modality_a2b72e688f854a05b5285b0dafef6501 : modality
    {
        public modality_a2b72e688f854a05b5285b0dafef6501(Parser yyq) : base(yyq) { }
    }

    public class modality_2994985d0cdc4d74bde814570c298b31 : modality
    {
        public modality_2994985d0cdc4d74bde814570c298b31(Parser yyq) : base(yyq) { }
    }

    public class modality_2994985d0cdc4d74bde814570c298b31_51a1e4967eb4403ba2edffb6c4127ebd : modality_2994985d0cdc4d74bde814570c298b31
    {
        public modality_2994985d0cdc4d74bde814570c298b31_51a1e4967eb4403ba2edffb6c4127ebd(Parser yyq) : base(yyq)
        {
            switch (
((MODAL)(yyq.StackAt(0).m_value))
.yytext)
            {
                case "must": yytext = "□"; break;
                case "should": yytext = "◊"; break;
                case "can": yytext = "◊◊"; break;
                case "must-not": yytext = "~◊◊"; break;
                case "should-not": yytext = "~◊"; break;
                case "can-not": yytext = "~□"; break;
                default: throw new InvalidOperationException();
            }
        }
    }
    public partial class modality2 : PartialSymbol
    {
        public override string yyname_endl { get { return "modality2"; } }
        public override int yynum_endl { get { return 270; } }
    }

    public class modality2_39e84493f70c44e4b103f81e61df7146 : modality2
    {
        public modality2_39e84493f70c44e4b103f81e61df7146(Parser yyq) : base(yyq) { }
    }

    public class modality2_a9903bb7580245b5883060adb41cf3e7 : modality2
    {
        public modality2_a9903bb7580245b5883060adb41cf3e7(Parser yyq) : base(yyq) { }
    }

    public class modality2_a9903bb7580245b5883060adb41cf3e7_5978f781665c46f5898d26123f73c7da : modality2_a9903bb7580245b5883060adb41cf3e7
    {
        public modality2_a9903bb7580245b5883060adb41cf3e7_5978f781665c46f5898d26123f73c7da(Parser yyq) : base(yyq) { yytext = ""; }
    }

    public class modality2_d1082eb795094c42b220acc0e8512328 : modality2
    {
        public modality2_d1082eb795094c42b220acc0e8512328(Parser yyq) : base(yyq) { }
    }

    public class modality2_65c4f542ddbd4e18bcb08dfa7f89efc6 : modality2
    {
        public modality2_65c4f542ddbd4e18bcb08dfa7f89efc6(Parser yyq) : base(yyq) { }
    }

    public class modality2_65c4f542ddbd4e18bcb08dfa7f89efc6_17d398d661fb4d528f09bb6bbab1450f : modality2_65c4f542ddbd4e18bcb08dfa7f89efc6
    {
        public modality2_65c4f542ddbd4e18bcb08dfa7f89efc6_17d398d661fb4d528f09bb6bbab1450f(Parser yyq) : base(yyq)
        {
            switch (
((MODAL)(yyq.StackAt(1).m_value))
.yytext)
            {
                case "must": yytext = "□"; break;
                case "should": yytext = "◊"; break;
                case "can": yytext = "◊◊"; break;
                case "must-not": yytext = "~◊◊"; break;
                case "should-not": yytext = "~◊"; break;
                case "can-not": yytext = "~□"; break;
                default: throw new InvalidOperationException();
            }
        }
    }

    public class role_19de336b9f7f4160896933435e4fb29a : role
    {
        public role_19de336b9f7f4160896933435e4fb29a(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(0).m_value))
          .yytext, false)
        { }
    }

    public class role_1dd48d6cbe9549b084e63dbcf3a1aa81 : role
    {
        public role_1dd48d6cbe9549b084e63dbcf3a1aa81(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(1).m_value))
          .yytext, true)
        { }
    }

    public class objectRoleExpr1_447e56a3854146ce9506d780f10a1ba3 : objectRoleExpr1
    {
        public objectRoleExpr1_447e56a3854146ce9506d780f10a1ba3(Parser yyq) : base(yyq, false,
          ((oobject)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class objectRoleExpr2_916548c0549c4e3392c7d97720703364 : objectRoleExpr2
    {
        public objectRoleExpr2_916548c0549c4e3392c7d97720703364(Parser yyq) : base(yyq, false, null,
          ((role)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class objectRoleExpr2_bef62ec5bd3d466a851eadb99cdff5f6 : objectRoleExpr2
    {
        public objectRoleExpr2_bef62ec5bd3d466a851eadb99cdff5f6(Parser yyq) : base(yyq, false,
          ((oobject)(yyq.StackAt(0).m_value))
          ,
          ((role)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class objectRoleExpr2_924e43f9f12c47d39f389b84218c39b2 : objectRoleExpr2
    {
        public objectRoleExpr2_924e43f9f12c47d39f389b84218c39b2(Parser yyq) : base(yyq, false,
          ((oobjectRelated)(yyq.StackAt(0).m_value))
          ,
          ((role)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class objectRoleExpr3_efd2e20597084fa18a608bf2eebdaee0 : objectRoleExpr3
    {
        public objectRoleExpr3_efd2e20597084fa18a608bf2eebdaee0(Parser yyq) : base(yyq,
          ((that)(yyq.StackAt(0).m_value))
          ,
          ((role)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class objectRoleExpr1_36cf0e01213f4d05a90288649fbc298a : objectRoleExpr1
    {
        public objectRoleExpr1_36cf0e01213f4d05a90288649fbc298a(Parser yyq) : base(yyq, true,
          ((oobject)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class objectRoleExpr2_4563ca84b9a5499d9d0b46564a48e95d : objectRoleExpr2
    {
        public objectRoleExpr2_4563ca84b9a5499d9d0b46564a48e95d(Parser yyq) : base(yyq, true,
          ((oobject)(yyq.StackAt(0).m_value))
          ,
          ((NAME)(yyq.StackAt(1).m_value))
          .yytext)
        { }
    }

    public class objectRoleExpr2_0b291fc985a044dbb25bd6ce57f4e694 : objectRoleExpr2
    {
        public objectRoleExpr2_0b291fc985a044dbb25bd6ce57f4e694(Parser yyq) : base(yyq, true,
          ((oobjectRelated)(yyq.StackAt(0).m_value))
          ,
          ((NAME)(yyq.StackAt(1).m_value))
          .yytext)
        { }
    }

    public class objectRoleExpr2_1215fd8d349f4815b218576300ac412a : objectRoleExpr2
    {
        public objectRoleExpr2_1215fd8d349f4815b218576300ac412a(Parser yyq) : base(yyq, true,
          ((oobject)(yyq.StackAt(0).m_value))
          ,
          ((NAME)(yyq.StackAt(2).m_value))
          .yytext, true)
        { }
    }

    public class objectRoleExpr2_8a5455a74e4b4e8e82837a108198e0cd : objectRoleExpr2
    {
        public objectRoleExpr2_8a5455a74e4b4e8e82837a108198e0cd(Parser yyq) : base(yyq, true,
          ((oobjectRelated)(yyq.StackAt(0).m_value))
          ,
          ((NAME)(yyq.StackAt(2).m_value))
          .yytext, true)
        { }
    }

    public class instanceBigName_1e636d9f23c1424fb328abdd45d2ce29 : instanceBigName
    {
        public instanceBigName_1e636d9f23c1424fb328abdd45d2ce29(Parser yyq) : base(yyq,
          ((BIGNAME)(yyq.StackAt(0).m_value))
          .yytext, false)
        { }
    }

    public class instanceBigName_9280333231384117af3a6a0100620d76 : instanceBigName
    {
        public instanceBigName_9280333231384117af3a6a0100620d76(Parser yyq) : base(yyq,
          ((VERYBIGNAME)(yyq.StackAt(0).m_value))
          .yytext, true)
        { }
    }

    public class instanceThe_0e073159e58d4676ae81f9be6dc723ee : instanceThe
    {
        public instanceThe_0e073159e58d4676ae81f9be6dc723ee(Parser yyq) : base(yyq, false,
          ((single)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class instanceThe_aabecdb18b164b9e806c3f5407c38d6f : instanceThe
    {
        public instanceThe_aabecdb18b164b9e806c3f5407c38d6f(Parser yyq) : base(yyq, true,
          ((single)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class instanceList_d5ff625a1a5e40f2b562e8162854b3c4 : instanceList
    {
        public instanceList_d5ff625a1a5e40f2b562e8162854b3c4(Parser yyq) : base(yyq,
          ((instance)(yyq.StackAt(2).m_value))
          ,
          ((instance)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class instanceList_069c2d4f5b5a45a1befc5253260ec712 : instanceList
    {
        public instanceList_069c2d4f5b5a45a1befc5253260ec712(Parser yyq) : base(yyq,
          ((instanceList)(yyq.StackAt(2).m_value))
          ,
          ((instance)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class oobjectA_b25547576b434f7fab695d719256db02 : oobjectA
    {
        public oobjectA_b25547576b434f7fab695d719256db02(Parser yyq) : base(yyq,
          ((single)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class oobjectA_17fb8807dc2a404e8456e6658b43a07d : oobjectA
    {
        public oobjectA_17fb8807dc2a404e8456e6658b43a07d(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class oobjectA_ebcc38bea7724ceeb1528c0f415eb9fe : oobjectA
    {
        public oobjectA_ebcc38bea7724ceeb1528c0f415eb9fe(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(1).m_value))
          .yytext,
          ((that)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class oobjectSomething_2939bf68e33d408393cc769e668447e1 : oobjectSomething
    {
        public oobjectSomething_2939bf68e33d408393cc769e668447e1(Parser yyq) : base(yyq) { }
    }

    public class oobjectNothing_2901c595cf1540c19f93bb5c009cbb87 : oobjectNothing
    {
        public oobjectNothing_2901c595cf1540c19f93bb5c009cbb87(Parser yyq) : base(yyq) { }
    }

    public class oobjectSomethingThat_07ef2c4b1ef34c98812ebce5f195afb5 : oobjectSomethingThat
    {
        public oobjectSomethingThat_07ef2c4b1ef34c98812ebce5f195afb5(Parser yyq) : base(yyq,
          ((that)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class oobjectInstance_722298a5591f4241b81f6afc6f9b4040 : oobjectInstance
    {
        public oobjectInstance_722298a5591f4241b81f6afc6f9b4040(Parser yyq) : base(yyq,
          ((instance)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class oobjectOnly_318ac4d9886640ad915d368dfcce1ff8 : oobjectOnly
    {
        public oobjectOnly_318ac4d9886640ad915d368dfcce1ff8(Parser yyq) : base(yyq,
          ((single)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class oobjectOnlyInstance_1efa92f90a8941c78aa48223d0dc46f8 : oobjectOnlyInstance
    {
        public oobjectOnlyInstance_1efa92f90a8941c78aa48223d0dc46f8(Parser yyq) : base(yyq,
          ((instance)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class oobjectOnlyNothing_8646f1419d734b9894c47da4bf657213 : oobjectOnlyNothing
    {
        public oobjectOnlyNothing_8646f1419d734b9894c47da4bf657213(Parser yyq) : base(yyq) { }
    }

    public class oobjectOnlySomethingThat_623f154535ae4f53951b0fadee21be88 : oobjectOnlySomethingThat
    {
        public oobjectOnlySomethingThat_623f154535ae4f53951b0fadee21be88(Parser yyq) : base(yyq,
          ((that)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class oobjectSelf_107b7f335e9642db95cbe9eacf9e8599 : oobjectSelf
    {
        public oobjectSelf_107b7f335e9642db95cbe9eacf9e8599(Parser yyq) : base(yyq) { }
    }

    public class oobjectBnd_f5bc457fb16a4e18af92122e283da35e : oobjectBnd
    {
        public oobjectBnd_f5bc457fb16a4e18af92122e283da35e(Parser yyq) : base(yyq,
          ((abstractbound)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class oobjectOnlyBnd_0f7bc12a73fe4b20b422df4fe7d65cf3 : oobjectOnlyBnd
    {
        public oobjectOnlyBnd_0f7bc12a73fe4b20b422df4fe7d65cf3(Parser yyq) : base(yyq,
          ((abstractbound)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class oobjectCmp_ff0528b2d05e491e8f6feadcdb7a5070 : oobjectCmp
    {
        public oobjectCmp_ff0528b2d05e491e8f6feadcdb7a5070(Parser yyq) : base(yyq,
          ((comparer)(yyq.StackAt(2).m_value))
          .yytext,
          ((word_number)(yyq.StackAt(1).m_value))
          .yytext,
          ((single)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class oobjectCmpInstance_62f6ed86ccc8445fbfb0f1cbe9b8ee54 : oobjectCmpInstance
    {
        public oobjectCmpInstance_62f6ed86ccc8445fbfb0f1cbe9b8ee54(Parser yyq) : base(yyq,
          ((comparer)(yyq.StackAt(2).m_value))
          .yytext,
          ((word_number)(yyq.StackAt(1).m_value))
          .yytext,
          ((instance)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class oobjectCmpBnd_ae7f63b9a17b4ffca0c504642566dc07 : oobjectCmpBnd
    {
        public oobjectCmpBnd_ae7f63b9a17b4ffca0c504642566dc07(Parser yyq) : base(yyq,
          ((comparer)(yyq.StackAt(2).m_value))
          .yytext,
          ((word_number)(yyq.StackAt(1).m_value))
          .yytext,
          ((abstractbound)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class singleName_96baba4832584aa5a9c41319d6aac993 : singleName
    {
        public singleName_96baba4832584aa5a9c41319d6aac993(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class singleThing_eff0badc6a2b437fbf4688f7c457b0ea : singleThing
    {
        public singleThing_eff0badc6a2b437fbf4688f7c457b0ea(Parser yyq) : base(yyq) { }
    }

    public class singleThing_027b542c7d7d420f9939341d13468e6f : singleThing
    {
        public singleThing_027b542c7d7d420f9939341d13468e6f(Parser yyq) : base(yyq) { }
    }

    public class singleThing_2c020c6f78d04c66affa2f215acad6f0 : singleThing
    {
        public singleThing_2c020c6f78d04c66affa2f215acad6f0(Parser yyq) : base(yyq) { }
    }

    public class singleNameThat_dcf44b171bab44659e6789f964328462 : singleNameThat
    {
        public singleNameThat_dcf44b171bab44659e6789f964328462(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(1).m_value))
          .yytext,
          ((that)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class singleThingThat_4af593f3c9c942aa8d42c41502b3cfd9 : singleThingThat
    {
        public singleThingThat_4af593f3c9c942aa8d42c41502b3cfd9(Parser yyq) : base(yyq,
          ((that)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class singleThingThat_c13bf3918b4e485590d9146d5d5071de : singleThingThat
    {
        public singleThingThat_c13bf3918b4e485590d9146d5d5071de(Parser yyq) : base(yyq,
          ((that)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class singleThingThat_5aa505e771854f21833e7d6c82f10846 : singleThingThat
    {
        public singleThingThat_5aa505e771854f21833e7d6c82f10846(Parser yyq) : base(yyq,
          ((that)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class singleOneOf_f9240bafbcaf418d8bfe10765ad8e1f9 : singleOneOf
    {
        public singleOneOf_f9240bafbcaf418d8bfe10765ad8e1f9(Parser yyq) : base(yyq,
          ((instanceList)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class singleOneOf_9f64f95e0fe54d98a7cc112260916b4c : singleOneOf
    {
        public singleOneOf_9f64f95e0fe54d98a7cc112260916b4c(Parser yyq) : base(yyq,
          ((instanceList)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class thatOrLoop_268216a573c34a43bde29d7d942ad849 : thatOrLoop
    {
        public thatOrLoop_268216a573c34a43bde29d7d942ad849(Parser yyq) : base(yyq,
          ((orloop)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class thatOrLoop_cc5e77cf72b948a89f0ce8fc8ddb7303 : thatOrLoop
    {
        public thatOrLoop_cc5e77cf72b948a89f0ce8fc8ddb7303(Parser yyq) : base(yyq,
          ((orloop)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class andloop_e2351c0e014c4a929e8994e6c5548a06 : andloop
    {
        public andloop_e2351c0e014c4a929e8994e6c5548a06(Parser yyq) : base(yyq,
          ((objectRoleExpr)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class andloop_e3de1582f6d74803ab551f91b1708bcd : andloop
    {
        public andloop_e3de1582f6d74803ab551f91b1708bcd(Parser yyq) : base(yyq,
          ((andloop)(yyq.StackAt(2).m_value))
          ,
          ((objectRoleExpr)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class orloop_009a8290e37345849a1180987de9be5b : orloop
    {
        public orloop_009a8290e37345849a1180987de9be5b(Parser yyq) : base(yyq,
          ((andloop)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class orloop_a4d7a2437b774b5f91927bcf3a5d48b8 : orloop
    {
        public orloop_a4d7a2437b774b5f91927bcf3a5d48b8(Parser yyq) : base(yyq,
          ((orloop)(yyq.StackAt(2).m_value))
          ,
          ((andloop)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class comparer_1592b4ba6da04d7aa71e8b2f19b6bc01 : comparer
    {
        public comparer_1592b4ba6da04d7aa71e8b2f19b6bc01(Parser yyq) : base(yyq) { }
    }

    public class comparer_a0c0bb93e6ae469793321c37956af897 : comparer
    {
        public comparer_a0c0bb93e6ae469793321c37956af897(Parser yyq) : base(yyq) { }
    }

    public class comparer_a0c0bb93e6ae469793321c37956af897_04b1cd80d9ec4dc9b2e56bad4333cc56 : comparer_a0c0bb93e6ae469793321c37956af897
    {
        public comparer_a0c0bb93e6ae469793321c37956af897_04b1cd80d9ec4dc9b2e56bad4333cc56(Parser yyq) : base(yyq) { yytext = "="; }
    }

    public class comparer_145f81cae96f4e20b3227cffa71b35d3 : comparer
    {
        public comparer_145f81cae96f4e20b3227cffa71b35d3(Parser yyq) : base(yyq) { }
    }

    public class comparer_5ecbaad0e39b422491fc9c98728523fc : comparer
    {
        public comparer_5ecbaad0e39b422491fc9c98728523fc(Parser yyq) : base(yyq) { }
    }

    public class comparer_5ecbaad0e39b422491fc9c98728523fc_ba645194d6924b0087226328f3ed2351 : comparer_5ecbaad0e39b422491fc9c98728523fc
    {
        public comparer_5ecbaad0e39b422491fc9c98728523fc_ba645194d6924b0087226328f3ed2351(Parser yyq) : base(yyq)
        {
            switch (
((COMPARER)(yyq.StackAt(0).m_value))
.yytext)
            {
                case "at-most": yytext = "≤"; break;
                case "at-least": yytext = "≥"; break;
                case "less-than": yytext = "<"; break;
                case "more-than": yytext = ">"; break;
                case "different-than": yytext = "≠"; break;
                default: throw new InvalidOperationException();
            }
        }
    }

    public class word_number_f7873402a182481d9f3d6ec914ae2965 : word_number
    {
        public word_number_f7873402a182481d9f3d6ec914ae2965(Parser yyq) : base(yyq) { }
    }

    public class word_number_f29f4b45d4f6440faab7b038d63e8016 : word_number
    {
        public word_number_f29f4b45d4f6440faab7b038d63e8016(Parser yyq) : base(yyq) { }
    }

    public class word_number_f29f4b45d4f6440faab7b038d63e8016_1ce16831796c4da3aef1ace355e30bbe : word_number_f29f4b45d4f6440faab7b038d63e8016
    {
        public word_number_f29f4b45d4f6440faab7b038d63e8016_1ce16831796c4da3aef1ace355e30bbe(Parser yyq) : base(yyq)
        {
            switch (
((WORDNUM)(yyq.StackAt(0).m_value))
.yytext)
            {
                case "zero": yytext = "0"; break;
                case "one": yytext = "1"; break;
                case "two": yytext = "2"; break;
                case "three": yytext = "3"; break;
                case "four": yytext = "4"; break;
                case "five": yytext = "5"; break;
                case "six": yytext = "6"; break;
                case "seven": yytext = "7"; break;
                case "eight": yytext = "8"; break;
                case "nine": yytext = "9"; break;
                case "ten": yytext = "10"; break;
                case "eleven": yytext = "11"; break;
                case "twelve": yytext = "12"; break;
                case "thirteen": yytext = "13"; break;
                case "fourteen": yytext = "14"; break;
                case "fifteen": yytext = "15"; break;
                case "sixteen": yytext = "16"; break;
                case "seventeen": yytext = "17"; break;
                case "eighteen": yytext = "18"; break;
                case "nineteen": yytext = "19"; break;
                case "twenty": yytext = "20"; break;
                default: throw new InvalidOperationException();
            }
        }
    }

    public class word_number_e49d3cc248904823a1e3a1a3e0636e87 : word_number
    {
        public word_number_e49d3cc248904823a1e3a1a3e0636e87(Parser yyq) : base(yyq) { }
    }

    public class word_number_75bd5a6cddf347a09ca63021c8ed26ad : word_number
    {
        public word_number_75bd5a6cddf347a09ca63021c8ed26ad(Parser yyq) : base(yyq) { }
    }

    public class word_number_75bd5a6cddf347a09ca63021c8ed26ad_faba2b6d66ab4550a02bb74333041ec9 : word_number_75bd5a6cddf347a09ca63021c8ed26ad
    {
        public word_number_75bd5a6cddf347a09ca63021c8ed26ad_faba2b6d66ab4550a02bb74333041ec9(Parser yyq) : base(yyq)
        {
            yytext =
((NAT)(yyq.StackAt(0).m_value))
.yytext;
        }
    }

    public class facet_522c79e37a364067a3af29e0c191bfac : facet
    {
        public facet_522c79e37a364067a3af29e0c191bfac(Parser yyq) : base(yyq, (
          ((COMPARER2)(yyq.StackAt(1).m_value))
          .yytext == "lower-or-equal-to" ? "≤" : (
          ((COMPARER2)(yyq.StackAt(1).m_value))
          .yytext == "greater-or-equal-to" ? "≥" : (
          ((COMPARER2)(yyq.StackAt(1).m_value))
          .yytext == "lower-than" ? "<" : ">"))),
          ((dataval)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class facet_0d405be671eb4858b930ed5b5683541e : facet
    {
        public facet_0d405be671eb4858b930ed5b5683541e(Parser yyq) : base(yyq, "#",
          ((STR)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class facet_7ac077192b684ee5a57818db00d8ba40 : facet
    {
        public facet_7ac077192b684ee5a57818db00d8ba40(Parser yyq) : base(yyq, "<->",
          ((NAT)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class facet_35a26489569e44c89c44ce226a3368bc : facet
    {
        public facet_35a26489569e44c89c44ce226a3368bc(Parser yyq) : base(yyq, "<-> " + (
          ((COMPARER2)(yyq.StackAt(1).m_value))
          .yytext == "lower-or-equal-to" ? "≤" : (
          ((COMPARER2)(yyq.StackAt(1).m_value))
          .yytext == "greater-or-equal-to" ? "≥" : (
          ((COMPARER2)(yyq.StackAt(1).m_value))
          .yytext == "lower-than" ? "<" : ">"))),
          ((NAT)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class facetList_165d6454d84548f6bd60c95dd795ab59 : facetList
    {
        public facetList_165d6454d84548f6bd60c95dd795ab59(Parser yyq) : base(yyq,
          ((facet)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class facetList_4439de31ce8d4a6dad5120738bb949b8 : facetList
    {
        public facetList_4439de31ce8d4a6dad5120738bb949b8(Parser yyq) : base(yyq,
          ((facetList)(yyq.StackAt(2).m_value))
          ,
          ((facet)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class boundFacets_b18592c63926410fa1be8207c1c1239b : boundFacets
    {
        public boundFacets_b18592c63926410fa1be8207c1c1239b(Parser yyq) : base(yyq,
          ((facetList)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class boundVal_c828dcad517f46a4a90fc47a1f03bc1c : boundVal
    {
        public boundVal_c828dcad517f46a4a90fc47a1f03bc1c(Parser yyq) : base(yyq, "=",
          ((dataval)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class boundVal_29311d3be24545c1a3d44fc83ce5932f : boundVal
    {
        public boundVal_29311d3be24545c1a3d44fc83ce5932f(Parser yyq) : base(yyq, "≠",
          ((dataval)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class boundOneOf_95c897a4a52e48cbbdecc5b57b19d24b : boundOneOf
    {
        public boundOneOf_95c897a4a52e48cbbdecc5b57b19d24b(Parser yyq) : base(yyq,
          ((datavalList)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class boundTop_275235405d9443ac9a990108000eb708 : boundTop
    {
        public boundTop_275235405d9443ac9a990108000eb708(Parser yyq) : base(yyq) { }
    }

    public class boundTotal_aece926e36334b22b0ccccd4a9967b6f : boundTotal
    {
        public boundTotal_aece926e36334b22b0ccccd4a9967b6f(Parser yyq) : base(yyq,
          ((DATATYPENAME)(yyq.StackAt(2).m_value))
          .yytext == "integer" ? "NUM" : (
          ((DATATYPENAME)(yyq.StackAt(2).m_value))
          .yytext == "string" ? "STR" : (
          ((DATATYPENAME)(yyq.StackAt(2).m_value))
          .yytext == "real" ? "DBL" : (
          ((DATATYPENAME)(yyq.StackAt(2).m_value))
          .yytext == "duration" ? "DUR" : (
          ((DATATYPENAME)(yyq.StackAt(2).m_value))
          .yytext == "datetime" ? "DTM" : "BOL")))))
        { }
    }

    public class boundDataType_0fc663b1365a4a469182eee5fcb869b1 : boundDataType
    {
        public boundDataType_0fc663b1365a4a469182eee5fcb869b1(Parser yyq) : base(yyq,
          ((NAME)(yyq.StackAt(2).m_value))
          .yytext)
        { }
    }

    public class boundIdent_ca48d918cfd84dfda3281d288116a0d9 : boundIdent
    {
        public boundIdent_ca48d918cfd84dfda3281d288116a0d9(Parser yyq) : base(yyq,
          ((abstractbound)(yyq.StackAt(1).m_value))
          )
        { }
    }

    public class boundAnd_9c7407cefecf40c9b2a9028e2662b542 : boundAnd
    {
        public boundAnd_9c7407cefecf40c9b2a9028e2662b542(Parser yyq) : base(yyq,
          ((abstractbound)(yyq.StackAt(2).m_value))
          ,
          ((abstractbound)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class boundOr_175e4bd629cc4ce4bbcb2a4999452b4c : boundOr
    {
        public boundOr_175e4bd629cc4ce4bbcb2a4999452b4c(Parser yyq) : base(yyq,
          ((abstractbound)(yyq.StackAt(2).m_value))
          ,
          ((abstractbound)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class boundNot_45259cdb5cc64446ab1766109ff78fdf : boundNot
    {
        public boundNot_45259cdb5cc64446ab1766109ff78fdf(Parser yyq) : base(yyq,
          ((abstractbound)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class Number_695f0fa0c7f749ee9618398b97f99dc9 : Number
    {
        public Number_695f0fa0c7f749ee9618398b97f99dc9(Parser yyq) : base(yyq,
          ((NAT)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class Number_905fb068ff8c4500a200cb7d77c377a0 : Number
    {
        public Number_905fb068ff8c4500a200cb7d77c377a0(Parser yyq) : base(yyq,
          ((NUM)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class StrData_cfad7327880546028155730124b7a9c2 : StrData
    {
        public StrData_cfad7327880546028155730124b7a9c2(Parser yyq) : base(yyq,
          ((STR)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class DateTimeData_2cce692ba0a5488c9b79920d2e985eaf : DateTimeData
    {
        public DateTimeData_2cce692ba0a5488c9b79920d2e985eaf(Parser yyq) : base(yyq,
          ((DTM)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class Duration_9e45f683e8974e1281bfe106323d0b43 : Duration
    {
        public Duration_9e45f683e8974e1281bfe106323d0b43(Parser yyq) : base(yyq,
          ((DUR)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class Float_9a6d2ea064fb4affa593690db836281b : Float
    {
        public Float_9a6d2ea064fb4affa593690db836281b(Parser yyq) : base(yyq,
          ((DBL)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class Bool_7bd728463a3648f4821dcc1df88074ae : Bool
    {
        public Bool_7bd728463a3648f4821dcc1df88074ae(Parser yyq) : base(yyq,
          ((BOL)(yyq.StackAt(0).m_value))
          .yytext)
        { }
    }

    public class datavalList_8c8a6b39af874ea182c64a8d745197bc : datavalList
    {
        public datavalList_8c8a6b39af874ea182c64a8d745197bc(Parser yyq) : base(yyq,
          ((dataval)(yyq.StackAt(2).m_value))
          ,
          ((dataval)(yyq.StackAt(0).m_value))
          )
        { }
    }

    public class datavalList_bbab639eab514464a606fc27d2b58cfb : datavalList
    {
        public datavalList_bbab639eab514464a606fc27d2b58cfb(Parser yyq) : base(yyq,
          ((datavalList)(yyq.StackAt(2).m_value))
          ,
          ((dataval)(yyq.StackAt(0).m_value))
          )
        { }
    }
    public class yyendl : YyParser
    {
        public override object Action(Parser yyq, SYMBOL yysym, int yyact)
        {
            switch (yyact)
            {
                case -1: break; //// keep compiler happy
            }
            return null;
        }

        public class andComma_e5f37ebe59584ba2868ea509fe54bb77 : andComma
        {
            public andComma_e5f37ebe59584ba2868ea509fe54bb77(Parser yyq) : base(yyq) { }
        }

        public class andComma_7a1140bd0fba4a04bdcf342ba6e7a16d : andComma
        {
            public andComma_7a1140bd0fba4a04bdcf342ba6e7a16d(Parser yyq) : base(yyq) { }
        }

        public class isBeAre_c074f3547e2642baae4dee8d613e8409 : isBeAre
        {
            public isBeAre_c074f3547e2642baae4dee8d613e8409(Parser yyq) : base(yyq) { }
        }

        public class isBeAre_5c14e059db714db585d1b5f2d4ff642d : isBeAre
        {
            public isBeAre_5c14e059db714db585d1b5f2d4ff642d(Parser yyq) : base(yyq) { }
        }

        public class doesNot_a3f6472835454ce98820f5340279efd6 : doesNot
        {
            public doesNot_a3f6472835454ce98820f5340279efd6(Parser yyq) : base(yyq) { }
        }

        public class doesNot_ffd19021ca9b42d185d150974fcf38fc : doesNot
        {
            public doesNot_ffd19021ca9b42d185d150974fcf38fc(Parser yyq) : base(yyq) { }
        }

        public class doesNotBy_85bea99ab26f4aca9250e879bcb8f56d : doesNotBy
        {
            public doesNotBy_85bea99ab26f4aca9250e879bcb8f56d(Parser yyq) : base(yyq) { }
        }

        public class doesNotBy_996156a337804089bc11b27d2ae541de : doesNotBy
        {
            public doesNotBy_996156a337804089bc11b27d2ae541de(Parser yyq) : base(yyq) { }
        }

        public class doesNotBy_efdc773be95d4eb89dc96e2228b39f7c : doesNotBy
        {
            public doesNotBy_efdc773be95d4eb89dc96e2228b39f7c(Parser yyq) : base(yyq) { }
        }

        public class aAn_4da7a5201e2b453cab1bb992ac99294f : aAn
        {
            public aAn_4da7a5201e2b453cab1bb992ac99294f(Parser yyq) : base(yyq) { }
        }

        public class orComma_de6f2dda1b30498c9c2c5d4e08dcbc02 : orComma
        {
            public orComma_de6f2dda1b30498c9c2c5d4e08dcbc02(Parser yyq) : base(yyq) { }
        }

        public class orComma_c868b6e1644e46dd8b823005b69c36f6 : orComma
        {
            public orComma_c868b6e1644e46dd8b823005b69c36f6(Parser yyq) : base(yyq) { }
        }
        public yyendl() : base()
        {
            arr = new int[] {
101,4,6,52,0,
46,0,53,0,102,
20,103,4,18,112,
0,97,0,114,0,
97,0,103,0,114,
0,97,0,112,0,
104,0,1,102,1,
2,104,18,1,1780,
102,2,0,105,5,
512,1,954,106,18,
1,954,107,20,108,
4,22,105,0,100,
0,101,0,110,0,
116,0,111,0,98,
0,106,0,101,0,
99,0,116,0,1,
223,1,2,2,0,
1,1531,109,18,1,
1531,110,20,111,4,
8,84,0,72,0,
69,0,78,0,1,
35,1,1,2,0,
1,921,112,18,1,
921,113,20,114,4,
20,65,0,78,0,
78,0,79,0,84,
0,65,0,84,0,
73,0,79,0,78,
0,1,90,1,1,
2,0,1,913,115,
18,1,913,107,2,
0,1,912,116,18,
1,912,117,20,118,
4,18,100,0,97,
0,116,0,97,0,
118,0,97,0,108,
0,101,0,114,0,
1,227,1,2,2,
0,1,911,119,18,
1,911,120,20,121,
4,18,105,0,110,
0,115,0,116,0,
97,0,110,0,99,
0,101,0,114,0,
1,226,1,2,2,
0,1,910,122,18,
1,910,123,20,124,
4,14,66,0,73,
0,71,0,78,0,
65,0,77,0,69,
0,1,98,1,1,
2,0,1,909,125,
18,1,909,126,20,
127,4,22,86,0,
69,0,82,0,89,
0,66,0,73,0,
71,0,78,0,65,
0,77,0,69,0,
1,99,1,1,2,
0,1,908,128,18,
1,908,129,20,130,
4,10,67,0,76,
0,79,0,83,0,
69,0,1,94,1,
1,2,0,1,907,
131,18,1,907,132,
20,133,4,6,78,
0,65,0,84,0,
1,5,1,1,2,
0,1,906,134,18,
1,906,135,20,136,
4,8,79,0,80,
0,69,0,78,0,
1,93,1,1,2,
0,1,905,137,18,
1,905,138,20,139,
4,8,78,0,65,
0,77,0,69,0,
1,97,1,1,2,
0,1,904,140,18,
1,904,129,2,0,
1,903,141,18,1,
903,132,2,0,1,
902,142,18,1,902,
135,2,0,1,901,
143,18,1,901,144,
20,145,4,10,84,
0,72,0,73,0,
78,0,71,0,1,
43,1,1,2,0,
1,899,146,18,1,
899,147,20,148,4,
6,84,0,72,0,
69,0,1,19,1,
1,2,0,1,890,
149,18,1,890,150,
20,151,4,6,65,
0,78,0,68,0,
1,49,1,1,2,
0,1,885,152,18,
1,885,117,2,0,
1,1799,153,18,1,
1799,154,20,155,4,
16,115,0,101,0,
110,0,116,0,101,
0,110,0,99,0,
101,0,1,103,1,
2,2,0,1,1798,
156,18,1,1798,157,
23,158,4,6,69,
0,79,0,70,0,
1,2,1,6,2,
0,1,1797,159,18,
1,1797,154,2,0,
1,877,160,18,1,
877,161,20,162,4,
14,101,0,113,0,
117,0,97,0,108,
0,84,0,111,0,
1,336,1,2,2,
0,1,876,163,18,
1,876,164,20,165,
4,14,101,0,120,
0,101,0,97,0,
114,0,103,0,115,
0,1,232,1,2,
2,0,1,1578,166,
18,1,1578,138,2,
0,1,868,167,18,
1,868,168,20,169,
4,6,70,0,79,
0,82,0,1,67,
1,1,2,0,1,
867,170,18,1,867,
171,20,172,4,6,
83,0,84,0,82,
0,1,3,1,1,
2,0,1,866,173,
18,1,866,174,20,
175,4,16,82,0,
69,0,83,0,85,
0,76,0,84,0,
79,0,70,0,1,
91,1,1,2,0,
1,1483,176,18,1,
1483,177,20,178,4,
14,111,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
1,142,1,2,2,
0,1,1780,104,1,
1779,179,18,1,1779,
180,20,181,4,14,
67,0,79,0,77,
0,77,0,69,0,
78,0,84,0,1,
10,1,1,2,0,
1,857,182,18,1,
857,183,20,184,4,
18,67,0,79,0,
77,0,80,0,65,
0,82,0,69,0,
82,0,50,0,1,
13,1,1,2,0,
1,1764,185,18,1,
1764,186,20,187,4,
6,69,0,78,0,
68,0,1,101,1,
1,2,0,1,844,
188,18,1,844,189,
20,190,4,14,69,
0,81,0,85,0,
65,0,76,0,84,
0,79,0,1,14,
1,1,2,0,1,
1721,191,18,1,1721,
189,2,0,1,1761,
192,18,1,1761,193,
20,194,4,16,109,
0,111,0,100,0,
97,0,108,0,105,
0,116,0,121,0,
1,131,1,2,2,
0,1,1759,195,18,
1,1759,196,20,197,
4,14,115,0,117,
0,98,0,106,0,
101,0,99,0,116,
0,1,119,1,2,
2,0,1,835,198,
18,1,835,199,20,
200,4,26,68,0,
73,0,70,0,70,
0,69,0,82,0,
69,0,78,0,84,
0,70,0,82,0,
79,0,77,0,1,
15,1,1,2,0,
1,831,201,18,1,
831,202,20,203,4,
26,97,0,98,0,
115,0,116,0,114,
0,97,0,99,0,
116,0,98,0,111,
0,117,0,110,0,
100,0,1,184,1,
2,2,0,1,829,
204,18,1,829,205,
20,206,4,4,73,
0,83,0,1,46,
1,1,2,0,1,
828,207,18,1,828,
208,20,209,4,6,
67,0,77,0,80,
0,1,78,1,1,
2,0,1,827,210,
18,1,827,211,20,
212,4,4,69,0,
81,0,1,77,1,
1,2,0,1,1623,
213,18,1,1623,214,
20,215,4,14,111,
0,114,0,67,0,
111,0,109,0,109,
0,97,0,1,197,
1,2,2,0,1,
824,216,18,1,824,
117,2,0,1,1742,
217,18,1,1742,218,
20,219,4,12,111,
0,114,0,108,0,
111,0,111,0,112,
0,1,172,1,2,
2,0,1,1741,220,
18,1,1741,193,2,
0,1,1739,221,18,
1,1739,222,20,223,
4,18,110,0,111,
0,115,0,117,0,
98,0,106,0,101,
0,99,0,116,0,
1,124,1,2,2,
0,1,1738,224,18,
1,1738,186,2,0,
1,1737,225,18,1,
1737,226,20,227,4,
20,114,0,111,0,
108,0,101,0,87,
0,105,0,116,0,
104,0,88,0,89,
0,1,161,1,2,
2,0,1,816,228,
18,1,816,229,20,
230,4,8,80,0,
76,0,85,0,83,
0,1,79,1,1,
2,0,1,1734,231,
18,1,1734,232,20,
233,4,22,73,0,
70,0,65,0,78,
0,68,0,79,0,
78,0,76,0,89,
0,73,0,70,0,
1,22,1,1,2,
0,1,1733,234,18,
1,1733,235,20,236,
4,2,89,0,1,
58,1,1,2,0,
1,813,237,18,1,
813,117,2,0,1,
1731,238,18,1,1731,
235,2,0,1,1730,
239,18,1,1730,189,
2,0,1,1729,240,
18,1,1729,241,20,
242,4,8,114,0,
111,0,108,0,101,
0,1,160,1,2,
2,0,1,805,243,
18,1,805,244,20,
245,4,10,84,0,
73,0,77,0,69,
0,83,0,1,83,
1,1,2,0,1,
1723,246,18,1,1723,
232,2,0,1,1722,
247,18,1,1722,235,
2,0,1,802,248,
18,1,802,117,2,
0,1,1720,249,18,
1,1720,241,2,0,
1,1715,250,18,1,
1715,251,20,252,4,
2,88,0,1,57,
1,1,2,0,1,
794,253,18,1,794,
254,20,255,4,20,
70,0,79,0,76,
0,76,0,79,0,
87,0,69,0,68,
0,66,0,89,0,
1,84,1,1,2,
0,1,793,256,18,
1,793,257,20,258,
4,10,66,0,73,
0,78,0,79,0,
80,0,1,69,1,
1,2,0,1,792,
259,18,1,792,260,
20,261,4,10,77,
0,73,0,78,0,
85,0,83,0,1,
80,1,1,2,0,
1,791,262,18,1,
791,263,20,264,4,
8,68,0,65,0,
83,0,72,0,1,
81,1,1,2,0,
1,790,265,18,1,
790,266,20,267,4,
10,85,0,78,0,
79,0,80,0,50,
0,1,75,1,1,
2,0,1,787,268,
18,1,787,117,2,
0,1,949,269,18,
1,949,117,2,0,
1,987,270,18,1,
987,117,2,0,1,
779,271,18,1,779,
272,20,273,4,18,
99,0,111,0,109,
0,112,0,97,0,
114,0,101,0,114,
0,50,0,1,320,
1,2,2,0,1,
776,274,18,1,776,
189,2,0,1,775,
275,18,1,775,205,
2,0,1,774,276,
18,1,774,211,2,
0,1,1691,277,18,
1,1691,186,2,0,
1,771,278,18,1,
771,117,2,0,1,
1687,279,18,1,1687,
280,20,281,4,42,
111,0,114,0,79,
0,98,0,106,0,
101,0,99,0,116,
0,82,0,111,0,
108,0,101,0,69,
0,120,0,112,0,
114,0,67,0,104,
0,97,0,105,0,
110,0,1,140,1,
2,2,0,1,763,
282,18,1,763,161,
2,0,1,762,283,
18,1,762,117,2,
0,1,976,284,18,
1,976,285,20,286,
4,10,65,0,76,
0,80,0,72,0,
65,0,1,89,1,
1,2,0,1,1184,
287,18,1,1184,161,
2,0,1,754,288,
18,1,754,289,20,
290,4,10,98,0,
105,0,110,0,79,
0,112,0,1,349,
1,2,2,0,1,
751,291,18,1,751,
117,2,0,1,1668,
292,18,1,1668,293,
20,294,4,6,97,
0,65,0,110,0,
1,133,1,2,2,
0,1,1496,295,18,
1,1496,296,20,297,
4,26,99,0,108,
0,97,0,117,0,
115,0,101,0,95,
0,114,0,101,0,
115,0,117,0,108,
0,116,0,1,212,
1,2,2,0,1,
1565,298,18,1,1565,
241,2,0,1,1664,
299,18,1,1664,300,
20,301,4,14,105,
0,115,0,66,0,
101,0,65,0,114,
0,101,0,1,132,
1,2,2,0,1,
743,302,18,1,743,
303,20,304,4,10,
117,0,110,0,79,
0,112,0,50,0,
1,372,1,2,2,
0,1,736,305,18,
1,736,306,20,307,
4,14,83,0,69,
0,67,0,79,0,
78,0,68,0,83,
0,1,88,1,1,
2,0,1,735,308,
18,1,735,117,2,
0,1,1316,309,18,
1,1316,310,20,311,
4,22,73,0,83,
0,84,0,72,0,
69,0,83,0,65,
0,77,0,69,0,
65,0,83,0,1,
32,1,1,2,0,
1,727,312,18,1,
727,313,20,314,4,
14,77,0,73,0,
78,0,85,0,84,
0,69,0,83,0,
1,87,1,1,2,
0,1,726,315,18,
1,726,117,2,0,
1,1315,316,18,1,
1315,317,20,318,4,
14,111,0,98,0,
106,0,101,0,99,
0,116,0,114,0,
1,219,1,2,2,
0,1,1419,319,18,
1,1419,144,2,0,
1,1642,320,18,1,
1642,321,20,322,4,
26,73,0,70,0,
65,0,78,0,68,
0,79,0,78,0,
76,0,89,0,73,
0,70,0,73,0,
84,0,1,23,1,
1,2,0,1,1640,
323,18,1,1640,218,
2,0,1,1639,324,
18,1,1639,193,2,
0,1,718,325,18,
1,718,326,20,327,
4,10,72,0,79,
0,85,0,82,0,
83,0,1,86,1,
1,2,0,1,717,
328,18,1,717,117,
2,0,1,979,329,
18,1,979,161,2,
0,1,1636,330,18,
1,1636,331,20,332,
4,28,111,0,98,
0,106,0,101,0,
99,0,116,0,82,
0,111,0,108,0,
101,0,69,0,120,
0,112,0,114,0,
1,127,1,2,2,
0,1,1532,333,18,
1,1532,235,2,0,
1,709,334,18,1,
709,335,20,336,4,
8,68,0,65,0,
89,0,83,0,1,
85,1,1,2,0,
1,704,337,18,1,
704,306,2,0,1,
703,338,18,1,703,
117,2,0,1,1534,
339,18,1,1534,251,
2,0,1,1620,340,
18,1,1620,331,2,
0,1,1619,341,18,
1,1619,186,2,0,
1,1618,342,18,1,
1618,343,20,344,4,
30,79,0,82,0,
83,0,79,0,77,
0,69,0,84,0,
72,0,73,0,78,
0,71,0,69,0,
76,0,83,0,69,
0,1,26,1,1,
2,0,1,1617,345,
18,1,1617,331,2,
0,1,1039,346,18,
1,1039,347,20,348,
4,8,70,0,82,
0,79,0,77,0,
1,71,1,1,2,
0,1,695,349,18,
1,695,313,2,0,
1,694,350,18,1,
694,117,2,0,1,
1048,351,18,1,1048,
352,20,353,4,8,
87,0,73,0,84,
0,72,0,1,72,
1,1,2,0,1,
686,354,18,1,686,
326,2,0,1,1604,
355,18,1,1604,214,
2,0,1,683,356,
18,1,683,306,2,
0,1,682,357,18,
1,682,117,2,0,
1,1203,358,18,1,
1203,117,2,0,1,
1135,359,18,1,1135,
117,2,0,1,674,
360,18,1,674,313,
2,0,1,673,361,
18,1,673,306,2,
0,1,672,362,18,
1,672,117,2,0,
1,1473,363,18,1,
1473,107,2,0,1,
1588,364,18,1,1588,
365,20,366,4,12,
69,0,73,0,84,
0,72,0,69,0,
82,0,1,12,1,
1,2,0,1,1587,
367,18,1,1587,193,
2,0,1,1577,368,
18,1,1577,369,20,
370,4,14,68,0,
79,0,69,0,83,
0,78,0,79,0,
84,0,1,27,1,
1,2,0,1,1585,
371,18,1,1585,372,
20,373,4,16,65,
0,78,0,89,0,
84,0,72,0,73,
0,78,0,71,0,
1,25,1,1,2,
0,1,1584,374,18,
1,1584,186,2,0,
1,1583,375,18,1,
1583,226,2,0,1,
1582,376,18,1,1582,
186,2,0,1,1581,
377,18,1,1581,378,
20,379,4,26,110,
0,111,0,116,0,
82,0,111,0,108,
0,101,0,87,0,
105,0,116,0,104,
0,88,0,89,0,
1,162,1,2,2,
0,1,661,380,18,
1,661,129,2,0,
1,660,381,18,1,
660,132,2,0,1,
659,382,18,1,659,
135,2,0,1,658,
383,18,1,658,384,
20,385,4,10,86,
0,65,0,76,0,
85,0,69,0,1,
61,1,1,2,0,
1,657,386,18,1,
657,147,2,0,1,
656,387,18,1,656,
388,20,389,4,14,
100,0,97,0,116,
0,97,0,118,0,
97,0,108,0,1,
175,1,2,2,0,
1,655,390,18,1,
655,117,2,0,1,
1573,391,18,1,1573,
138,2,0,1,1572,
392,18,1,1572,369,
2,0,1,1571,393,
18,1,1571,235,2,
0,1,1570,394,18,
1,1570,110,2,0,
1,1569,395,18,1,
1569,235,2,0,1,
1568,396,18,1,1568,
186,2,0,1,1567,
397,18,1,1567,235,
2,0,1,647,398,
18,1,647,399,20,
400,4,10,67,0,
79,0,76,0,79,
0,78,0,1,82,
1,1,2,0,1,
646,401,18,1,646,
117,2,0,1,1564,
402,18,1,1564,186,
2,0,1,1563,403,
18,1,1563,235,2,
0,1,1562,404,18,
1,1562,189,2,0,
1,1561,405,18,1,
1561,241,2,0,1,
638,406,18,1,638,
399,2,0,1,637,
407,18,1,637,117,
2,0,1,1645,408,
18,1,1645,186,2,
0,1,1551,409,18,
1,1551,251,2,0,
1,1550,410,18,1,
1550,110,2,0,1,
1549,411,18,1,1549,
235,2,0,1,629,
412,18,1,629,413,
20,414,4,8,84,
0,73,0,77,0,
69,0,1,65,1,
1,2,0,1,628,
415,18,1,628,117,
2,0,1,1542,416,
18,1,1542,417,20,
418,4,8,84,0,
72,0,65,0,84,
0,1,45,1,1,
2,0,1,1541,419,
18,1,1541,420,20,
421,4,18,83,0,
79,0,77,0,69,
0,84,0,72,0,
73,0,78,0,71,
0,1,41,1,1,
2,0,1,1540,422,
18,1,1540,241,2,
0,1,620,423,18,
1,620,263,2,0,
1,619,424,18,1,
619,117,2,0,1,
1537,425,18,1,1537,
235,2,0,1,1536,
426,18,1,1536,138,
2,0,1,1535,427,
18,1,1535,251,2,
0,1,1530,428,18,
1,1530,235,2,0,
1,1533,429,18,1,
1533,138,2,0,1,
204,430,18,1,204,
218,2,0,1,969,
431,18,1,969,132,
2,0,1,611,432,
18,1,611,263,2,
0,1,610,433,18,
1,610,117,2,0,
1,1524,434,18,1,
1524,417,2,0,1,
1523,435,18,1,1523,
420,2,0,1,1233,
436,18,1,1233,437,
20,438,4,34,100,
0,97,0,116,0,
97,0,118,0,97,
0,108,0,101,0,
114,0,80,0,108,
0,117,0,115,0,
76,0,105,0,115,
0,116,0,1,247,
1,2,2,0,1,
602,439,18,1,602,
440,20,441,4,8,
68,0,65,0,84,
0,69,0,1,64,
1,1,2,0,1,
1744,442,18,1,1744,
186,2,0,1,1517,
443,18,1,1517,251,
2,0,1,1516,444,
18,1,1516,445,20,
446,4,18,99,0,
111,0,110,0,100,
0,105,0,116,0,
105,0,111,0,110,
0,1,203,1,2,
2,0,1,1514,447,
18,1,1514,186,2,
0,1,593,448,18,
1,593,449,20,450,
4,4,73,0,70,
0,1,34,1,1,
2,0,1,592,451,
18,1,592,186,2,
0,1,591,452,18,
1,591,453,20,454,
4,8,67,0,79,
0,68,0,69,0,
1,9,1,1,2,
0,1,1506,455,18,
1,1506,456,20,457,
4,18,109,0,111,
0,100,0,97,0,
108,0,105,0,116,
0,121,0,50,0,
1,270,1,2,2,
0,1,1505,458,18,
1,1505,459,20,460,
4,32,99,0,111,
0,110,0,100,0,
105,0,116,0,105,
0,111,0,110,0,
95,0,114,0,101,
0,115,0,117,0,
108,0,116,0,1,
213,1,2,2,0,
1,1504,461,18,1,
1504,186,2,0,1,
1503,462,18,1,1503,
459,2,0,1,1762,
463,18,1,1762,218,
2,0,1,582,464,
18,1,582,186,2,
0,1,579,465,18,
1,579,202,2,0,
1,1497,466,18,1,
1497,150,2,0,1,
577,467,18,1,577,
420,2,0,1,576,
468,18,1,576,205,
2,0,1,575,469,
18,1,575,138,2,
0,1,574,470,18,
1,574,471,20,472,
4,14,86,0,65,
0,76,0,85,0,
69,0,79,0,70,
0,1,62,1,1,
2,0,1,573,473,
18,1,573,420,2,
0,1,572,474,18,
1,572,420,2,0,
1,571,475,18,1,
571,189,2,0,1,
570,476,18,1,570,
241,2,0,1,1601,
477,18,1,1601,280,
2,0,1,565,478,
18,1,565,251,2,
0,1,564,479,18,
1,564,186,2,0,
1,563,480,18,1,
563,420,2,0,1,
562,481,18,1,562,
420,2,0,1,561,
482,18,1,561,189,
2,0,1,560,483,
18,1,560,241,2,
0,1,555,484,18,
1,555,138,2,0,
1,554,485,18,1,
554,300,2,0,1,
553,486,18,1,553,
251,2,0,1,552,
487,18,1,552,488,
20,489,4,16,97,
0,110,0,100,0,
67,0,111,0,109,
0,109,0,97,0,
1,196,1,2,2,
0,1,551,490,18,
1,551,150,2,0,
1,550,491,18,1,
550,492,20,493,4,
10,67,0,79,0,
77,0,77,0,65,
0,1,100,1,1,
2,0,1,549,494,
18,1,549,495,20,
496,4,30,97,0,
110,0,100,0,97,
0,110,0,121,0,
114,0,111,0,108,
0,101,0,99,0,
104,0,97,0,105,
0,110,0,1,141,
1,2,2,0,1,
548,497,18,1,548,
498,20,499,4,20,
73,0,83,0,85,
0,78,0,73,0,
81,0,85,0,69,
0,73,0,70,0,
1,21,1,1,2,
0,1,547,500,18,
1,547,331,2,0,
1,1464,501,18,1,
1464,138,2,0,1,
1458,502,18,1,1458,
205,2,0,1,1261,
503,18,1,1261,260,
2,0,1,1456,504,
18,1,1456,117,2,
0,1,534,505,18,
1,534,417,2,0,
1,533,506,18,1,
533,251,2,0,1,
532,507,18,1,532,
508,20,509,4,12,
115,0,105,0,110,
0,103,0,108,0,
101,0,1,163,1,
2,2,0,1,1446,
510,18,1,1446,189,
2,0,1,524,511,
18,1,524,512,20,
513,4,10,69,0,
86,0,69,0,82,
0,89,0,1,37,
1,1,2,0,1,
523,514,18,1,523,
515,20,516,4,8,
116,0,104,0,97,
0,116,0,1,169,
1,2,2,0,1,
1441,517,18,1,1441,
138,2,0,1,1418,
518,18,1,1418,512,
2,0,1,520,519,
18,1,520,520,20,
521,4,20,69,0,
86,0,69,0,82,
0,89,0,84,0,
72,0,73,0,78,
0,71,0,1,39,
1,1,2,0,1,
519,522,18,1,519,
123,2,0,1,518,
523,18,1,518,126,
2,0,1,517,524,
18,1,517,508,2,
0,1,1435,525,18,
1,1435,117,2,0,
1,1529,526,18,1,
1529,241,2,0,1,
1495,527,18,1,1495,
107,2,0,1,959,
528,18,1,959,147,
2,0,1,509,529,
18,1,509,147,2,
0,1,508,530,18,
1,508,508,2,0,
1,1425,531,18,1,
1425,347,2,0,1,
1424,532,18,1,1424,
129,2,0,1,1423,
533,18,1,1423,132,
2,0,1,1422,534,
18,1,1422,135,2,
0,1,1421,535,18,
1,1421,536,20,537,
4,24,118,0,97,
0,108,0,117,0,
101,0,79,0,114,
0,84,0,104,0,
105,0,110,0,103,
0,1,134,1,2,
2,0,1,1420,538,
18,1,1420,384,2,
0,1,500,539,18,
1,500,540,20,541,
4,26,84,0,72,
0,69,0,79,0,
78,0,69,0,65,
0,78,0,68,0,
79,0,78,0,76,
0,89,0,1,18,
1,1,2,0,1,
499,542,18,1,499,
508,2,0,1,1415,
543,18,1,1415,186,
2,0,1,1414,544,
18,1,1414,171,2,
0,1,1413,545,18,
1,1413,546,20,547,
4,14,69,0,88,
0,69,0,67,0,
85,0,84,0,69,
0,1,66,1,1,
2,0,1,1038,548,
18,1,1038,117,2,
0,1,1411,549,18,
1,1411,164,2,0,
1,481,550,18,1,
481,508,2,0,1,
1398,551,18,1,1398,
168,2,0,1,1397,
552,18,1,1397,553,
20,554,4,20,66,
0,69,0,84,0,
82,0,85,0,69,
0,84,0,72,0,
65,0,84,0,1,
92,1,1,2,0,
1,1396,555,18,1,
1396,556,20,557,4,
10,77,0,79,0,
68,0,65,0,76,
0,1,55,1,1,
2,0,1,1395,558,
18,1,1395,559,20,
560,4,4,73,0,
84,0,1,36,1,
1,2,0,1,1394,
561,18,1,1394,110,
2,0,1,1393,562,
18,1,1393,445,2,
0,1,467,563,18,
1,467,508,2,0,
1,1576,564,18,1,
1576,251,2,0,1,
463,565,18,1,463,
515,2,0,1,1457,
566,18,1,1457,107,
2,0,1,447,567,
18,1,447,129,2,
0,1,1358,568,18,
1,1358,150,2,0,
1,1357,569,18,1,
1357,570,20,571,4,
12,99,0,108,0,
97,0,117,0,115,
0,101,0,1,202,
1,2,2,0,1,
1356,572,18,1,1356,
573,20,574,4,12,
69,0,88,0,73,
0,83,0,84,0,
83,0,1,68,1,
1,2,0,1,1355,
575,18,1,1355,177,
2,0,1,1522,576,
18,1,1522,577,20,
578,4,10,99,0,
104,0,97,0,105,
0,110,0,1,139,
1,2,2,0,1,
1345,579,18,1,1345,
317,2,0,1,421,
580,18,1,421,177,
2,0,1,420,581,
18,1,420,582,20,
583,4,28,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,82,0,101,
0,108,0,97,0,
116,0,101,0,100,
0,1,145,1,2,
2,0,1,1336,584,
18,1,1336,585,20,
586,4,4,66,0,
89,0,1,53,1,
1,2,0,1,1332,
587,18,1,1332,138,
2,0,1,1030,588,
18,1,1030,589,20,
590,4,36,84,0,
82,0,65,0,78,
0,83,0,76,0,
65,0,84,0,69,
0,68,0,82,0,
69,0,80,0,76,
0,65,0,67,0,
69,0,68,0,1,
76,1,1,2,0,
1,1326,591,18,1,
1326,205,2,0,1,
1325,592,18,1,1325,
317,2,0,1,405,
593,18,1,405,515,
2,0,1,1176,594,
18,1,1176,117,2,
0,1,402,595,18,
1,402,138,2,0,
1,401,596,18,1,
401,515,2,0,1,
400,597,18,1,400,
205,2,0,1,399,
598,18,1,399,599,
20,600,4,4,66,
0,69,0,1,56,
1,1,2,0,1,
398,601,18,1,398,
369,2,0,1,397,
602,18,1,397,603,
20,604,4,10,68,
0,79,0,78,0,
79,0,84,0,1,
28,1,1,2,0,
1,396,605,18,1,
396,606,20,607,4,
10,73,0,83,0,
78,0,79,0,84,
0,1,29,1,1,
2,0,1,395,608,
18,1,395,609,20,
610,4,10,66,0,
69,0,78,0,79,
0,84,0,1,30,
1,1,2,0,1,
394,611,18,1,394,
612,20,613,4,12,
65,0,82,0,69,
0,78,0,79,0,
84,0,1,31,1,
1,2,0,1,393,
614,18,1,393,138,
2,0,1,391,615,
18,1,391,177,2,
0,1,390,616,18,
1,390,582,2,0,
1,389,617,18,1,
389,515,2,0,1,
1306,618,18,1,1306,
619,20,620,4,28,
73,0,83,0,78,
0,79,0,84,0,
84,0,72,0,69,
0,83,0,65,0,
77,0,69,0,65,
0,83,0,1,33,
1,1,2,0,1,
1305,621,18,1,1305,
317,2,0,1,1490,
622,18,1,1490,310,
2,0,1,1291,623,
18,1,1291,129,2,
0,1,1290,624,18,
1,1290,132,2,0,
1,1289,625,18,1,
1289,135,2,0,1,
1288,626,18,1,1288,
384,2,0,1,1287,
627,18,1,1287,147,
2,0,1,1278,628,
18,1,1278,189,2,
0,1,1273,629,18,
1,1273,202,2,0,
1,1271,630,18,1,
1271,138,2,0,1,
1270,631,18,1,1270,
317,2,0,1,1269,
632,18,1,1269,633,
20,634,4,14,98,
0,117,0,105,0,
108,0,116,0,105,
0,110,0,1,234,
1,2,2,0,1,
349,635,18,1,349,
135,2,0,1,346,
636,18,1,346,241,
2,0,1,344,637,
18,1,344,177,2,
0,1,342,638,18,
1,342,177,2,0,
1,1260,639,18,1,
1260,263,2,0,1,
1259,640,18,1,1259,
641,20,642,4,8,
85,0,78,0,79,
0,80,0,1,74,
1,1,2,0,1,
1258,643,18,1,1258,
644,20,645,4,6,
78,0,79,0,84,
0,1,48,1,1,
2,0,1,1253,646,
18,1,1253,117,2,
0,1,327,647,18,
1,327,644,2,0,
1,1245,648,18,1,
1245,229,2,0,1,
1674,649,18,1,1674,
650,20,651,4,38,
73,0,70,0,65,
0,78,0,68,0,
79,0,78,0,76,
0,89,0,73,0,
70,0,73,0,84,
0,69,0,73,0,
84,0,72,0,69,
0,82,0,1,24,
1,1,2,0,1,
1512,652,18,1,1512,
296,2,0,1,1242,
653,18,1,1242,117,
2,0,1,318,654,
18,1,318,585,2,
0,1,1234,655,18,
1,1234,161,2,0,
1,314,656,18,1,
314,138,2,0,1,
1228,657,18,1,1228,
117,2,0,1,308,
658,18,1,308,300,
2,0,1,306,659,
18,1,306,177,2,
0,1,975,660,18,
1,975,147,2,0,
1,305,661,18,1,
305,582,2,0,1,
1220,662,18,1,1220,
244,2,0,1,300,
663,18,1,300,508,
2,0,1,299,664,
18,1,299,665,20,
666,4,14,78,0,
79,0,84,0,72,
0,73,0,78,0,
71,0,1,40,1,
1,2,0,1,298,
667,18,1,298,515,
2,0,1,1539,668,
18,1,1539,186,2,
0,1,295,669,18,
1,295,420,2,0,
1,294,670,18,1,
294,671,20,672,4,
16,105,0,110,0,
115,0,116,0,97,
0,110,0,99,0,
101,0,1,135,1,
2,2,0,1,293,
673,18,1,293,674,
20,675,4,8,78,
0,79,0,78,0,
69,0,1,42,1,
1,2,0,1,292,
676,18,1,292,677,
20,678,4,12,73,
0,84,0,83,0,
69,0,76,0,70,
0,1,54,1,1,
2,0,1,1538,679,
18,1,1538,226,2,
0,1,1209,680,18,
1,1209,161,2,0,
1,1208,681,18,1,
1208,682,20,683,4,
36,100,0,97,0,
116,0,97,0,118,
0,97,0,108,0,
101,0,114,0,84,
0,105,0,109,0,
101,0,115,0,76,
0,105,0,115,0,
116,0,1,248,1,
2,2,0,1,1548,
684,18,1,1548,189,
2,0,1,286,685,
18,1,286,508,2,
0,1,285,686,18,
1,285,671,2,0,
1,284,687,18,1,
284,515,2,0,1,
281,688,18,1,281,
420,2,0,1,1195,
689,18,1,1195,254,
2,0,1,1192,690,
18,1,1192,117,2,
0,1,1440,691,18,
1,1440,107,2,0,
1,1566,692,18,1,
1566,189,2,0,1,
1670,693,18,1,1670,
138,2,0,1,265,
694,18,1,265,202,
2,0,1,1183,695,
18,1,1183,696,20,
697,4,46,100,0,
97,0,116,0,97,
0,118,0,97,0,
108,0,101,0,114,
0,70,0,111,0,
108,0,108,0,111,
0,119,0,101,0,
100,0,66,0,121,
0,76,0,105,0,
115,0,116,0,1,
249,1,2,2,0,
1,263,698,18,1,
263,699,20,700,4,
20,78,0,79,0,
84,0,72,0,73,
0,78,0,71,0,
66,0,85,0,84,
0,1,20,1,1,
2,0,1,262,701,
18,1,262,702,20,
703,4,4,65,0,
78,0,1,47,1,
1,2,0,1,257,
704,18,1,257,508,
2,0,1,256,705,
18,1,256,671,2,
0,1,1556,706,18,
1,1556,369,2,0,
1,252,707,18,1,
252,293,2,0,1,
1168,708,18,1,1168,
161,2,0,1,1167,
709,18,1,1167,117,
2,0,1,978,710,
18,1,978,317,2,
0,1,1489,711,18,
1,1489,107,2,0,
1,1159,712,18,1,
1159,713,20,714,4,
8,117,0,110,0,
79,0,112,0,1,
359,1,2,2,0,
1,239,715,18,1,
239,202,2,0,1,
237,716,18,1,237,
717,20,718,4,22,
119,0,111,0,114,
0,100,0,95,0,
110,0,117,0,109,
0,98,0,101,0,
114,0,1,174,1,
2,2,0,1,236,
719,18,1,236,720,
20,721,4,14,87,
0,79,0,82,0,
68,0,78,0,85,
0,77,0,1,59,
1,1,2,0,1,
235,722,18,1,235,
132,2,0,1,234,
723,18,1,234,724,
20,725,4,16,99,
0,111,0,109,0,
112,0,97,0,114,
0,101,0,114,0,
1,173,1,2,2,
0,1,233,726,18,
1,233,515,2,0,
1,1150,727,18,1,
1150,117,2,0,1,
230,728,18,1,230,
138,2,0,1,229,
729,18,1,229,515,
2,0,1,226,730,
18,1,226,144,2,
0,1,1142,731,18,
1,1142,161,2,0,
1,1574,732,18,1,
1574,251,2,0,1,
964,733,18,1,964,
135,2,0,1,1732,
734,18,1,1732,186,
2,0,1,1724,735,
18,1,1724,251,2,
0,1,211,736,18,
1,211,138,2,0,
1,210,737,18,1,
210,738,20,739,4,
14,100,0,111,0,
101,0,115,0,78,
0,111,0,116,0,
1,199,1,2,2,
0,1,208,740,18,
1,208,331,2,0,
1,1126,741,18,1,
1126,117,2,0,1,
206,742,18,1,206,
743,20,744,4,14,
97,0,110,0,100,
0,108,0,111,0,
111,0,112,0,1,
171,1,2,2,0,
1,920,745,18,1,
920,107,2,0,1,
203,746,18,1,203,
417,2,0,1,201,
747,18,1,201,144,
2,0,1,200,748,
18,1,200,293,2,
0,1,1118,749,18,
1,1118,750,20,751,
4,26,84,0,72,
0,65,0,84,0,
72,0,65,0,83,
0,76,0,69,0,
78,0,71,0,84,
0,72,0,1,17,
1,1,2,0,1,
1117,752,18,1,1117,
117,2,0,1,197,
753,18,1,197,754,
20,755,4,16,67,
0,79,0,77,0,
80,0,65,0,82,
0,69,0,82,0,
1,11,1,1,2,
0,1,1586,756,18,
1,1586,556,2,0,
1,1127,757,18,1,
1127,161,2,0,1,
1109,758,18,1,1109,
347,2,0,1,937,
759,18,1,937,117,
2,0,1,1102,760,
18,1,1102,117,2,
0,1,182,761,18,
1,182,123,2,0,
1,181,762,18,1,
181,126,2,0,1,
1094,763,18,1,1094,
161,2,0,1,1093,
764,18,1,1093,117,
2,0,1,955,765,
18,1,955,766,20,
767,4,28,110,0,
111,0,116,0,105,
0,100,0,101,0,
110,0,116,0,111,
0,98,0,106,0,
101,0,99,0,116,
0,1,222,1,2,
2,0,1,167,768,
18,1,167,365,2,
0,1,1085,769,18,
1,1085,770,20,771,
4,24,83,0,85,
0,66,0,83,0,
84,0,82,0,73,
0,78,0,71,0,
70,0,73,0,88,
0,1,73,1,1,
2,0,1,1084,772,
18,1,1084,117,2,
0,1,966,773,18,
1,966,129,2,0,
1,162,774,18,1,
162,135,2,0,1,
159,775,18,1,159,
202,2,0,1,1076,
776,18,1,1076,777,
20,778,4,18,83,
0,85,0,66,0,
83,0,84,0,82,
0,73,0,78,0,
71,0,1,70,1,
1,2,0,1,1579,
779,18,1,1579,235,
2,0,1,1484,780,
18,1,1484,619,2,
0,1,1065,781,18,
1,1065,117,2,0,
1,1057,782,18,1,
1057,161,2,0,1,
1056,783,18,1,1056,
117,2,0,1,130,
784,18,1,130,785,
20,786,4,10,102,
0,97,0,99,0,
101,0,116,0,1,
182,1,2,2,0,
1,129,787,18,1,
129,388,2,0,1,
1047,788,18,1,1047,
117,2,0,1,1468,
789,18,1,1468,585,
2,0,1,121,790,
18,1,121,183,2,
0,1,120,791,18,
1,120,171,2,0,
1,119,792,18,1,
119,793,20,794,4,
14,77,0,65,0,
84,0,67,0,72,
0,69,0,83,0,
1,16,1,1,2,
0,1,118,795,18,
1,118,132,2,0,
1,117,796,18,1,
117,132,2,0,1,
116,797,18,1,116,
183,2,0,1,115,
798,18,1,115,750,
2,0,1,114,799,
18,1,114,785,2,
0,1,113,800,18,
1,113,492,2,0,
1,112,801,18,1,
112,802,20,803,4,
18,102,0,97,0,
99,0,101,0,116,
0,76,0,105,0,
115,0,116,0,1,
183,1,2,2,0,
1,111,804,18,1,
111,388,2,0,1,
1217,805,18,1,1217,
117,2,0,1,1025,
806,18,1,1025,117,
2,0,1,103,807,
18,1,103,189,2,
0,1,102,808,18,
1,102,388,2,0,
1,919,809,18,1,
919,117,2,0,1,
1017,810,18,1,1017,
161,2,0,1,1016,
811,18,1,1016,812,
20,813,4,16,100,
0,117,0,114,0,
97,0,116,0,105,
0,111,0,110,0,
1,250,1,2,2,
0,1,94,814,18,
1,94,199,2,0,
1,1637,815,18,1,
1637,420,2,0,1,
1011,816,18,1,1011,
117,2,0,1,1547,
817,18,1,1547,241,
2,0,1,1003,818,
18,1,1003,161,2,
0,1,1002,819,18,
1,1002,820,20,821,
4,16,100,0,97,
0,116,0,101,0,
116,0,105,0,109,
0,101,0,1,388,
1,2,2,0,1,
1643,822,18,1,1643,
218,2,0,1,77,
823,18,1,77,388,
2,0,1,76,824,
18,1,76,214,2,
0,1,75,825,18,
1,75,388,2,0,
1,72,826,18,1,
72,129,2,0,1,
71,827,18,1,71,
132,2,0,1,70,
828,18,1,70,829,
20,830,4,6,78,
0,85,0,77,0,
1,6,1,1,2,
0,1,69,831,18,
1,69,171,2,0,
1,68,832,18,1,
68,833,20,834,4,
6,68,0,84,0,
77,0,1,95,1,
1,2,0,1,67,
835,18,1,67,836,
20,837,4,6,68,
0,85,0,82,0,
1,96,1,1,2,
0,1,66,838,18,
1,66,839,20,840,
4,6,68,0,66,
0,76,0,1,7,
1,1,2,0,1,
65,841,18,1,65,
842,20,843,4,6,
66,0,79,0,76,
0,1,8,1,1,
2,0,1,64,844,
18,1,64,388,2,
0,1,63,845,18,
1,63,214,2,0,
1,62,846,18,1,
62,847,20,848,4,
22,100,0,97,0,
116,0,97,0,118,
0,97,0,108,0,
76,0,105,0,115,
0,116,0,1,187,
1,2,2,0,1,
61,849,18,1,61,
365,2,0,1,60,
850,18,1,60,129,
2,0,1,59,851,
18,1,59,384,2,
0,1,58,852,18,
1,58,129,2,0,
1,57,853,18,1,
57,384,2,0,1,
56,854,18,1,56,
855,20,856,4,24,
68,0,65,0,84,
0,65,0,84,0,
89,0,80,0,69,
0,78,0,65,0,
77,0,69,0,1,
63,1,1,2,0,
1,55,857,18,1,
55,129,2,0,1,
54,858,18,1,54,
384,2,0,1,53,
859,18,1,53,138,
2,0,1,52,860,
18,1,52,861,20,
862,4,8,83,0,
79,0,77,0,69,
0,1,60,1,1,
2,0,1,970,863,
18,1,970,129,2,
0,1,50,864,18,
1,50,129,2,0,
1,968,865,18,1,
968,135,2,0,1,
967,866,18,1,967,
138,2,0,1,47,
867,18,1,47,202,
2,0,1,965,868,
18,1,965,132,2,
0,1,45,869,18,
1,45,135,2,0,
1,963,870,18,1,
963,144,2,0,1,
962,871,18,1,962,
293,2,0,1,42,
872,18,1,42,202,
2,0,1,40,873,
18,1,40,874,20,
875,4,16,65,0,
83,0,87,0,69,
0,76,0,76,0,
65,0,83,0,1,
52,1,1,2,0,
1,38,876,18,1,
38,202,2,0,1,
36,877,18,1,36,
878,20,879,4,4,
79,0,82,0,1,
50,1,1,2,0,
1,35,880,18,1,
35,202,2,0,1,
34,881,18,1,34,
644,2,0,1,33,
882,18,1,33,585,
2,0,1,32,883,
18,1,32,138,2,
0,1,31,884,18,
1,31,885,20,886,
4,18,100,0,111,
0,101,0,115,0,
78,0,111,0,116,
0,66,0,121,0,
1,200,1,2,2,
0,1,30,887,18,
1,30,331,2,0,
1,29,888,18,1,
29,150,2,0,1,
28,889,18,1,28,
743,2,0,1,27,
890,18,1,27,891,
20,892,4,10,65,
0,78,0,68,0,
79,0,82,0,1,
51,1,1,2,0,
1,26,893,18,1,
26,218,2,0,1,
25,894,18,1,25,
417,2,0,1,24,
895,18,1,24,135,
2,0,1,23,896,
18,1,23,897,20,
898,4,12,84,0,
72,0,73,0,78,
0,71,0,83,0,
1,44,1,1,2,
0,1,941,899,18,
1,941,161,2,0,
1,940,900,18,1,
940,317,2,0,1,
20,901,18,1,20,
147,2,0,1,938,
902,18,1,938,347,
2,0,1,18,903,
18,1,18,671,2,
0,1,17,904,18,
1,17,214,2,0,
1,16,905,18,1,
16,671,2,0,1,
15,906,18,1,15,
878,2,0,1,14,
907,18,1,14,492,
2,0,1,12,908,
18,1,12,909,20,
910,4,24,105,0,
110,0,115,0,116,
0,97,0,110,0,
99,0,101,0,76,
0,105,0,115,0,
116,0,1,138,1,
2,2,0,1,11,
911,18,1,11,365,
2,0,1,929,912,
18,1,929,117,2,
0,1,9,913,18,
1,9,540,2,0,
1,8,914,18,1,
8,671,2,0,1,
7,915,18,1,7,
214,2,0,1,6,
916,18,1,6,129,
2,0,1,5,917,
18,1,5,909,2,
0,1,4,918,18,
1,4,365,2,0,
1,3,919,18,1,
3,135,2,0,1,
2,920,18,1,2,
921,20,922,4,4,
78,0,79,0,1,
38,1,1,2,0,
1,1,923,18,1,
1,665,2,0,1,
0,924,18,1,0,
0,2,0,925,5,
0,926,5,535,1,
538,927,19,928,4,
80,111,0,114,0,
67,0,111,0,109,
0,109,0,97,0,
95,0,99,0,56,
0,54,0,56,0,
98,0,54,0,101,
0,49,0,54,0,
52,0,52,0,101,
0,52,0,54,0,
100,0,100,0,56,
0,98,0,56,0,
50,0,51,0,48,
0,48,0,53,0,
98,0,54,0,57,
0,99,0,51,0,
54,0,102,0,54,
0,1,538,929,5,
8,1,16,930,16,
0,904,1,5,931,
16,0,915,1,12,
932,16,0,915,1,
62,933,16,0,845,
1,75,934,16,0,
824,1,1620,935,16,
0,213,1,1687,936,
16,0,355,1,1601,
937,16,0,355,1,
537,938,19,939,4,
80,111,0,114,0,
67,0,111,0,109,
0,109,0,97,0,
95,0,100,0,101,
0,54,0,102,0,
50,0,100,0,100,
0,97,0,49,0,
98,0,51,0,48,
0,52,0,57,0,
56,0,99,0,57,
0,99,0,50,0,
99,0,53,0,100,
0,52,0,101,0,
48,0,56,0,100,
0,99,0,98,0,
99,0,48,0,50,
0,1,537,929,1,
536,940,19,941,4,
72,97,0,65,0,
110,0,95,0,52,
0,100,0,97,0,
55,0,97,0,53,
0,50,0,48,0,
49,0,101,0,50,
0,98,0,52,0,
53,0,51,0,99,
0,97,0,98,0,
49,0,98,0,98,
0,57,0,57,0,
50,0,97,0,99,
0,57,0,57,0,
50,0,57,0,52,
0,102,0,1,536,
942,5,24,1,1664,
943,16,0,292,1,
33,944,16,0,748,
1,1326,945,16,0,
748,1,9,946,16,
0,707,1,509,947,
16,0,707,1,1358,
948,16,0,871,1,
211,949,16,0,748,
1,938,950,16,0,
871,1,1316,951,16,
0,871,1,20,952,
16,0,707,1,500,
953,16,0,707,1,
263,954,16,0,707,
1,1458,955,16,0,
748,1,976,956,16,
0,871,1,1271,957,
16,0,871,1,308,
958,16,0,748,1,
1306,959,16,0,871,
1,327,960,16,0,
748,1,237,961,16,
0,707,1,524,962,
16,0,707,1,1336,
963,16,0,871,1,
346,964,16,0,748,
1,2,965,16,0,
707,1,593,966,16,
0,871,1,535,967,
19,968,4,84,100,
0,111,0,101,0,
115,0,78,0,111,
0,116,0,66,0,
121,0,95,0,101,
0,102,0,100,0,
99,0,55,0,55,
0,51,0,98,0,
101,0,57,0,53,
0,100,0,52,0,
101,0,98,0,56,
0,57,0,100,0,
99,0,57,0,54,
0,101,0,50,0,
50,0,50,0,56,
0,98,0,51,0,
57,0,102,0,55,
0,99,0,1,535,
969,5,13,1,1588,
970,16,0,884,1,
1623,971,16,0,884,
1,29,972,16,0,
884,1,27,973,16,
0,884,1,25,974,
16,0,884,1,1761,
975,16,0,884,1,
203,976,16,0,884,
1,534,977,16,0,
884,1,1642,978,16,
0,884,1,1604,979,
16,0,884,1,1639,
980,16,0,884,1,
1674,981,16,0,884,
1,1741,982,16,0,
884,1,534,983,19,
984,4,84,100,0,
111,0,101,0,115,
0,78,0,111,0,
116,0,66,0,121,
0,95,0,57,0,
57,0,54,0,49,
0,53,0,54,0,
97,0,51,0,51,
0,55,0,56,0,
48,0,52,0,48,
0,56,0,57,0,
98,0,99,0,49,
0,49,0,98,0,
50,0,55,0,100,
0,50,0,97,0,
101,0,53,0,52,
0,49,0,100,0,
101,0,1,534,969,
1,533,985,19,986,
4,84,100,0,111,
0,101,0,115,0,
78,0,111,0,116,
0,66,0,121,0,
95,0,56,0,53,
0,98,0,101,0,
97,0,57,0,57,
0,97,0,98,0,
50,0,54,0,102,
0,52,0,97,0,
99,0,97,0,57,
0,50,0,53,0,
48,0,101,0,56,
0,55,0,57,0,
98,0,99,0,98,
0,56,0,102,0,
53,0,54,0,100,
0,1,533,969,1,
532,987,19,988,4,
80,100,0,111,0,
101,0,115,0,78,
0,111,0,116,0,
95,0,102,0,102,
0,100,0,49,0,
57,0,48,0,50,
0,49,0,99,0,
97,0,57,0,98,
0,52,0,50,0,
100,0,49,0,56,
0,53,0,100,0,
49,0,53,0,48,
0,57,0,55,0,
52,0,102,0,99,
0,102,0,51,0,
56,0,102,0,99,
0,1,532,989,5,
13,1,1588,990,16,
0,737,1,1623,991,
16,0,737,1,29,
992,16,0,737,1,
27,993,16,0,737,
1,25,994,16,0,
737,1,1761,995,16,
0,737,1,203,996,
16,0,737,1,534,
997,16,0,737,1,
1642,998,16,0,737,
1,1604,999,16,0,
737,1,1639,1000,16,
0,737,1,1674,1001,
16,0,737,1,1741,
1002,16,0,737,1,
531,1003,19,1004,4,
80,100,0,111,0,
101,0,115,0,78,
0,111,0,116,0,
95,0,97,0,51,
0,102,0,54,0,
52,0,55,0,50,
0,56,0,51,0,
53,0,52,0,53,
0,52,0,99,0,
101,0,57,0,56,
0,56,0,50,0,
48,0,102,0,53,
0,51,0,52,0,
48,0,50,0,55,
0,57,0,101,0,
102,0,100,0,54,
0,1,531,989,1,
530,1005,19,1006,4,
80,105,0,115,0,
66,0,101,0,65,
0,114,0,101,0,
95,0,53,0,99,
0,49,0,52,0,
101,0,48,0,53,
0,57,0,100,0,
98,0,55,0,49,
0,52,0,100,0,
98,0,53,0,56,
0,53,0,100,0,
49,0,98,0,53,
0,102,0,50,0,
100,0,52,0,102,
0,102,0,54,0,
52,0,50,0,100,
0,1,530,1007,5,
22,1,553,1008,16,
0,485,1,1551,1009,
16,0,485,1,1715,
1010,16,0,485,1,
1623,1011,16,0,658,
1,25,1012,16,0,
658,1,29,1013,16,
0,658,1,27,1014,
16,0,658,1,1724,
1015,16,0,485,1,
1542,1016,16,0,485,
1,1761,1017,16,0,
658,1,1556,1018,16,
0,485,1,203,1019,
16,0,658,1,534,
1020,16,0,658,1,
1642,1021,16,0,658,
1,1604,1022,16,0,
658,1,1639,1023,16,
0,299,1,565,1024,
16,0,485,1,1674,
1025,16,0,658,1,
1524,1026,16,0,485,
1,1588,1027,16,0,
658,1,1741,1028,16,
0,658,1,1517,1029,
16,0,485,1,529,
1030,19,1031,4,80,
105,0,115,0,66,
0,101,0,65,0,
114,0,101,0,95,
0,99,0,48,0,
55,0,52,0,102,
0,51,0,53,0,
52,0,55,0,101,
0,50,0,54,0,
52,0,50,0,98,
0,97,0,97,0,
101,0,52,0,100,
0,101,0,101,0,
56,0,100,0,54,
0,49,0,51,0,
101,0,56,0,52,
0,48,0,57,0,
1,529,1007,1,528,
1032,19,1033,4,82,
97,0,110,0,100,
0,67,0,111,0,
109,0,109,0,97,
0,95,0,55,0,
97,0,49,0,49,
0,52,0,48,0,
98,0,100,0,48,
0,102,0,98,0,
97,0,52,0,97,
0,48,0,52,0,
98,0,100,0,99,
0,102,0,51,0,
52,0,50,0,98,
0,97,0,54,0,
101,0,55,0,97,
0,49,0,54,0,
100,0,1,528,1034,
5,1,1,549,1035,
16,0,487,1,527,
1036,19,1037,4,82,
97,0,110,0,100,
0,67,0,111,0,
109,0,109,0,97,
0,95,0,101,0,
53,0,102,0,51,
0,55,0,101,0,
98,0,101,0,53,
0,57,0,53,0,
56,0,52,0,98,
0,97,0,50,0,
56,0,54,0,56,
0,101,0,97,0,
53,0,48,0,57,
0,102,0,101,0,
53,0,52,0,98,
0,98,0,55,0,
55,0,1,527,1034,
1,526,1038,19,1039,
4,88,100,0,97,
0,116,0,97,0,
118,0,97,0,108,
0,76,0,105,0,
115,0,116,0,95,
0,98,0,98,0,
97,0,98,0,54,
0,51,0,57,0,
101,0,97,0,98,
0,53,0,49,0,
52,0,52,0,54,
0,52,0,97,0,
54,0,48,0,54,
0,102,0,99,0,
50,0,55,0,100,
0,50,0,98,0,
53,0,56,0,99,
0,102,0,98,0,
1,526,1040,5,2,
1,167,1041,16,0,
846,1,61,1042,16,
0,846,1,525,1043,
19,1044,4,88,100,
0,97,0,116,0,
97,0,118,0,97,
0,108,0,76,0,
105,0,115,0,116,
0,95,0,56,0,
99,0,56,0,97,
0,54,0,98,0,
51,0,57,0,97,
0,102,0,56,0,
55,0,52,0,101,
0,97,0,49,0,
56,0,50,0,99,
0,54,0,52,0,
97,0,56,0,100,
0,55,0,52,0,
53,0,49,0,57,
0,55,0,98,0,
99,0,1,525,1040,
1,524,1045,19,1046,
4,74,66,0,111,
0,111,0,108,0,
95,0,55,0,98,
0,100,0,55,0,
50,0,56,0,52,
0,54,0,51,0,
97,0,51,0,54,
0,52,0,56,0,
102,0,52,0,56,
0,50,0,49,0,
100,0,99,0,99,
0,49,0,100,0,
102,0,56,0,56,
0,48,0,55,0,
52,0,97,0,101,
0,1,524,1047,5,
63,1,629,1048,16,
0,387,1,727,1049,
16,0,387,1,709,
1050,16,0,387,1,
1220,1051,16,0,387,
1,794,1052,16,0,
387,1,1245,1053,16,
0,387,1,167,1054,
16,0,825,1,611,
1055,16,0,387,1,
877,1056,16,0,387,
1,779,1057,16,0,
387,1,1142,1058,16,
0,387,1,1398,1059,
16,0,387,1,695,
1060,16,0,387,1,
1048,1061,16,0,387,
1,602,1062,16,0,
387,1,868,1063,16,
0,387,1,1030,1064,
16,0,387,1,1118,
1065,16,0,387,1,
686,1066,16,0,387,
1,61,1067,16,0,
825,1,1039,1068,16,
0,387,1,593,1069,
16,0,387,1,979,
1070,16,0,387,1,
103,1071,16,0,804,
1,941,1072,16,0,
387,1,1209,1073,16,
0,387,1,674,1074,
16,0,387,1,620,
1075,16,0,387,1,
1094,1076,16,0,387,
1,1195,1077,16,0,
387,1,844,1078,16,
0,804,1,754,1079,
16,0,387,1,1109,
1080,16,0,387,1,
1003,1081,16,0,387,
1,929,1082,16,0,
387,1,638,1083,16,
0,387,1,921,1084,
16,0,387,1,1017,
1085,16,0,387,1,
835,1086,16,0,808,
1,1278,1087,16,0,
804,1,743,1088,16,
0,387,1,63,1089,
16,0,844,1,76,
1090,16,0,823,1,
1184,1091,16,0,387,
1,763,1092,16,0,
387,1,647,1093,16,
0,387,1,1358,1094,
16,0,387,1,1446,
1095,16,0,387,1,
857,1096,16,0,787,
1,1085,1097,16,0,
387,1,816,1098,16,
0,387,1,1127,1099,
16,0,387,1,1168,
1100,16,0,387,1,
121,1101,16,0,787,
1,1076,1102,16,0,
387,1,1234,1103,16,
0,387,1,718,1104,
16,0,387,1,94,
1105,16,0,808,1,
805,1106,16,0,387,
1,1057,1107,16,0,
387,1,1159,1108,16,
0,387,1,1425,1109,
16,0,387,1,890,
1110,16,0,387,1,
523,1111,19,1112,4,
76,70,0,108,0,
111,0,97,0,116,
0,95,0,57,0,
97,0,54,0,100,
0,50,0,101,0,
97,0,48,0,54,
0,52,0,102,0,
98,0,52,0,97,
0,102,0,102,0,
97,0,53,0,57,
0,51,0,54,0,
57,0,48,0,100,
0,98,0,56,0,
51,0,54,0,50,
0,56,0,49,0,
98,0,1,523,1047,
1,522,1113,19,1114,
4,82,68,0,117,
0,114,0,97,0,
116,0,105,0,111,
0,110,0,95,0,
57,0,101,0,52,
0,53,0,102,0,
54,0,56,0,51,
0,101,0,56,0,
57,0,55,0,52,
0,101,0,49,0,
50,0,56,0,49,
0,98,0,102,0,
101,0,49,0,48,
0,54,0,51,0,
50,0,51,0,100,
0,48,0,98,0,
52,0,51,0,1,
522,1047,1,521,1115,
19,1116,4,90,68,
0,97,0,116,0,
101,0,84,0,105,
0,109,0,101,0,
68,0,97,0,116,
0,97,0,95,0,
50,0,99,0,99,
0,101,0,54,0,
57,0,50,0,98,
0,97,0,48,0,
97,0,53,0,52,
0,56,0,56,0,
99,0,57,0,98,
0,55,0,57,0,
57,0,50,0,48,
0,100,0,50,0,
101,0,57,0,56,
0,53,0,101,0,
97,0,102,0,1,
521,1047,1,520,1117,
19,1118,4,80,83,
0,116,0,114,0,
68,0,97,0,116,
0,97,0,95,0,
99,0,102,0,97,
0,100,0,55,0,
51,0,50,0,55,
0,56,0,56,0,
48,0,53,0,52,
0,54,0,48,0,
50,0,56,0,49,
0,53,0,53,0,
55,0,51,0,48,
0,49,0,50,0,
52,0,98,0,55,
0,97,0,57,0,
99,0,50,0,1,
520,1047,1,519,1119,
19,1120,4,78,78,
0,117,0,109,0,
98,0,101,0,114,
0,95,0,57,0,
48,0,53,0,102,
0,98,0,48,0,
54,0,56,0,102,
0,102,0,56,0,
99,0,52,0,53,
0,48,0,48,0,
97,0,50,0,48,
0,48,0,99,0,
98,0,55,0,100,
0,55,0,55,0,
99,0,51,0,55,
0,55,0,97,0,
48,0,1,519,1047,
1,518,1121,19,1122,
4,78,78,0,117,
0,109,0,98,0,
101,0,114,0,95,
0,54,0,57,0,
53,0,102,0,48,
0,102,0,97,0,
48,0,99,0,55,
0,102,0,55,0,
52,0,57,0,101,
0,101,0,57,0,
54,0,49,0,56,
0,51,0,57,0,
56,0,98,0,57,
0,55,0,102,0,
57,0,57,0,100,
0,99,0,57,0,
1,518,1047,1,517,
1123,19,1124,4,82,
98,0,111,0,117,
0,110,0,100,0,
78,0,111,0,116,
0,95,0,52,0,
53,0,50,0,53,
0,57,0,99,0,
100,0,98,0,53,
0,99,0,99,0,
54,0,52,0,52,
0,52,0,54,0,
97,0,98,0,49,
0,55,0,54,0,
54,0,49,0,48,
0,57,0,102,0,
102,0,55,0,56,
0,102,0,100,0,
102,0,1,517,1125,
5,14,1,36,1126,
16,0,876,1,34,
1127,16,0,880,1,
33,1128,16,0,775,
1,211,1129,16,0,
775,1,577,1130,16,
0,465,1,349,1131,
16,0,867,1,237,
1132,16,0,715,1,
162,1133,16,0,867,
1,1271,1134,16,0,
629,1,40,1135,16,
0,872,1,45,1136,
16,0,867,1,263,
1137,16,0,694,1,
346,1138,16,0,775,
1,829,1139,16,0,
201,1,516,1140,19,
1141,4,80,98,0,
111,0,117,0,110,
0,100,0,79,0,
114,0,95,0,49,
0,55,0,53,0,
101,0,52,0,98,
0,100,0,54,0,
50,0,57,0,99,
0,99,0,52,0,
99,0,101,0,52,
0,98,0,98,0,
99,0,98,0,50,
0,97,0,52,0,
57,0,57,0,57,
0,52,0,53,0,
50,0,98,0,52,
0,99,0,1,516,
1125,1,515,1142,19,
1143,4,82,98,0,
111,0,117,0,110,
0,100,0,65,0,
110,0,100,0,95,
0,57,0,99,0,
55,0,52,0,48,
0,55,0,99,0,
101,0,102,0,101,
0,99,0,102,0,
52,0,48,0,99,
0,57,0,98,0,
50,0,97,0,57,
0,48,0,50,0,
56,0,101,0,50,
0,54,0,54,0,
50,0,98,0,53,
0,52,0,50,0,
1,515,1125,1,514,
1144,19,1145,4,86,
98,0,111,0,117,
0,110,0,100,0,
73,0,100,0,101,
0,110,0,116,0,
95,0,99,0,97,
0,52,0,56,0,
100,0,57,0,49,
0,56,0,99,0,
102,0,100,0,56,
0,52,0,100,0,
102,0,100,0,97,
0,51,0,50,0,
56,0,49,0,100,
0,50,0,56,0,
56,0,49,0,49,
0,54,0,97,0,
48,0,100,0,57,
0,1,514,1125,1,
513,1146,19,1147,4,
92,98,0,111,0,
117,0,110,0,100,
0,68,0,97,0,
116,0,97,0,84,
0,121,0,112,0,
101,0,95,0,48,
0,102,0,99,0,
54,0,54,0,51,
0,98,0,49,0,
51,0,54,0,53,
0,97,0,52,0,
97,0,52,0,54,
0,57,0,49,0,
56,0,50,0,101,
0,101,0,101,0,
53,0,102,0,99,
0,98,0,56,0,
54,0,57,0,98,
0,49,0,1,513,
1125,1,512,1148,19,
1149,4,86,98,0,
111,0,117,0,110,
0,100,0,84,0,
111,0,116,0,97,
0,108,0,95,0,
97,0,101,0,99,
0,101,0,57,0,
50,0,54,0,101,
0,51,0,54,0,
51,0,51,0,52,
0,98,0,50,0,
50,0,98,0,48,
0,99,0,99,0,
99,0,99,0,100,
0,52,0,97,0,
57,0,57,0,54,
0,55,0,98,0,
54,0,102,0,1,
512,1125,1,511,1150,
19,1151,4,82,98,
0,111,0,117,0,
110,0,100,0,84,
0,111,0,112,0,
95,0,50,0,55,
0,53,0,50,0,
51,0,53,0,52,
0,48,0,53,0,
100,0,57,0,52,
0,52,0,51,0,
97,0,99,0,57,
0,97,0,57,0,
57,0,48,0,49,
0,48,0,56,0,
48,0,48,0,48,
0,101,0,98,0,
55,0,48,0,56,
0,1,511,1125,1,
510,1152,19,1153,4,
86,98,0,111,0,
117,0,110,0,100,
0,79,0,110,0,
101,0,79,0,102,
0,95,0,57,0,
53,0,99,0,56,
0,57,0,55,0,
97,0,52,0,97,
0,53,0,50,0,
101,0,52,0,56,
0,99,0,98,0,
98,0,100,0,101,
0,99,0,99,0,
53,0,98,0,53,
0,55,0,98,0,
49,0,57,0,100,
0,50,0,52,0,
98,0,1,510,1125,
1,509,1154,19,1155,
4,82,98,0,111,
0,117,0,110,0,
100,0,86,0,97,
0,108,0,95,0,
50,0,57,0,51,
0,49,0,49,0,
100,0,51,0,98,
0,101,0,50,0,
52,0,53,0,52,
0,53,0,99,0,
49,0,97,0,51,
0,100,0,52,0,
52,0,102,0,99,
0,56,0,51,0,
99,0,101,0,53,
0,57,0,51,0,
50,0,102,0,1,
509,1125,1,508,1156,
19,1157,4,82,98,
0,111,0,117,0,
110,0,100,0,86,
0,97,0,108,0,
95,0,99,0,56,
0,50,0,56,0,
100,0,99,0,97,
0,100,0,53,0,
49,0,55,0,102,
0,52,0,54,0,
97,0,52,0,97,
0,57,0,48,0,
102,0,99,0,52,
0,55,0,97,0,
49,0,102,0,48,
0,51,0,98,0,
99,0,49,0,99,
0,1,508,1125,1,
507,1158,19,1159,4,
88,98,0,111,0,
117,0,110,0,100,
0,70,0,97,0,
99,0,101,0,116,
0,115,0,95,0,
98,0,49,0,56,
0,53,0,57,0,
50,0,99,0,54,
0,51,0,57,0,
50,0,54,0,52,
0,49,0,48,0,
102,0,97,0,49,
0,98,0,101,0,
56,0,50,0,48,
0,55,0,99,0,
49,0,99,0,49,
0,50,0,51,0,
57,0,98,0,1,
507,1125,1,506,1160,
19,1161,4,84,102,
0,97,0,99,0,
101,0,116,0,76,
0,105,0,115,0,
116,0,95,0,52,
0,52,0,51,0,
57,0,100,0,101,
0,51,0,49,0,
99,0,101,0,56,
0,100,0,52,0,
97,0,54,0,100,
0,97,0,100,0,
53,0,49,0,50,
0,48,0,55,0,
51,0,56,0,98,
0,98,0,57,0,
52,0,57,0,98,
0,56,0,1,506,
1162,5,14,1,36,
1163,16,0,801,1,
34,1164,16,0,801,
1,33,1165,16,0,
801,1,211,1166,16,
0,801,1,577,1167,
16,0,801,1,349,
1168,16,0,801,1,
237,1169,16,0,801,
1,162,1170,16,0,
801,1,1271,1171,16,
0,801,1,40,1172,
16,0,801,1,45,
1173,16,0,801,1,
263,1174,16,0,801,
1,346,1175,16,0,
801,1,829,1176,16,
0,801,1,505,1177,
19,1178,4,84,102,
0,97,0,99,0,
101,0,116,0,76,
0,105,0,115,0,
116,0,95,0,49,
0,54,0,53,0,
100,0,54,0,52,
0,53,0,52,0,
100,0,56,0,52,
0,53,0,52,0,
56,0,102,0,54,
0,98,0,100,0,
54,0,48,0,99,
0,57,0,53,0,
100,0,100,0,55,
0,57,0,53,0,
97,0,98,0,53,
0,57,0,1,505,
1162,1,504,1179,19,
1180,4,76,102,0,
97,0,99,0,101,
0,116,0,95,0,
51,0,53,0,97,
0,50,0,54,0,
52,0,56,0,57,
0,53,0,54,0,
57,0,101,0,52,
0,52,0,99,0,
56,0,57,0,99,
0,52,0,52,0,
99,0,101,0,50,
0,50,0,54,0,
97,0,51,0,51,
0,54,0,56,0,
98,0,99,0,1,
504,1181,5,15,1,
36,1182,16,0,784,
1,34,1183,16,0,
784,1,33,1184,16,
0,784,1,211,1185,
16,0,784,1,577,
1186,16,0,784,1,
45,1187,16,0,784,
1,349,1188,16,0,
784,1,237,1189,16,
0,784,1,162,1190,
16,0,784,1,1271,
1191,16,0,784,1,
40,1192,16,0,784,
1,829,1193,16,0,
784,1,263,1194,16,
0,784,1,346,1195,
16,0,784,1,113,
1196,16,0,799,1,
503,1197,19,1198,4,
76,102,0,97,0,
99,0,101,0,116,
0,95,0,55,0,
97,0,99,0,48,
0,55,0,55,0,
49,0,57,0,50,
0,98,0,54,0,
56,0,52,0,101,
0,101,0,53,0,
97,0,53,0,55,
0,56,0,49,0,
56,0,100,0,98,
0,48,0,48,0,
100,0,56,0,98,
0,97,0,52,0,
48,0,1,503,1181,
1,502,1199,19,1200,
4,76,102,0,97,
0,99,0,101,0,
116,0,95,0,48,
0,100,0,52,0,
48,0,53,0,98,
0,101,0,54,0,
55,0,49,0,101,
0,98,0,52,0,
56,0,53,0,56,
0,98,0,57,0,
51,0,48,0,101,
0,100,0,53,0,
98,0,53,0,54,
0,56,0,51,0,
53,0,52,0,49,
0,101,0,1,502,
1181,1,501,1201,19,
1202,4,76,102,0,
97,0,99,0,101,
0,116,0,95,0,
53,0,50,0,50,
0,99,0,55,0,
57,0,101,0,51,
0,55,0,97,0,
51,0,54,0,52,
0,48,0,54,0,
55,0,97,0,51,
0,97,0,102,0,
50,0,57,0,101,
0,48,0,99,0,
49,0,57,0,49,
0,98,0,102,0,
97,0,99,0,1,
501,1181,1,500,1203,
19,1204,4,154,119,
0,111,0,114,0,
100,0,95,0,110,
0,117,0,109,0,
98,0,101,0,114,
0,95,0,55,0,
53,0,98,0,100,
0,53,0,97,0,
54,0,99,0,100,
0,100,0,102,0,
51,0,52,0,55,
0,97,0,48,0,
57,0,99,0,97,
0,54,0,51,0,
48,0,50,0,49,
0,99,0,56,0,
101,0,100,0,50,
0,54,0,97,0,
100,0,95,0,102,
0,97,0,98,0,
97,0,50,0,98,
0,54,0,100,0,
54,0,54,0,97,
0,98,0,52,0,
53,0,53,0,48,
0,97,0,48,0,
50,0,98,0,98,
0,55,0,52,0,
51,0,51,0,51,
0,48,0,52,0,
49,0,101,0,99,
0,57,0,1,500,
1205,5,1,1,234,
1206,16,0,716,1,
499,1207,19,1208,4,
88,119,0,111,0,
114,0,100,0,95,
0,110,0,117,0,
109,0,98,0,101,
0,114,0,95,0,
55,0,53,0,98,
0,100,0,53,0,
97,0,54,0,99,
0,100,0,100,0,
102,0,51,0,52,
0,55,0,97,0,
48,0,57,0,99,
0,97,0,54,0,
51,0,48,0,50,
0,49,0,99,0,
56,0,101,0,100,
0,50,0,54,0,
97,0,100,0,1,
499,1205,1,498,1209,
19,1210,4,88,119,
0,111,0,114,0,
100,0,95,0,110,
0,117,0,109,0,
98,0,101,0,114,
0,95,0,101,0,
52,0,57,0,100,
0,51,0,99,0,
99,0,50,0,52,
0,56,0,57,0,
48,0,52,0,56,
0,50,0,51,0,
97,0,49,0,101,
0,51,0,97,0,
49,0,97,0,51,
0,101,0,48,0,
54,0,51,0,54,
0,101,0,56,0,
55,0,1,498,1205,
1,497,1211,19,1212,
4,154,119,0,111,
0,114,0,100,0,
95,0,110,0,117,
0,109,0,98,0,
101,0,114,0,95,
0,102,0,50,0,
57,0,102,0,52,
0,98,0,52,0,
53,0,100,0,52,
0,102,0,54,0,
52,0,52,0,48,
0,102,0,97,0,
97,0,98,0,55,
0,98,0,48,0,
51,0,56,0,100,
0,54,0,51,0,
101,0,56,0,48,
0,49,0,54,0,
95,0,49,0,99,
0,101,0,49,0,
54,0,56,0,51,
0,49,0,55,0,
57,0,54,0,99,
0,52,0,100,0,
97,0,51,0,97,
0,101,0,102,0,
49,0,97,0,99,
0,101,0,51,0,
53,0,53,0,101,
0,51,0,48,0,
98,0,98,0,101,
0,1,497,1205,1,
496,1213,19,1214,4,
88,119,0,111,0,
114,0,100,0,95,
0,110,0,117,0,
109,0,98,0,101,
0,114,0,95,0,
102,0,50,0,57,
0,102,0,52,0,
98,0,52,0,53,
0,100,0,52,0,
102,0,54,0,52,
0,52,0,48,0,
102,0,97,0,97,
0,98,0,55,0,
98,0,48,0,51,
0,56,0,100,0,
54,0,51,0,101,
0,56,0,48,0,
49,0,54,0,1,
496,1205,1,495,1215,
19,1216,4,88,119,
0,111,0,114,0,
100,0,95,0,110,
0,117,0,109,0,
98,0,101,0,114,
0,95,0,102,0,
55,0,56,0,55,
0,51,0,52,0,
48,0,50,0,97,
0,49,0,56,0,
50,0,52,0,56,
0,49,0,100,0,
57,0,102,0,51,
0,100,0,54,0,
101,0,99,0,57,
0,49,0,52,0,
97,0,101,0,50,
0,57,0,54,0,
53,0,1,495,1205,
1,494,1217,19,1218,
4,148,99,0,111,
0,109,0,112,0,
97,0,114,0,101,
0,114,0,95,0,
53,0,101,0,99,
0,98,0,97,0,
97,0,100,0,48,
0,101,0,51,0,
57,0,98,0,52,
0,50,0,50,0,
52,0,57,0,49,
0,102,0,99,0,
57,0,99,0,57,
0,56,0,55,0,
50,0,56,0,53,
0,50,0,51,0,
102,0,99,0,95,
0,98,0,97,0,
54,0,52,0,53,
0,49,0,57,0,
52,0,100,0,54,
0,57,0,50,0,
52,0,98,0,48,
0,48,0,56,0,
55,0,50,0,50,
0,54,0,51,0,
50,0,56,0,102,
0,51,0,101,0,
100,0,50,0,51,
0,53,0,49,0,
1,494,1219,5,3,
1,33,1220,16,0,
723,1,346,1221,16,
0,723,1,211,1222,
16,0,723,1,493,
1223,19,1224,4,82,
99,0,111,0,109,
0,112,0,97,0,
114,0,101,0,114,
0,95,0,53,0,
101,0,99,0,98,
0,97,0,97,0,
100,0,48,0,101,
0,51,0,57,0,
98,0,52,0,50,
0,50,0,52,0,
57,0,49,0,102,
0,99,0,57,0,
99,0,57,0,56,
0,55,0,50,0,
56,0,53,0,50,
0,51,0,102,0,
99,0,1,493,1219,
1,492,1225,19,1226,
4,82,99,0,111,
0,109,0,112,0,
97,0,114,0,101,
0,114,0,95,0,
49,0,52,0,53,
0,102,0,56,0,
49,0,99,0,97,
0,101,0,57,0,
54,0,102,0,52,
0,101,0,50,0,
48,0,98,0,51,
0,50,0,50,0,
55,0,99,0,102,
0,102,0,97,0,
55,0,49,0,98,
0,51,0,53,0,
100,0,51,0,1,
492,1219,1,491,1227,
19,1228,4,148,99,
0,111,0,109,0,
112,0,97,0,114,
0,101,0,114,0,
95,0,97,0,48,
0,99,0,48,0,
98,0,98,0,57,
0,51,0,101,0,
54,0,97,0,101,
0,52,0,54,0,
57,0,55,0,57,
0,51,0,51,0,
50,0,49,0,99,
0,51,0,55,0,
57,0,53,0,54,
0,97,0,102,0,
56,0,57,0,55,
0,95,0,48,0,
52,0,98,0,49,
0,99,0,100,0,
56,0,48,0,100,
0,57,0,101,0,
99,0,52,0,100,
0,99,0,57,0,
98,0,50,0,101,
0,53,0,54,0,
98,0,97,0,100,
0,52,0,51,0,
51,0,51,0,99,
0,99,0,53,0,
54,0,1,491,1219,
1,490,1229,19,1230,
4,82,99,0,111,
0,109,0,112,0,
97,0,114,0,101,
0,114,0,95,0,
97,0,48,0,99,
0,48,0,98,0,
98,0,57,0,51,
0,101,0,54,0,
97,0,101,0,52,
0,54,0,57,0,
55,0,57,0,51,
0,51,0,50,0,
49,0,99,0,51,
0,55,0,57,0,
53,0,54,0,97,
0,102,0,56,0,
57,0,55,0,1,
490,1219,1,489,1231,
19,1232,4,82,99,
0,111,0,109,0,
112,0,97,0,114,
0,101,0,114,0,
95,0,49,0,53,
0,57,0,50,0,
98,0,52,0,98,
0,97,0,54,0,
100,0,97,0,48,
0,52,0,100,0,
55,0,97,0,97,
0,55,0,49,0,
101,0,56,0,98,
0,50,0,102,0,
49,0,57,0,98,
0,54,0,98,0,
99,0,48,0,49,
0,1,489,1219,1,
488,1233,19,1234,4,
78,111,0,114,0,
108,0,111,0,111,
0,112,0,95,0,
97,0,52,0,100,
0,55,0,97,0,
50,0,52,0,51,
0,55,0,98,0,
55,0,55,0,52,
0,98,0,53,0,
102,0,57,0,49,
0,57,0,50,0,
55,0,98,0,99,
0,102,0,51,0,
97,0,53,0,100,
0,52,0,56,0,
98,0,56,0,1,
488,1235,5,6,1,
203,1236,16,0,430,
1,1642,1237,16,0,
822,1,1741,1238,16,
0,217,1,25,1239,
16,0,893,1,1639,
1240,16,0,323,1,
1761,1241,16,0,463,
1,487,1242,19,1243,
4,78,111,0,114,
0,108,0,111,0,
111,0,112,0,95,
0,48,0,48,0,
57,0,97,0,56,
0,50,0,57,0,
48,0,101,0,51,
0,55,0,51,0,
52,0,53,0,56,
0,52,0,57,0,
97,0,49,0,49,
0,56,0,48,0,
57,0,56,0,55,
0,100,0,101,0,
57,0,98,0,101,
0,53,0,98,0,
1,487,1235,1,486,
1244,19,1245,4,80,
97,0,110,0,100,
0,108,0,111,0,
111,0,112,0,95,
0,101,0,51,0,
100,0,101,0,49,
0,53,0,56,0,
50,0,102,0,54,
0,100,0,55,0,
52,0,56,0,48,
0,51,0,97,0,
98,0,53,0,53,
0,49,0,102,0,
57,0,49,0,98,
0,49,0,55,0,
48,0,56,0,98,
0,99,0,100,0,
1,486,1246,5,7,
1,203,1247,16,0,
742,1,1642,1248,16,
0,742,1,1741,1249,
16,0,742,1,25,
1250,16,0,742,1,
1639,1251,16,0,742,
1,1761,1252,16,0,
742,1,27,1253,16,
0,889,1,485,1254,
19,1255,4,80,97,
0,110,0,100,0,
108,0,111,0,111,
0,112,0,95,0,
101,0,50,0,51,
0,53,0,49,0,
99,0,48,0,101,
0,48,0,49,0,
52,0,99,0,52,
0,97,0,57,0,
50,0,57,0,101,
0,56,0,57,0,
57,0,52,0,101,
0,54,0,99,0,
53,0,53,0,52,
0,56,0,97,0,
48,0,54,0,1,
485,1246,1,484,1256,
19,1257,4,86,116,
0,104,0,97,0,
116,0,79,0,114,
0,76,0,111,0,
111,0,112,0,95,
0,99,0,99,0,
53,0,101,0,55,
0,55,0,99,0,
102,0,55,0,50,
0,98,0,57,0,
52,0,56,0,97,
0,56,0,57,0,
102,0,48,0,99,
0,101,0,56,0,
102,0,99,0,56,
0,100,0,100,0,
98,0,55,0,51,
0,48,0,51,0,
1,484,1258,5,13,
1,295,1259,16,0,
667,1,402,1260,16,
0,593,1,23,1261,
16,0,565,1,281,
1262,16,0,687,1,
1464,1263,16,0,726,
1,314,1264,16,0,
726,1,201,1265,16,
0,596,1,346,1266,
16,0,617,1,230,
1267,16,0,726,1,
1670,1268,16,0,593,
1,226,1269,16,0,
729,1,520,1270,16,
0,514,1,1332,1271,
16,0,726,1,483,
1272,19,1273,4,86,
116,0,104,0,97,
0,116,0,79,0,
114,0,76,0,111,
0,111,0,112,0,
95,0,50,0,54,
0,56,0,50,0,
49,0,54,0,97,
0,53,0,55,0,
51,0,99,0,51,
0,52,0,97,0,
52,0,51,0,98,
0,100,0,101,0,
50,0,57,0,100,
0,55,0,100,0,
57,0,52,0,50,
0,97,0,100,0,
56,0,52,0,57,
0,1,483,1258,1,
482,1274,19,1275,4,
88,115,0,105,0,
110,0,103,0,108,
0,101,0,79,0,
110,0,101,0,79,
0,102,0,95,0,
57,0,102,0,54,
0,52,0,102,0,
57,0,53,0,101,
0,48,0,102,0,
101,0,53,0,52,
0,100,0,57,0,
56,0,97,0,55,
0,99,0,99,0,
49,0,49,0,50,
0,50,0,54,0,
48,0,57,0,49,
0,54,0,98,0,
52,0,99,0,1,
482,1276,5,16,1,
1664,1277,16,0,663,
1,1458,1278,16,0,
663,1,33,1279,16,
0,663,1,1326,1280,
16,0,663,1,509,
1281,16,0,524,1,
211,1282,16,0,663,
1,20,1283,16,0,
563,1,500,1284,16,
0,530,1,237,1285,
16,0,704,1,346,
1286,16,0,663,1,
308,1287,16,0,663,
1,327,1288,16,0,
663,1,9,1289,16,
0,550,1,524,1290,
16,0,507,1,263,
1291,16,0,685,1,
2,1292,16,0,542,
1,481,1293,19,1294,
4,88,115,0,105,
0,110,0,103,0,
108,0,101,0,79,
0,110,0,101,0,
79,0,102,0,95,
0,102,0,57,0,
50,0,52,0,48,
0,98,0,97,0,
102,0,98,0,99,
0,97,0,102,0,
52,0,49,0,56,
0,100,0,56,0,
98,0,102,0,101,
0,49,0,48,0,
55,0,54,0,53,
0,97,0,100,0,
56,0,101,0,49,
0,102,0,57,0,
1,481,1276,1,480,
1295,19,1296,4,96,
115,0,105,0,110,
0,103,0,108,0,
101,0,84,0,104,
0,105,0,110,0,
103,0,84,0,104,
0,97,0,116,0,
95,0,53,0,97,
0,97,0,53,0,
48,0,53,0,101,
0,55,0,55,0,
49,0,56,0,53,
0,52,0,102,0,
50,0,49,0,56,
0,51,0,51,0,
101,0,55,0,100,
0,54,0,99,0,
56,0,50,0,102,
0,49,0,48,0,
56,0,52,0,54,
0,1,480,1276,1,
479,1297,19,1298,4,
96,115,0,105,0,
110,0,103,0,108,
0,101,0,84,0,
104,0,105,0,110,
0,103,0,84,0,
104,0,97,0,116,
0,95,0,99,0,
49,0,51,0,98,
0,102,0,51,0,
57,0,49,0,56,
0,98,0,52,0,
101,0,52,0,56,
0,53,0,53,0,
57,0,48,0,100,
0,57,0,49,0,
52,0,54,0,100,
0,53,0,100,0,
53,0,48,0,55,
0,49,0,100,0,
101,0,1,479,1276,
1,478,1299,19,1300,
4,96,115,0,105,
0,110,0,103,0,
108,0,101,0,84,
0,104,0,105,0,
110,0,103,0,84,
0,104,0,97,0,
116,0,95,0,52,
0,97,0,102,0,
53,0,57,0,51,
0,102,0,51,0,
99,0,57,0,99,
0,57,0,52,0,
50,0,97,0,97,
0,56,0,100,0,
52,0,50,0,99,
0,52,0,49,0,
53,0,48,0,50,
0,98,0,51,0,
99,0,102,0,100,
0,57,0,1,478,
1276,1,477,1301,19,
1302,4,94,115,0,
105,0,110,0,103,
0,108,0,101,0,
78,0,97,0,109,
0,101,0,84,0,
104,0,97,0,116,
0,95,0,100,0,
99,0,102,0,52,
0,52,0,98,0,
49,0,55,0,49,
0,98,0,97,0,
98,0,52,0,52,
0,54,0,53,0,
57,0,101,0,54,
0,55,0,56,0,
57,0,102,0,57,
0,54,0,52,0,
51,0,50,0,56,
0,52,0,54,0,
50,0,1,477,1276,
1,476,1303,19,1304,
4,88,115,0,105,
0,110,0,103,0,
108,0,101,0,84,
0,104,0,105,0,
110,0,103,0,95,
0,50,0,99,0,
48,0,50,0,48,
0,99,0,54,0,
102,0,55,0,56,
0,100,0,48,0,
52,0,99,0,54,
0,54,0,97,0,
102,0,102,0,97,
0,50,0,102,0,
50,0,49,0,53,
0,97,0,99,0,
97,0,100,0,54,
0,102,0,48,0,
1,476,1276,1,475,
1305,19,1306,4,88,
115,0,105,0,110,
0,103,0,108,0,
101,0,84,0,104,
0,105,0,110,0,
103,0,95,0,48,
0,50,0,55,0,
98,0,53,0,52,
0,50,0,99,0,
55,0,100,0,55,
0,100,0,52,0,
50,0,48,0,102,
0,57,0,57,0,
51,0,57,0,51,
0,52,0,49,0,
100,0,49,0,51,
0,52,0,54,0,
56,0,101,0,54,
0,102,0,1,475,
1276,1,474,1307,19,
1308,4,88,115,0,
105,0,110,0,103,
0,108,0,101,0,
84,0,104,0,105,
0,110,0,103,0,
95,0,101,0,102,
0,102,0,48,0,
98,0,97,0,100,
0,99,0,54,0,
97,0,50,0,98,
0,52,0,51,0,
55,0,102,0,98,
0,102,0,52,0,
54,0,56,0,56,
0,102,0,55,0,
99,0,52,0,53,
0,55,0,98,0,
48,0,101,0,97,
0,1,474,1276,1,
473,1309,19,1310,4,
86,115,0,105,0,
110,0,103,0,108,
0,101,0,78,0,
97,0,109,0,101,
0,95,0,57,0,
54,0,98,0,97,
0,98,0,97,0,
52,0,56,0,51,
0,50,0,53,0,
56,0,52,0,97,
0,97,0,53,0,
97,0,57,0,99,
0,52,0,49,0,
51,0,49,0,57,
0,100,0,54,0,
97,0,97,0,99,
0,57,0,57,0,
51,0,1,473,1276,
1,472,1311,19,1312,
4,92,111,0,111,
0,98,0,106,0,
101,0,99,0,116,
0,67,0,109,0,
112,0,66,0,110,
0,100,0,95,0,
97,0,101,0,55,
0,102,0,54,0,
51,0,98,0,57,
0,97,0,49,0,
55,0,98,0,52,
0,102,0,102,0,
99,0,97,0,48,
0,99,0,53,0,
48,0,52,0,54,
0,52,0,50,0,
53,0,54,0,54,
0,100,0,99,0,
48,0,55,0,1,
472,1313,5,3,1,
33,1314,16,0,581,
1,346,1315,16,0,
616,1,211,1316,16,
0,661,1,471,1317,
19,1318,4,102,111,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,67,0,
109,0,112,0,73,
0,110,0,115,0,
116,0,97,0,110,
0,99,0,101,0,
95,0,54,0,50,
0,102,0,54,0,
101,0,100,0,56,
0,54,0,99,0,
99,0,99,0,56,
0,52,0,52,0,
53,0,102,0,98,
0,102,0,98,0,
48,0,102,0,49,
0,99,0,98,0,
101,0,57,0,98,
0,56,0,101,0,
101,0,53,0,52,
0,1,471,1313,1,
470,1319,19,1320,4,
86,111,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
67,0,109,0,112,
0,95,0,102,0,
102,0,48,0,53,
0,50,0,56,0,
98,0,50,0,100,
0,48,0,53,0,
101,0,52,0,57,
0,49,0,101,0,
56,0,102,0,54,
0,102,0,101,0,
97,0,100,0,99,
0,100,0,98,0,
55,0,97,0,53,
0,48,0,55,0,
48,0,1,470,1313,
1,469,1321,19,1322,
4,94,111,0,111,
0,98,0,106,0,
101,0,99,0,116,
0,79,0,110,0,
108,0,121,0,66,
0,110,0,100,0,
95,0,48,0,102,
0,55,0,98,0,
99,0,49,0,50,
0,97,0,55,0,
51,0,102,0,101,
0,52,0,98,0,
50,0,48,0,98,
0,52,0,50,0,
50,0,100,0,102,
0,52,0,102,0,
101,0,55,0,100,
0,54,0,53,0,
99,0,102,0,51,
0,1,469,1313,1,
468,1323,19,1324,4,
86,111,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
66,0,110,0,100,
0,95,0,102,0,
53,0,98,0,99,
0,52,0,53,0,
55,0,102,0,98,
0,49,0,54,0,
97,0,52,0,101,
0,49,0,56,0,
97,0,102,0,57,
0,50,0,49,0,
50,0,50,0,101,
0,50,0,56,0,
51,0,100,0,97,
0,51,0,53,0,
101,0,1,468,1313,
1,467,1325,19,1326,
4,88,111,0,111,
0,98,0,106,0,
101,0,99,0,116,
0,83,0,101,0,
108,0,102,0,95,
0,49,0,48,0,
55,0,98,0,55,
0,102,0,51,0,
51,0,53,0,101,
0,57,0,54,0,
52,0,50,0,100,
0,98,0,57,0,
53,0,99,0,98,
0,101,0,57,0,
101,0,97,0,99,
0,102,0,57,0,
101,0,56,0,53,
0,57,0,57,0,
1,467,1313,1,466,
1327,19,1328,4,114,
111,0,111,0,98,
0,106,0,101,0,
99,0,116,0,79,
0,110,0,108,0,
121,0,83,0,111,
0,109,0,101,0,
116,0,104,0,105,
0,110,0,103,0,
84,0,104,0,97,
0,116,0,95,0,
54,0,50,0,51,
0,102,0,49,0,
53,0,52,0,53,
0,51,0,53,0,
97,0,101,0,52,
0,102,0,53,0,
51,0,57,0,53,
0,49,0,98,0,
48,0,102,0,97,
0,100,0,101,0,
101,0,50,0,49,
0,98,0,101,0,
56,0,56,0,1,
466,1313,1,465,1329,
19,1330,4,102,111,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,79,0,
110,0,108,0,121,
0,78,0,111,0,
116,0,104,0,105,
0,110,0,103,0,
95,0,56,0,54,
0,52,0,54,0,
102,0,49,0,52,
0,49,0,57,0,
100,0,55,0,51,
0,52,0,98,0,
57,0,56,0,57,
0,52,0,99,0,
52,0,55,0,100,
0,97,0,52,0,
98,0,102,0,54,
0,53,0,55,0,
50,0,49,0,51,
0,1,465,1313,1,
464,1331,19,1332,4,
104,111,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
79,0,110,0,108,
0,121,0,73,0,
110,0,115,0,116,
0,97,0,110,0,
99,0,101,0,95,
0,49,0,101,0,
102,0,97,0,57,
0,50,0,102,0,
57,0,48,0,97,
0,56,0,57,0,
52,0,49,0,99,
0,55,0,56,0,
97,0,97,0,52,
0,56,0,50,0,
50,0,51,0,100,
0,48,0,100,0,
99,0,52,0,54,
0,102,0,56,0,
1,464,1313,1,463,
1333,19,1334,4,88,
111,0,111,0,98,
0,106,0,101,0,
99,0,116,0,79,
0,110,0,108,0,
121,0,95,0,51,
0,49,0,56,0,
97,0,99,0,52,
0,100,0,57,0,
56,0,56,0,54,
0,54,0,52,0,
48,0,97,0,100,
0,57,0,49,0,
53,0,100,0,51,
0,54,0,56,0,
100,0,102,0,99,
0,99,0,101,0,
49,0,102,0,102,
0,56,0,1,463,
1313,1,462,1335,19,
1336,4,96,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,73,0,110,
0,115,0,116,0,
97,0,110,0,99,
0,101,0,95,0,
55,0,50,0,50,
0,50,0,57,0,
56,0,97,0,53,
0,53,0,57,0,
49,0,102,0,52,
0,50,0,52,0,
49,0,98,0,56,
0,49,0,102,0,
54,0,97,0,102,
0,99,0,54,0,
102,0,57,0,98,
0,52,0,48,0,
52,0,48,0,1,
462,1337,5,8,1,
33,1338,16,0,580,
1,1664,1339,16,0,
637,1,1458,1340,16,
0,176,1,211,1341,
16,0,659,1,346,
1342,16,0,615,1,
327,1343,16,0,638,
1,308,1344,16,0,
637,1,1326,1345,16,
0,575,1,461,1346,
19,1347,4,106,111,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,83,0,
111,0,109,0,101,
0,116,0,104,0,
105,0,110,0,103,
0,84,0,104,0,
97,0,116,0,95,
0,48,0,55,0,
101,0,102,0,50,
0,99,0,52,0,
98,0,49,0,101,
0,102,0,51,0,
52,0,99,0,57,
0,56,0,56,0,
49,0,50,0,101,
0,98,0,99,0,
101,0,53,0,102,
0,49,0,57,0,
53,0,97,0,102,
0,98,0,53,0,
1,461,1337,1,460,
1348,19,1349,4,94,
111,0,111,0,98,
0,106,0,101,0,
99,0,116,0,78,
0,111,0,116,0,
104,0,105,0,110,
0,103,0,95,0,
50,0,57,0,48,
0,49,0,99,0,
53,0,57,0,53,
0,99,0,102,0,
49,0,53,0,52,
0,48,0,99,0,
49,0,57,0,102,
0,57,0,51,0,
98,0,98,0,53,
0,99,0,48,0,
48,0,57,0,99,
0,98,0,98,0,
56,0,55,0,1,
460,1337,1,459,1350,
19,1351,4,98,111,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,83,0,
111,0,109,0,101,
0,116,0,104,0,
105,0,110,0,103,
0,95,0,50,0,
57,0,51,0,57,
0,98,0,102,0,
54,0,56,0,101,
0,51,0,51,0,
100,0,52,0,48,
0,56,0,51,0,
57,0,51,0,99,
0,99,0,55,0,
54,0,57,0,101,
0,54,0,54,0,
56,0,52,0,52,
0,55,0,101,0,
49,0,1,459,1337,
1,458,1352,19,1353,
4,82,111,0,111,
0,98,0,106,0,
101,0,99,0,116,
0,65,0,95,0,
101,0,98,0,99,
0,99,0,51,0,
56,0,98,0,101,
0,97,0,55,0,
55,0,50,0,52,
0,99,0,101,0,
101,0,98,0,49,
0,53,0,50,0,
56,0,99,0,48,
0,102,0,52,0,
49,0,53,0,101,
0,98,0,57,0,
102,0,101,0,1,
458,1337,1,457,1354,
19,1355,4,82,111,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,65,0,
95,0,49,0,55,
0,102,0,98,0,
56,0,56,0,48,
0,55,0,100,0,
99,0,50,0,97,
0,52,0,48,0,
52,0,101,0,56,
0,52,0,53,0,
54,0,101,0,54,
0,54,0,53,0,
56,0,98,0,52,
0,51,0,97,0,
48,0,55,0,100,
0,1,457,1337,1,
456,1356,19,1357,4,
82,111,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
65,0,95,0,98,
0,50,0,53,0,
53,0,52,0,55,
0,53,0,55,0,
54,0,98,0,52,
0,51,0,52,0,
102,0,55,0,102,
0,97,0,98,0,
54,0,57,0,53,
0,100,0,55,0,
49,0,57,0,50,
0,53,0,54,0,
100,0,98,0,48,
0,50,0,1,456,
1337,1,455,1358,19,
1359,4,90,105,0,
110,0,115,0,116,
0,97,0,110,0,
99,0,101,0,76,
0,105,0,115,0,
116,0,95,0,48,
0,54,0,57,0,
99,0,50,0,100,
0,52,0,102,0,
53,0,98,0,53,
0,97,0,52,0,
53,0,97,0,49,
0,98,0,101,0,
102,0,99,0,53,
0,50,0,53,0,
51,0,50,0,54,
0,48,0,101,0,
99,0,55,0,49,
0,50,0,1,455,
1360,5,3,1,167,
1361,16,0,917,1,
11,1362,16,0,908,
1,4,1363,16,0,
917,1,454,1364,19,
1365,4,90,105,0,
110,0,115,0,116,
0,97,0,110,0,
99,0,101,0,76,
0,105,0,115,0,
116,0,95,0,100,
0,53,0,102,0,
102,0,54,0,50,
0,53,0,97,0,
49,0,97,0,53,
0,101,0,52,0,
48,0,102,0,50,
0,98,0,53,0,
54,0,50,0,101,
0,56,0,49,0,
54,0,50,0,56,
0,53,0,52,0,
98,0,51,0,99,
0,52,0,1,454,
1360,1,453,1366,19,
1367,4,88,105,0,
110,0,115,0,116,
0,97,0,110,0,
99,0,101,0,84,
0,104,0,101,0,
95,0,97,0,97,
0,98,0,101,0,
99,0,100,0,98,
0,49,0,56,0,
98,0,49,0,54,
0,52,0,98,0,
57,0,101,0,56,
0,48,0,54,0,
99,0,51,0,102,
0,53,0,52,0,
48,0,55,0,99,
0,51,0,56,0,
100,0,54,0,102,
0,1,453,1368,5,
15,1,1664,1369,16,
0,670,1,33,1370,
16,0,670,1,1326,
1371,16,0,670,1,
211,1372,16,0,670,
1,4,1373,16,0,
905,1,167,1374,16,
0,905,1,17,1375,
16,0,903,1,1458,
1376,16,0,670,1,
346,1377,16,0,670,
1,308,1378,16,0,
670,1,11,1379,16,
0,905,1,327,1380,
16,0,670,1,237,
1381,16,0,705,1,
7,1382,16,0,914,
1,263,1383,16,0,
686,1,452,1384,19,
1385,4,88,105,0,
110,0,115,0,116,
0,97,0,110,0,
99,0,101,0,84,
0,104,0,101,0,
95,0,48,0,101,
0,48,0,55,0,
51,0,49,0,53,
0,57,0,101,0,
53,0,56,0,100,
0,52,0,54,0,
55,0,54,0,97,
0,101,0,56,0,
49,0,102,0,57,
0,98,0,101,0,
54,0,100,0,99,
0,55,0,50,0,
51,0,101,0,101,
0,1,452,1368,1,
451,1386,19,1387,4,
96,105,0,110,0,
115,0,116,0,97,
0,110,0,99,0,
101,0,66,0,105,
0,103,0,78,0,
97,0,109,0,101,
0,95,0,57,0,
50,0,56,0,48,
0,51,0,51,0,
51,0,50,0,51,
0,49,0,51,0,
56,0,52,0,49,
0,49,0,55,0,
97,0,102,0,51,
0,97,0,54,0,
97,0,48,0,49,
0,48,0,48,0,
54,0,50,0,48,
0,100,0,55,0,
54,0,1,451,1368,
1,450,1388,19,1389,
4,96,105,0,110,
0,115,0,116,0,
97,0,110,0,99,
0,101,0,66,0,
105,0,103,0,78,
0,97,0,109,0,
101,0,95,0,49,
0,101,0,54,0,
51,0,54,0,100,
0,57,0,102,0,
50,0,51,0,99,
0,49,0,52,0,
50,0,52,0,102,
0,98,0,51,0,
50,0,56,0,97,
0,98,0,100,0,
100,0,52,0,53,
0,100,0,50,0,
99,0,101,0,50,
0,57,0,1,450,
1368,1,449,1390,19,
1391,4,96,111,0,
98,0,106,0,101,
0,99,0,116,0,
82,0,111,0,108,
0,101,0,69,0,
120,0,112,0,114,
0,50,0,95,0,
56,0,97,0,53,
0,52,0,53,0,
53,0,97,0,55,
0,52,0,101,0,
52,0,98,0,52,
0,101,0,56,0,
101,0,56,0,50,
0,56,0,51,0,
55,0,97,0,49,
0,48,0,56,0,
49,0,57,0,56,
0,101,0,48,0,
99,0,100,0,1,
449,1392,5,13,1,
1588,1393,16,0,340,
1,1623,1394,16,0,
330,1,29,1395,16,
0,887,1,27,1396,
16,0,740,1,25,
1397,16,0,740,1,
1761,1398,16,0,740,
1,203,1399,16,0,
740,1,534,1400,16,
0,500,1,1642,1401,
16,0,740,1,1604,
1402,16,0,345,1,
1639,1403,16,0,740,
1,1674,1404,16,0,
340,1,1741,1405,16,
0,740,1,448,1406,
19,1407,4,96,111,
0,98,0,106,0,
101,0,99,0,116,
0,82,0,111,0,
108,0,101,0,69,
0,120,0,112,0,
114,0,50,0,95,
0,49,0,50,0,
49,0,53,0,102,
0,100,0,56,0,
100,0,51,0,52,
0,57,0,102,0,
52,0,56,0,49,
0,53,0,98,0,
50,0,49,0,56,
0,53,0,55,0,
54,0,51,0,48,
0,48,0,97,0,
99,0,52,0,49,
0,50,0,97,0,
1,448,1392,1,447,
1408,19,1409,4,96,
111,0,98,0,106,
0,101,0,99,0,
116,0,82,0,111,
0,108,0,101,0,
69,0,120,0,112,
0,114,0,50,0,
95,0,48,0,98,
0,50,0,57,0,
49,0,102,0,99,
0,57,0,56,0,
53,0,97,0,48,
0,52,0,52,0,
100,0,98,0,98,
0,50,0,53,0,
98,0,100,0,54,
0,99,0,101,0,
53,0,55,0,102,
0,52,0,101,0,
54,0,57,0,52,
0,1,447,1392,1,
446,1410,19,1411,4,
96,111,0,98,0,
106,0,101,0,99,
0,116,0,82,0,
111,0,108,0,101,
0,69,0,120,0,
112,0,114,0,50,
0,95,0,52,0,
53,0,54,0,51,
0,99,0,97,0,
56,0,52,0,98,
0,57,0,97,0,
53,0,52,0,57,
0,57,0,100,0,
57,0,100,0,48,
0,98,0,52,0,
54,0,53,0,54,
0,52,0,97,0,
52,0,56,0,101,
0,57,0,53,0,
100,0,1,446,1392,
1,445,1412,19,1413,
4,96,111,0,98,
0,106,0,101,0,
99,0,116,0,82,
0,111,0,108,0,
101,0,69,0,120,
0,112,0,114,0,
49,0,95,0,51,
0,54,0,99,0,
102,0,48,0,101,
0,48,0,49,0,
50,0,49,0,51,
0,102,0,52,0,
100,0,48,0,53,
0,97,0,57,0,
48,0,50,0,56,
0,56,0,54,0,
52,0,57,0,102,
0,98,0,99,0,
50,0,57,0,56,
0,97,0,1,445,
1392,1,444,1414,19,
1415,4,96,111,0,
98,0,106,0,101,
0,99,0,116,0,
82,0,111,0,108,
0,101,0,69,0,
120,0,112,0,114,
0,51,0,95,0,
101,0,102,0,100,
0,50,0,101,0,
50,0,48,0,53,
0,57,0,55,0,
48,0,56,0,52,
0,102,0,97,0,
49,0,56,0,97,
0,54,0,48,0,
56,0,98,0,102,
0,50,0,101,0,
101,0,98,0,100,
0,97,0,101,0,
101,0,48,0,1,
444,1392,1,443,1416,
19,1417,4,96,111,
0,98,0,106,0,
101,0,99,0,116,
0,82,0,111,0,
108,0,101,0,69,
0,120,0,112,0,
114,0,50,0,95,
0,57,0,50,0,
52,0,101,0,52,
0,51,0,102,0,
57,0,102,0,49,
0,50,0,99,0,
52,0,55,0,100,
0,51,0,57,0,
102,0,51,0,56,
0,57,0,98,0,
56,0,52,0,50,
0,49,0,56,0,
99,0,51,0,57,
0,98,0,50,0,
1,443,1392,1,442,
1418,19,1419,4,96,
111,0,98,0,106,
0,101,0,99,0,
116,0,82,0,111,
0,108,0,101,0,
69,0,120,0,112,
0,114,0,50,0,
95,0,98,0,101,
0,102,0,54,0,
50,0,101,0,99,
0,53,0,98,0,
100,0,51,0,100,
0,52,0,54,0,
54,0,97,0,56,
0,53,0,49,0,
101,0,97,0,100,
0,98,0,57,0,
57,0,99,0,100,
0,102,0,102,0,
53,0,102,0,54,
0,1,442,1392,1,
441,1420,19,1421,4,
96,111,0,98,0,
106,0,101,0,99,
0,116,0,82,0,
111,0,108,0,101,
0,69,0,120,0,
112,0,114,0,50,
0,95,0,57,0,
49,0,54,0,53,
0,52,0,56,0,
99,0,48,0,53,
0,52,0,57,0,
99,0,52,0,101,
0,51,0,51,0,
57,0,50,0,99,
0,55,0,100,0,
57,0,55,0,55,
0,50,0,48,0,
55,0,48,0,51,
0,51,0,54,0,
52,0,1,441,1392,
1,440,1422,19,1423,
4,96,111,0,98,
0,106,0,101,0,
99,0,116,0,82,
0,111,0,108,0,
101,0,69,0,120,
0,112,0,114,0,
49,0,95,0,52,
0,52,0,55,0,
101,0,53,0,54,
0,97,0,51,0,
56,0,53,0,52,
0,49,0,52,0,
54,0,99,0,101,
0,57,0,53,0,
48,0,54,0,100,
0,55,0,56,0,
48,0,102,0,49,
0,48,0,97,0,
49,0,98,0,97,
0,51,0,1,440,
1392,1,439,1424,19,
1425,4,74,114,0,
111,0,108,0,101,
0,95,0,49,0,
100,0,100,0,52,
0,56,0,100,0,
54,0,99,0,98,
0,101,0,57,0,
53,0,52,0,57,
0,98,0,48,0,
56,0,52,0,101,
0,54,0,51,0,
100,0,98,0,99,
0,102,0,51,0,
97,0,49,0,97,
0,97,0,56,0,
49,0,1,439,1426,
5,22,1,553,1427,
16,0,483,1,1551,
1428,16,0,298,1,
1715,1429,16,0,249,
1,1623,1430,16,0,
636,1,25,1431,16,
0,636,1,29,1432,
16,0,636,1,27,
1433,16,0,636,1,
1724,1434,16,0,240,
1,1542,1435,16,0,
817,1,1761,1436,16,
0,636,1,1556,1437,
16,0,405,1,203,
1438,16,0,636,1,
534,1439,16,0,636,
1,1642,1440,16,0,
636,1,1604,1441,16,
0,636,1,1639,1442,
16,0,636,1,565,
1443,16,0,476,1,
1674,1444,16,0,636,
1,1524,1445,16,0,
526,1,1588,1446,16,
0,636,1,1741,1447,
16,0,636,1,1517,
1448,16,0,422,1,
438,1449,19,1450,4,
74,114,0,111,0,
108,0,101,0,95,
0,49,0,57,0,
100,0,101,0,51,
0,51,0,54,0,
98,0,57,0,102,
0,55,0,102,0,
52,0,49,0,54,
0,48,0,56,0,
57,0,54,0,57,
0,51,0,51,0,
52,0,51,0,53,
0,101,0,52,0,
102,0,98,0,50,
0,57,0,97,0,
1,438,1426,1,437,
1451,19,1452,4,150,
109,0,111,0,100,
0,97,0,108,0,
105,0,116,0,121,
0,50,0,95,0,
54,0,53,0,99,
0,52,0,102,0,
53,0,52,0,50,
0,100,0,100,0,
98,0,100,0,52,
0,101,0,49,0,
56,0,98,0,99,
0,98,0,48,0,
56,0,100,0,102,
0,97,0,55,0,
102,0,56,0,57,
0,101,0,102,0,
99,0,54,0,95,
0,49,0,55,0,
100,0,51,0,57,
0,56,0,100,0,
54,0,54,0,49,
0,102,0,98,0,
52,0,100,0,53,
0,50,0,56,0,
102,0,48,0,57,
0,98,0,98,0,
54,0,98,0,98,
0,97,0,98,0,
49,0,52,0,53,
0,48,0,102,0,
1,437,1453,5,1,
1,1394,1454,16,0,
455,1,436,1455,19,
1456,4,84,109,0,
111,0,100,0,97,
0,108,0,105,0,
116,0,121,0,50,
0,95,0,54,0,
53,0,99,0,52,
0,102,0,53,0,
52,0,50,0,100,
0,100,0,98,0,
100,0,52,0,101,
0,49,0,56,0,
98,0,99,0,98,
0,48,0,56,0,
100,0,102,0,97,
0,55,0,102,0,
56,0,57,0,101,
0,102,0,99,0,
54,0,1,436,1453,
1,435,1457,19,1458,
4,84,109,0,111,
0,100,0,97,0,
108,0,105,0,116,
0,121,0,50,0,
95,0,100,0,49,
0,48,0,56,0,
50,0,101,0,98,
0,55,0,57,0,
53,0,48,0,57,
0,52,0,99,0,
52,0,50,0,98,
0,50,0,50,0,
48,0,97,0,99,
0,99,0,48,0,
101,0,56,0,53,
0,49,0,50,0,
51,0,50,0,56,
0,1,435,1453,1,
434,1459,19,1460,4,
150,109,0,111,0,
100,0,97,0,108,
0,105,0,116,0,
121,0,50,0,95,
0,97,0,57,0,
57,0,48,0,51,
0,98,0,98,0,
55,0,53,0,56,
0,48,0,50,0,
52,0,53,0,98,
0,53,0,56,0,
56,0,51,0,48,
0,54,0,48,0,
97,0,100,0,98,
0,52,0,49,0,
99,0,102,0,51,
0,101,0,55,0,
95,0,53,0,57,
0,55,0,56,0,
102,0,55,0,56,
0,49,0,54,0,
54,0,53,0,99,
0,52,0,54,0,
102,0,53,0,56,
0,57,0,56,0,
100,0,50,0,54,
0,49,0,50,0,
51,0,102,0,55,
0,51,0,99,0,
55,0,100,0,97,
0,1,434,1453,1,
433,1461,19,1462,4,
84,109,0,111,0,
100,0,97,0,108,
0,105,0,116,0,
121,0,50,0,95,
0,97,0,57,0,
57,0,48,0,51,
0,98,0,98,0,
55,0,53,0,56,
0,48,0,50,0,
52,0,53,0,98,
0,53,0,56,0,
56,0,51,0,48,
0,54,0,48,0,
97,0,100,0,98,
0,52,0,49,0,
99,0,102,0,51,
0,101,0,55,0,
1,433,1453,1,432,
1463,19,1464,4,84,
109,0,111,0,100,
0,97,0,108,0,
105,0,116,0,121,
0,50,0,95,0,
51,0,57,0,101,
0,56,0,52,0,
52,0,57,0,51,
0,102,0,55,0,
48,0,99,0,52,
0,52,0,101,0,
52,0,98,0,49,
0,48,0,51,0,
102,0,56,0,49,
0,101,0,54,0,
49,0,100,0,102,
0,55,0,49,0,
52,0,54,0,1,
432,1453,1,431,1465,
19,1466,4,148,109,
0,111,0,100,0,
97,0,108,0,105,
0,116,0,121,0,
95,0,50,0,57,
0,57,0,52,0,
57,0,56,0,53,
0,100,0,48,0,
99,0,100,0,99,
0,52,0,100,0,
55,0,52,0,98,
0,100,0,101,0,
56,0,49,0,52,
0,53,0,55,0,
48,0,99,0,50,
0,57,0,56,0,
98,0,51,0,49,
0,95,0,53,0,
49,0,97,0,49,
0,101,0,52,0,
57,0,54,0,55,
0,101,0,98,0,
52,0,52,0,48,
0,51,0,98,0,
97,0,50,0,101,
0,100,0,102,0,
102,0,98,0,54,
0,99,0,52,0,
49,0,50,0,55,
0,101,0,98,0,
100,0,1,431,1467,
5,4,1,1637,1468,
16,0,324,1,1739,
1469,16,0,220,1,
1759,1470,16,0,192,
1,1585,1471,16,0,
367,1,430,1472,19,
1473,4,82,109,0,
111,0,100,0,97,
0,108,0,105,0,
116,0,121,0,95,
0,50,0,57,0,
57,0,52,0,57,
0,56,0,53,0,
100,0,48,0,99,
0,100,0,99,0,
52,0,100,0,55,
0,52,0,98,0,
100,0,101,0,56,
0,49,0,52,0,
53,0,55,0,48,
0,99,0,50,0,
57,0,56,0,98,
0,51,0,49,0,
1,430,1467,1,429,
1474,19,1475,4,82,
109,0,111,0,100,
0,97,0,108,0,
105,0,116,0,121,
0,95,0,97,0,
50,0,98,0,55,
0,50,0,101,0,
54,0,56,0,56,
0,102,0,56,0,
53,0,52,0,97,
0,48,0,53,0,
98,0,53,0,50,
0,56,0,53,0,
98,0,48,0,100,
0,97,0,102,0,
101,0,102,0,54,
0,53,0,48,0,
49,0,1,429,1467,
1,428,1476,19,1477,
4,148,109,0,111,
0,100,0,97,0,
108,0,105,0,116,
0,121,0,95,0,
56,0,102,0,54,
0,57,0,98,0,
99,0,50,0,56,
0,50,0,54,0,
101,0,49,0,52,
0,97,0,54,0,
52,0,98,0,54,
0,53,0,53,0,
101,0,49,0,100,
0,54,0,52,0,
100,0,52,0,57,
0,55,0,97,0,
55,0,53,0,95,
0,54,0,101,0,
55,0,100,0,49,
0,99,0,53,0,
99,0,98,0,57,
0,53,0,99,0,
52,0,57,0,53,
0,56,0,56,0,
54,0,99,0,97,
0,99,0,50,0,
52,0,99,0,54,
0,99,0,53,0,
48,0,53,0,99,
0,57,0,101,0,
1,428,1467,1,427,
1478,19,1479,4,82,
109,0,111,0,100,
0,97,0,108,0,
105,0,116,0,121,
0,95,0,56,0,
102,0,54,0,57,
0,98,0,99,0,
50,0,56,0,50,
0,54,0,101,0,
49,0,52,0,97,
0,54,0,52,0,
98,0,54,0,53,
0,53,0,101,0,
49,0,100,0,54,
0,52,0,100,0,
52,0,57,0,55,
0,97,0,55,0,
53,0,1,427,1467,
1,426,1480,19,1481,
4,82,109,0,111,
0,100,0,97,0,
108,0,105,0,116,
0,121,0,95,0,
52,0,49,0,56,
0,97,0,55,0,
57,0,55,0,101,
0,51,0,51,0,
102,0,56,0,52,
0,49,0,53,0,
48,0,57,0,48,
0,98,0,56,0,
99,0,99,0,98,
0,57,0,99,0,
102,0,50,0,55,
0,101,0,48,0,
99,0,97,0,1,
426,1467,1,425,1482,
19,1483,4,94,115,
0,117,0,98,0,
106,0,101,0,99,
0,116,0,78,0,
111,0,116,0,104,
0,105,0,110,0,
103,0,95,0,55,
0,97,0,49,0,
48,0,97,0,56,
0,98,0,101,0,
48,0,98,0,51,
0,49,0,52,0,
49,0,98,0,52,
0,57,0,57,0,
51,0,54,0,56,
0,55,0,56,0,
99,0,102,0,97,
0,51,0,99,0,
50,0,51,0,57,
0,51,0,1,425,
1484,5,2,1,1780,
1485,16,0,221,1,
0,1486,16,0,221,
1,424,1487,19,1488,
4,84,115,0,117,
0,98,0,106,0,
101,0,99,0,116,
0,78,0,111,0,
95,0,51,0,97,
0,97,0,48,0,
101,0,51,0,50,
0,51,0,56,0,
50,0,52,0,53,
0,52,0,56,0,
98,0,97,0,97,
0,101,0,57,0,
97,0,99,0,98,
0,57,0,56,0,
56,0,100,0,98,
0,52,0,49,0,
102,0,52,0,55,
0,1,424,1484,1,
423,1489,19,1490,4,
86,115,0,117,0,
98,0,106,0,101,
0,99,0,116,0,
84,0,104,0,101,
0,95,0,54,0,
53,0,48,0,56,
0,100,0,52,0,
102,0,102,0,50,
0,98,0,51,0,
57,0,52,0,54,
0,54,0,57,0,
57,0,102,0,51,
0,97,0,102,0,
48,0,52,0,55,
0,100,0,55,0,
50,0,101,0,54,
0,48,0,101,0,
54,0,1,423,1491,
5,2,1,1780,1492,
16,0,195,1,0,
1493,16,0,195,1,
422,1494,19,1495,4,
86,115,0,117,0,
98,0,106,0,101,
0,99,0,116,0,
84,0,104,0,101,
0,95,0,53,0,
57,0,98,0,50,
0,57,0,101,0,
102,0,57,0,97,
0,97,0,98,0,
102,0,52,0,99,
0,48,0,56,0,
56,0,55,0,102,
0,49,0,97,0,
50,0,52,0,102,
0,98,0,53,0,
51,0,48,0,56,
0,55,0,52,0,
101,0,1,422,1491,
1,421,1496,19,1497,
4,94,115,0,117,
0,98,0,106,0,
101,0,99,0,116,
0,66,0,105,0,
103,0,78,0,97,
0,109,0,101,0,
95,0,101,0,50,
0,52,0,55,0,
55,0,48,0,57,
0,102,0,97,0,
100,0,52,0,102,
0,52,0,54,0,
101,0,56,0,97,
0,102,0,54,0,
98,0,53,0,57,
0,56,0,97,0,
99,0,52,0,101,
0,54,0,57,0,
101,0,100,0,57,
0,1,421,1491,1,
420,1498,19,1499,4,
94,115,0,117,0,
98,0,106,0,101,
0,99,0,116,0,
66,0,105,0,103,
0,78,0,97,0,
109,0,101,0,95,
0,100,0,51,0,
53,0,99,0,100,
0,55,0,52,0,
99,0,48,0,48,
0,49,0,48,0,
52,0,50,0,56,
0,48,0,57,0,
101,0,99,0,98,
0,55,0,99,0,
48,0,52,0,55,
0,101,0,101,0,
57,0,54,0,99,
0,48,0,51,0,
1,420,1491,1,419,
1500,19,1501,4,100,
115,0,117,0,98,
0,106,0,101,0,
99,0,116,0,69,
0,118,0,101,0,
114,0,121,0,116,
0,104,0,105,0,
110,0,103,0,95,
0,100,0,56,0,
100,0,48,0,102,
0,56,0,102,0,
49,0,100,0,48,
0,101,0,55,0,
52,0,54,0,50,
0,99,0,56,0,
100,0,49,0,102,
0,54,0,55,0,
55,0,51,0,100,
0,54,0,53,0,
54,0,101,0,56,
0,100,0,51,0,
1,419,1491,1,418,
1502,19,1503,4,100,
115,0,117,0,98,
0,106,0,101,0,
99,0,116,0,69,
0,118,0,101,0,
114,0,121,0,116,
0,104,0,105,0,
110,0,103,0,95,
0,101,0,97,0,
102,0,101,0,101,
0,48,0,53,0,
53,0,48,0,51,
0,54,0,97,0,
52,0,102,0,57,
0,51,0,97,0,
50,0,53,0,99,
0,56,0,52,0,
48,0,100,0,52,
0,98,0,49,0,
52,0,48,0,48,
0,98,0,56,0,
1,418,1491,1,417,
1504,19,1505,4,90,
115,0,117,0,98,
0,106,0,101,0,
99,0,116,0,69,
0,118,0,101,0,
114,0,121,0,95,
0,57,0,97,0,
57,0,100,0,55,
0,48,0,51,0,
55,0,55,0,98,
0,54,0,100,0,
52,0,98,0,98,
0,100,0,98,0,
49,0,57,0,55,
0,54,0,99,0,
102,0,102,0,48,
0,52,0,56,0,
52,0,100,0,100,
0,50,0,99,0,
1,417,1491,1,416,
1506,19,1507,4,96,
97,0,110,0,100,
0,97,0,110,0,
121,0,114,0,111,
0,108,0,101,0,
99,0,104,0,97,
0,105,0,110,0,
95,0,97,0,101,
0,57,0,48,0,
53,0,56,0,56,
0,55,0,98,0,
57,0,48,0,52,
0,52,0,55,0,
48,0,57,0,56,
0,57,0,48,0,
102,0,98,0,51,
0,55,0,98,0,
102,0,102,0,102,
0,49,0,102,0,
55,0,100,0,50,
0,1,416,1508,5,
1,1,548,1509,16,
0,494,1,415,1510,
19,1511,4,96,97,
0,110,0,100,0,
97,0,110,0,121,
0,114,0,111,0,
108,0,101,0,99,
0,104,0,97,0,
105,0,110,0,95,
0,48,0,102,0,
98,0,48,0,98,
0,102,0,48,0,
50,0,56,0,48,
0,101,0,97,0,
52,0,57,0,55,
0,102,0,97,0,
48,0,57,0,56,
0,55,0,100,0,
54,0,99,0,55,
0,102,0,51,0,
52,0,57,0,53,
0,97,0,56,0,
1,415,1508,1,414,
1512,19,1513,4,96,
97,0,110,0,100,
0,97,0,110,0,
121,0,114,0,111,
0,108,0,101,0,
99,0,104,0,97,
0,105,0,110,0,
95,0,101,0,100,
0,97,0,98,0,
56,0,56,0,98,
0,57,0,54,0,
52,0,98,0,51,
0,52,0,49,0,
53,0,101,0,97,
0,54,0,52,0,
97,0,55,0,55,
0,101,0,51,0,
50,0,57,0,100,
0,50,0,49,0,
102,0,50,0,98,
0,1,414,1508,1,
413,1514,19,1515,4,
96,97,0,110,0,
100,0,97,0,110,
0,121,0,114,0,
111,0,108,0,101,
0,99,0,104,0,
97,0,105,0,110,
0,95,0,57,0,
99,0,98,0,53,
0,49,0,51,0,
99,0,57,0,56,
0,50,0,49,0,
50,0,52,0,56,
0,49,0,48,0,
56,0,55,0,55,
0,101,0,102,0,
102,0,97,0,101,
0,99,0,100,0,
57,0,48,0,49,
0,98,0,48,0,
53,0,1,413,1508,
1,412,1516,19,1517,
4,92,110,0,111,
0,116,0,82,0,
111,0,108,0,101,
0,87,0,105,0,
116,0,104,0,88,
0,89,0,95,0,
53,0,50,0,99,
0,98,0,50,0,
53,0,57,0,50,
0,48,0,101,0,
98,0,100,0,52,
0,55,0,100,0,
102,0,57,0,52,
0,52,0,50,0,
48,0,98,0,56,
0,101,0,57,0,
55,0,98,0,98,
0,50,0,97,0,
49,0,57,0,1,
412,1518,5,1,1,
1570,1519,16,0,377,
1,411,1520,19,1521,
4,92,110,0,111,
0,116,0,82,0,
111,0,108,0,101,
0,87,0,105,0,
116,0,104,0,88,
0,89,0,95,0,
98,0,54,0,52,
0,101,0,52,0,
100,0,102,0,97,
0,49,0,100,0,
51,0,54,0,52,
0,56,0,102,0,
50,0,98,0,97,
0,49,0,99,0,
98,0,54,0,50,
0,49,0,100,0,
57,0,51,0,56,
0,52,0,50,0,
99,0,52,0,1,
411,1518,1,410,1522,
19,1523,4,86,114,
0,111,0,108,0,
101,0,87,0,105,
0,116,0,104,0,
88,0,89,0,95,
0,53,0,99,0,
49,0,49,0,98,
0,101,0,51,0,
55,0,53,0,49,
0,100,0,55,0,
52,0,102,0,50,
0,102,0,97,0,
102,0,99,0,100,
0,49,0,99,0,
49,0,100,0,99,
0,52,0,49,0,
100,0,99,0,48,
0,54,0,57,0,
1,410,1524,5,3,
1,1734,1525,16,0,
225,1,1531,1526,16,
0,679,1,1570,1527,
16,0,375,1,409,
1528,19,1529,4,86,
114,0,111,0,108,
0,101,0,87,0,
105,0,116,0,104,
0,88,0,89,0,
95,0,98,0,98,
0,53,0,100,0,
54,0,102,0,102,
0,55,0,57,0,
98,0,98,0,99,
0,52,0,48,0,
100,0,102,0,56,
0,52,0,56,0,
55,0,99,0,102,
0,48,0,100,0,
54,0,49,0,57,
0,101,0,50,0,
50,0,101,0,55,
0,1,409,1524,1,
408,1530,19,1531,4,
108,111,0,114,0,
79,0,98,0,106,
0,101,0,99,0,
116,0,82,0,111,
0,108,0,101,0,
69,0,120,0,112,
0,114,0,67,0,
104,0,97,0,105,
0,110,0,95,0,
49,0,50,0,56,
0,48,0,57,0,
51,0,50,0,102,
0,101,0,100,0,
52,0,52,0,52,
0,97,0,48,0,
100,0,98,0,98,
0,101,0,54,0,
54,0,51,0,53,
0,55,0,97,0,
48,0,57,0,53,
0,98,0,99,0,
57,0,56,0,1,
408,1532,5,2,1,
1588,1533,16,0,477,
1,1674,1534,16,0,
279,1,407,1535,19,
1536,4,108,111,0,
114,0,79,0,98,
0,106,0,101,0,
99,0,116,0,82,
0,111,0,108,0,
101,0,69,0,120,
0,112,0,114,0,
67,0,104,0,97,
0,105,0,110,0,
95,0,53,0,102,
0,99,0,53,0,
53,0,54,0,56,
0,55,0,102,0,
53,0,98,0,98,
0,52,0,56,0,
53,0,56,0,57,
0,49,0,56,0,
50,0,55,0,56,
0,54,0,98,0,
57,0,55,0,97,
0,49,0,57,0,
57,0,99,0,56,
0,1,407,1532,1,
406,1537,19,1538,4,
76,99,0,104,0,
97,0,105,0,110,
0,95,0,53,0,
100,0,97,0,98,
0,97,0,53,0,
99,0,101,0,50,
0,49,0,53,0,
49,0,52,0,98,
0,55,0,98,0,
56,0,100,0,55,
0,99,0,100,0,
56,0,50,0,49,
0,101,0,55,0,
99,0,52,0,53,
0,100,0,52,0,
101,0,1,406,1539,
5,1,1,1517,1540,
16,0,576,1,405,
1541,19,1542,4,76,
99,0,104,0,97,
0,105,0,110,0,
95,0,102,0,49,
0,100,0,49,0,
101,0,56,0,52,
0,55,0,57,0,
102,0,97,0,98,
0,52,0,53,0,
50,0,53,0,97,
0,56,0,98,0,
51,0,97,0,52,
0,57,0,99,0,
50,0,49,0,56,
0,53,0,97,0,
99,0,102,0,100,
0,1,405,1539,1,
404,1543,19,1544,4,
82,100,0,97,0,
116,0,101,0,116,
0,105,0,109,0,
101,0,95,0,57,
0,100,0,49,0,
55,0,53,0,98,
0,100,0,55,0,
101,0,56,0,48,
0,57,0,52,0,
56,0,99,0,99,
0,98,0,53,0,
55,0,51,0,57,
0,56,0,55,0,
99,0,52,0,51,
0,49,0,50,0,
101,0,56,0,51,
0,49,0,1,404,
1545,5,2,1,593,
1546,16,0,819,1,
1358,1547,16,0,819,
1,403,1548,19,1549,
4,82,100,0,97,
0,116,0,101,0,
116,0,105,0,109,
0,101,0,95,0,
48,0,99,0,53,
0,53,0,99,0,
53,0,51,0,54,
0,52,0,51,0,
50,0,57,0,52,
0,55,0,98,0,
99,0,57,0,53,
0,98,0,49,0,
99,0,48,0,53,
0,52,0,48,0,
101,0,54,0,53,
0,57,0,99,0,
55,0,51,0,1,
403,1545,1,402,1550,
19,1551,4,86,100,
0,117,0,114,0,
97,0,116,0,105,
0,111,0,110,0,
95,0,109,0,95,
0,102,0,48,0,
48,0,56,0,48,
0,98,0,50,0,
54,0,48,0,57,
0,54,0,101,0,
52,0,53,0,56,
0,48,0,97,0,
100,0,55,0,99,
0,102,0,54,0,
53,0,49,0,101,
0,55,0,51,0,
52,0,52,0,55,
0,55,0,97,0,
1,402,1552,5,2,
1,593,1553,16,0,
811,1,1358,1554,16,
0,811,1,401,1555,
19,1556,4,86,100,
0,117,0,114,0,
97,0,116,0,105,
0,111,0,110,0,
95,0,109,0,95,
0,56,0,98,0,
99,0,50,0,57,
0,99,0,50,0,
51,0,102,0,97,
0,48,0,102,0,
52,0,49,0,52,
0,100,0,57,0,
102,0,97,0,53,
0,50,0,49,0,
52,0,102,0,98,
0,101,0,98,0,
100,0,52,0,97,
0,100,0,97,0,
1,401,1552,1,400,
1557,19,1558,4,86,
100,0,117,0,114,
0,97,0,116,0,
105,0,111,0,110,
0,95,0,109,0,
95,0,102,0,53,
0,49,0,52,0,
49,0,48,0,97,
0,48,0,102,0,
101,0,53,0,102,
0,52,0,102,0,
50,0,55,0,98,
0,97,0,57,0,
49,0,52,0,100,
0,98,0,55,0,
99,0,100,0,98,
0,49,0,52,0,
49,0,99,0,55,
0,1,400,1552,1,
399,1559,19,1560,4,
86,100,0,117,0,
114,0,97,0,116,
0,105,0,111,0,
110,0,95,0,109,
0,95,0,100,0,
57,0,57,0,102,
0,57,0,99,0,
56,0,55,0,99,
0,98,0,56,0,
102,0,52,0,57,
0,54,0,55,0,
56,0,54,0,51,
0,56,0,101,0,
99,0,54,0,57,
0,56,0,57,0,
52,0,99,0,102,
0,49,0,101,0,
100,0,1,399,1552,
1,398,1561,19,1562,
4,86,100,0,117,
0,114,0,97,0,
116,0,105,0,111,
0,110,0,95,0,
109,0,95,0,51,
0,50,0,99,0,
54,0,102,0,52,
0,56,0,56,0,
54,0,55,0,99,
0,51,0,52,0,
54,0,48,0,102,
0,98,0,102,0,
54,0,49,0,56,
0,97,0,48,0,
55,0,54,0,101,
0,97,0,98,0,
56,0,101,0,55,
0,51,0,1,398,
1552,1,397,1563,19,
1564,4,86,100,0,
117,0,114,0,97,
0,116,0,105,0,
111,0,110,0,95,
0,109,0,95,0,
57,0,53,0,52,
0,101,0,48,0,
97,0,56,0,54,
0,48,0,49,0,
53,0,50,0,52,
0,98,0,102,0,
99,0,98,0,56,
0,100,0,100,0,
48,0,50,0,100,
0,100,0,52,0,
48,0,100,0,97,
0,55,0,49,0,
51,0,56,0,1,
397,1552,1,396,1565,
19,1566,4,86,100,
0,117,0,114,0,
97,0,116,0,105,
0,111,0,110,0,
95,0,109,0,95,
0,99,0,52,0,
50,0,99,0,99,
0,57,0,52,0,
48,0,57,0,51,
0,99,0,100,0,
52,0,51,0,56,
0,57,0,98,0,
97,0,48,0,50,
0,101,0,55,0,
50,0,51,0,54,
0,99,0,49,0,
50,0,97,0,99,
0,97,0,55,0,
1,396,1552,1,395,
1567,19,1568,4,86,
100,0,117,0,114,
0,97,0,116,0,
105,0,111,0,110,
0,95,0,109,0,
95,0,54,0,99,
0,49,0,49,0,
57,0,52,0,49,
0,102,0,52,0,
53,0,52,0,56,
0,52,0,51,0,
56,0,51,0,56,
0,55,0,52,0,
53,0,52,0,97,
0,57,0,54,0,
48,0,49,0,50,
0,50,0,53,0,
98,0,101,0,51,
0,1,395,1552,1,
394,1569,19,1570,4,
86,100,0,117,0,
114,0,97,0,116,
0,105,0,111,0,
110,0,95,0,109,
0,95,0,55,0,
48,0,52,0,55,
0,97,0,52,0,
102,0,100,0,54,
0,101,0,51,0,
55,0,52,0,56,
0,56,0,99,0,
98,0,51,0,100,
0,54,0,101,0,
53,0,50,0,57,
0,57,0,49,0,
101,0,55,0,52,
0,54,0,55,0,
55,0,1,394,1552,
1,393,1571,19,1572,
4,86,100,0,117,
0,114,0,97,0,
116,0,105,0,111,
0,110,0,95,0,
109,0,95,0,53,
0,53,0,97,0,
102,0,98,0,100,
0,53,0,54,0,
56,0,49,0,54,
0,97,0,52,0,
100,0,49,0,50,
0,98,0,57,0,
97,0,99,0,49,
0,48,0,56,0,
97,0,51,0,102,
0,50,0,99,0,
99,0,56,0,99,
0,102,0,1,393,
1552,1,392,1573,19,
1574,4,88,98,0,
117,0,105,0,108,
0,116,0,105,0,
110,0,95,0,101,
0,120,0,101,0,
95,0,51,0,56,
0,100,0,99,0,
99,0,49,0,51,
0,54,0,57,0,
53,0,98,0,55,
0,52,0,53,0,
48,0,50,0,57,
0,54,0,55,0,
51,0,102,0,54,
0,98,0,102,0,
52,0,51,0,99,
0,99,0,101,0,
55,0,97,0,54,
0,1,392,1575,5,
2,1,593,1576,16,
0,632,1,1358,1577,
16,0,632,1,391,
1578,19,1579,4,92,
98,0,117,0,105,
0,108,0,116,0,
105,0,110,0,95,
0,97,0,110,0,
110,0,111,0,116,
0,95,0,100,0,
49,0,51,0,101,
0,55,0,50,0,
100,0,100,0,55,
0,99,0,57,0,
97,0,52,0,52,
0,53,0,57,0,
98,0,100,0,48,
0,98,0,49,0,
54,0,101,0,56,
0,99,0,101,0,
55,0,53,0,53,
0,57,0,101,0,
51,0,1,391,1575,
1,390,1580,19,1581,
4,92,98,0,117,
0,105,0,108,0,
116,0,105,0,110,
0,95,0,97,0,
108,0,112,0,104,
0,97,0,95,0,
97,0,101,0,102,
0,49,0,99,0,
54,0,102,0,55,
0,50,0,97,0,
48,0,53,0,52,
0,57,0,54,0,
48,0,98,0,100,
0,99,0,101,0,
52,0,52,0,56,
0,102,0,52,0,
97,0,56,0,52,
0,102,0,51,0,
97,0,48,0,1,
390,1575,1,389,1582,
19,1583,4,98,98,
0,117,0,105,0,
108,0,116,0,105,
0,110,0,95,0,
100,0,97,0,116,
0,101,0,116,0,
105,0,109,0,101,
0,95,0,50,0,
102,0,52,0,50,
0,48,0,49,0,
100,0,52,0,52,
0,101,0,98,0,
97,0,52,0,102,
0,100,0,49,0,
97,0,48,0,48,
0,49,0,52,0,
98,0,57,0,56,
0,50,0,49,0,
52,0,56,0,97,
0,57,0,57,0,
102,0,1,389,1575,
1,388,1584,19,821,
1,388,1545,1,387,
1585,19,1586,4,98,
98,0,117,0,105,
0,108,0,116,0,
105,0,110,0,95,
0,100,0,117,0,
114,0,97,0,116,
0,105,0,111,0,
110,0,95,0,98,
0,97,0,49,0,
48,0,101,0,101,
0,54,0,52,0,
48,0,54,0,98,
0,55,0,52,0,
102,0,101,0,54,
0,97,0,48,0,
48,0,101,0,97,
0,56,0,48,0,
50,0,102,0,51,
0,48,0,55,0,
50,0,53,0,49,
0,54,0,1,387,
1575,1,386,1587,19,
1588,4,92,98,0,
117,0,105,0,108,
0,116,0,105,0,
110,0,95,0,116,
0,114,0,97,0,
110,0,115,0,95,
0,101,0,49,0,
52,0,50,0,54,
0,50,0,51,0,
51,0,50,0,52,
0,54,0,49,0,
52,0,53,0,48,
0,97,0,57,0,
53,0,101,0,98,
0,97,0,50,0,
56,0,53,0,57,
0,97,0,49,0,
50,0,57,0,99,
0,54,0,54,0,
1,386,1575,1,385,
1589,19,1590,4,94,
98,0,117,0,105,
0,108,0,116,0,
105,0,110,0,95,
0,115,0,117,0,
98,0,115,0,116,
0,114,0,95,0,
54,0,98,0,50,
0,56,0,54,0,
101,0,101,0,54,
0,51,0,98,0,
55,0,48,0,52,
0,48,0,50,0,
99,0,56,0,48,
0,51,0,100,0,
98,0,102,0,99,
0,55,0,55,0,
49,0,97,0,51,
0,100,0,56,0,
55,0,56,0,1,
385,1575,1,384,1591,
19,1592,4,94,98,
0,117,0,105,0,
108,0,116,0,105,
0,110,0,95,0,
115,0,117,0,98,
0,115,0,116,0,
114,0,95,0,97,
0,48,0,55,0,
49,0,102,0,49,
0,54,0,98,0,
99,0,51,0,54,
0,57,0,52,0,
97,0,53,0,100,
0,97,0,52,0,
53,0,55,0,51,
0,49,0,100,0,
57,0,56,0,55,
0,50,0,51,0,
102,0,50,0,57,
0,99,0,1,384,
1575,1,383,1593,19,
1594,4,94,98,0,
117,0,105,0,108,
0,116,0,105,0,
110,0,95,0,115,
0,117,0,98,0,
115,0,116,0,114,
0,95,0,51,0,
99,0,51,0,50,
0,102,0,48,0,
55,0,49,0,49,
0,51,0,57,0,
98,0,52,0,98,
0,55,0,101,0,
57,0,50,0,54,
0,50,0,99,0,
48,0,55,0,102,
0,53,0,101,0,
56,0,100,0,48,
0,56,0,54,0,
101,0,1,383,1575,
1,382,1595,19,1596,
4,102,98,0,117,
0,105,0,108,0,
116,0,105,0,110,
0,95,0,117,0,
110,0,97,0,114,
0,121,0,95,0,
102,0,114,0,101,
0,101,0,95,0,
49,0,50,0,57,
0,99,0,57,0,
54,0,56,0,55,
0,102,0,54,0,
51,0,55,0,52,
0,49,0,102,0,
57,0,56,0,50,
0,97,0,97,0,
51,0,102,0,100,
0,54,0,53,0,
98,0,49,0,100,
0,48,0,98,0,
101,0,48,0,1,
382,1575,1,381,1597,
19,1598,4,100,98,
0,117,0,105,0,
108,0,116,0,105,
0,110,0,95,0,
117,0,110,0,97,
0,114,0,121,0,
95,0,99,0,109,
0,112,0,95,0,
102,0,52,0,50,
0,51,0,52,0,
50,0,97,0,50,
0,99,0,55,0,
101,0,55,0,52,
0,49,0,53,0,
51,0,98,0,100,
0,54,0,102,0,
97,0,100,0,57,
0,49,0,50,0,
49,0,54,0,52,
0,97,0,48,0,
57,0,101,0,1,
381,1575,1,380,1599,
19,1600,4,88,98,
0,117,0,105,0,
108,0,116,0,105,
0,110,0,95,0,
98,0,105,0,110,
0,95,0,101,0,
57,0,55,0,51,
0,53,0,57,0,
54,0,102,0,52,
0,53,0,48,0,
101,0,52,0,56,
0,49,0,52,0,
97,0,98,0,53,
0,48,0,51,0,
56,0,48,0,50,
0,100,0,49,0,
56,0,51,0,97,
0,50,0,100,0,
50,0,1,380,1575,
1,379,1601,19,1602,
4,90,98,0,117,
0,105,0,108,0,
116,0,105,0,110,
0,95,0,108,0,
105,0,115,0,116,
0,95,0,101,0,
52,0,56,0,97,
0,98,0,55,0,
51,0,102,0,51,
0,52,0,52,0,
51,0,52,0,48,
0,98,0,55,0,
98,0,55,0,98,
0,102,0,49,0,
48,0,53,0,55,
0,53,0,54,0,
97,0,97,0,97,
0,54,0,56,0,
49,0,1,379,1575,
1,378,1603,19,1604,
4,90,98,0,117,
0,105,0,108,0,
116,0,105,0,110,
0,95,0,108,0,
105,0,115,0,116,
0,95,0,57,0,
100,0,97,0,52,
0,100,0,51,0,
54,0,99,0,51,
0,102,0,97,0,
48,0,52,0,57,
0,98,0,51,0,
98,0,99,0,50,
0,50,0,99,0,
57,0,102,0,54,
0,49,0,51,0,
102,0,100,0,49,
0,57,0,54,0,
57,0,1,378,1575,
1,377,1605,19,1606,
4,90,98,0,117,
0,105,0,108,0,
116,0,105,0,110,
0,95,0,108,0,
105,0,115,0,116,
0,95,0,49,0,
102,0,49,0,102,
0,50,0,49,0,
53,0,100,0,52,
0,55,0,51,0,
101,0,52,0,48,
0,102,0,98,0,
97,0,99,0,51,
0,99,0,50,0,
101,0,97,0,49,
0,57,0,48,0,
98,0,100,0,56,
0,55,0,53,0,
102,0,1,377,1575,
1,376,1607,19,1608,
4,88,98,0,117,
0,105,0,108,0,
116,0,105,0,110,
0,95,0,99,0,
109,0,112,0,95,
0,57,0,52,0,
54,0,100,0,55,
0,100,0,52,0,
56,0,99,0,52,
0,54,0,49,0,
52,0,100,0,53,
0,102,0,57,0,
55,0,57,0,52,
0,97,0,52,0,
48,0,53,0,56,
0,100,0,53,0,
57,0,50,0,56,
0,51,0,49,0,
1,376,1575,1,375,
1609,19,1610,4,142,
117,0,110,0,79,
0,112,0,50,0,
95,0,97,0,54,
0,102,0,52,0,
52,0,102,0,51,
0,55,0,52,0,
100,0,52,0,54,
0,52,0,56,0,
55,0,98,0,57,
0,51,0,97,0,
100,0,51,0,55,
0,51,0,51,0,
100,0,51,0,99,
0,54,0,56,0,
97,0,54,0,99,
0,95,0,98,0,
97,0,55,0,102,
0,52,0,57,0,
101,0,98,0,52,
0,97,0,51,0,
98,0,52,0,56,
0,52,0,97,0,
57,0,97,0,54,
0,100,0,54,0,
48,0,54,0,97,
0,102,0,49,0,
53,0,50,0,55,
0,98,0,101,0,
57,0,1,375,1611,
5,1,1,672,1612,
16,0,302,1,374,
1613,19,1614,4,76,
117,0,110,0,79,
0,112,0,50,0,
95,0,97,0,54,
0,102,0,52,0,
52,0,102,0,51,
0,55,0,52,0,
100,0,52,0,54,
0,52,0,56,0,
55,0,98,0,57,
0,51,0,97,0,
100,0,51,0,55,
0,51,0,51,0,
100,0,51,0,99,
0,54,0,56,0,
97,0,54,0,99,
0,1,374,1611,1,
373,1615,19,1616,4,
76,117,0,110,0,
79,0,112,0,50,
0,95,0,53,0,
101,0,50,0,57,
0,100,0,101,0,
51,0,54,0,48,
0,53,0,56,0,
97,0,52,0,55,
0,50,0,98,0,
56,0,101,0,56,
0,52,0,55,0,
51,0,54,0,101,
0,54,0,54,0,
51,0,49,0,101,
0,102,0,49,0,
101,0,1,373,1611,
1,372,1617,19,304,
1,372,1611,1,371,
1618,19,1619,4,140,
117,0,110,0,79,
0,112,0,95,0,
55,0,98,0,55,
0,100,0,57,0,
48,0,97,0,55,
0,98,0,98,0,
57,0,49,0,52,
0,51,0,57,0,
101,0,57,0,97,
0,57,0,57,0,
97,0,57,0,55,
0,99,0,57,0,
98,0,54,0,56,
0,97,0,97,0,
97,0,51,0,95,
0,48,0,51,0,
50,0,97,0,50,
0,56,0,55,0,
100,0,100,0,98,
0,50,0,49,0,
52,0,52,0,49,
0,57,0,98,0,
56,0,102,0,100,
0,49,0,48,0,
57,0,99,0,54,
0,49,0,54,0,
100,0,52,0,97,
0,57,0,48,0,
1,371,1620,5,2,
1,593,1621,16,0,
712,1,1358,1622,16,
0,712,1,370,1623,
19,1624,4,74,117,
0,110,0,79,0,
112,0,95,0,55,
0,98,0,55,0,
100,0,57,0,48,
0,97,0,55,0,
98,0,98,0,57,
0,49,0,52,0,
51,0,57,0,101,
0,57,0,97,0,
57,0,57,0,97,
0,57,0,55,0,
99,0,57,0,98,
0,54,0,56,0,
97,0,97,0,97,
0,51,0,1,370,
1620,1,369,1625,19,
1626,4,74,117,0,
110,0,79,0,112,
0,95,0,97,0,
53,0,54,0,101,
0,54,0,99,0,
57,0,48,0,97,
0,56,0,101,0,
50,0,52,0,99,
0,48,0,57,0,
97,0,55,0,48,
0,57,0,100,0,
50,0,57,0,98,
0,97,0,57,0,
54,0,52,0,54,
0,52,0,101,0,
52,0,1,369,1620,
1,368,1627,19,1628,
4,140,117,0,110,
0,79,0,112,0,
95,0,98,0,50,
0,57,0,102,0,
98,0,51,0,57,
0,97,0,56,0,
97,0,50,0,99,
0,52,0,97,0,
100,0,54,0,98,
0,50,0,55,0,
52,0,57,0,56,
0,49,0,102,0,
56,0,97,0,50,
0,50,0,49,0,
51,0,54,0,99,
0,95,0,100,0,
101,0,102,0,101,
0,101,0,99,0,
54,0,100,0,51,
0,101,0,57,0,
48,0,52,0,57,
0,50,0,51,0,
98,0,51,0,100,
0,99,0,98,0,
55,0,100,0,97,
0,97,0,52,0,
101,0,52,0,51,
0,97,0,100,0,
49,0,1,368,1620,
1,367,1629,19,1630,
4,74,117,0,110,
0,79,0,112,0,
95,0,98,0,50,
0,57,0,102,0,
98,0,51,0,57,
0,97,0,56,0,
97,0,50,0,99,
0,52,0,97,0,
100,0,54,0,98,
0,50,0,55,0,
52,0,57,0,56,
0,49,0,102,0,
56,0,97,0,50,
0,50,0,49,0,
51,0,54,0,99,
0,1,367,1620,1,
366,1631,19,1632,4,
74,117,0,110,0,
79,0,112,0,95,
0,102,0,98,0,
102,0,100,0,48,
0,48,0,51,0,
100,0,50,0,99,
0,49,0,48,0,
52,0,55,0,56,
0,102,0,57,0,
56,0,51,0,57,
0,50,0,99,0,
50,0,48,0,55,
0,49,0,102,0,
99,0,54,0,98,
0,51,0,48,0,
1,366,1620,1,365,
1633,19,1634,4,140,
117,0,110,0,79,
0,112,0,95,0,
99,0,55,0,52,
0,101,0,101,0,
52,0,49,0,56,
0,53,0,51,0,
97,0,102,0,52,
0,100,0,48,0,
56,0,56,0,57,
0,55,0,98,0,
48,0,56,0,98,
0,50,0,49,0,
97,0,56,0,98,
0,48,0,52,0,
98,0,98,0,95,
0,102,0,50,0,
52,0,54,0,99,
0,101,0,97,0,
49,0,101,0,100,
0,51,0,57,0,
52,0,51,0,57,
0,54,0,56,0,
50,0,52,0,97,
0,55,0,101,0,
55,0,97,0,50,
0,100,0,97,0,
52,0,55,0,54,
0,48,0,57,0,
1,365,1620,1,364,
1635,19,1636,4,74,
117,0,110,0,79,
0,112,0,95,0,
99,0,55,0,52,
0,101,0,101,0,
52,0,49,0,56,
0,53,0,51,0,
97,0,102,0,52,
0,100,0,48,0,
56,0,56,0,57,
0,55,0,98,0,
48,0,56,0,98,
0,50,0,49,0,
97,0,56,0,98,
0,48,0,52,0,
98,0,98,0,1,
364,1620,1,363,1637,
19,1638,4,74,117,
0,110,0,79,0,
112,0,95,0,99,
0,52,0,99,0,
99,0,97,0,97,
0,100,0,49,0,
55,0,51,0,56,
0,49,0,52,0,
100,0,100,0,57,
0,56,0,52,0,
57,0,98,0,49,
0,99,0,48,0,
50,0,100,0,51,
0,101,0,52,0,
102,0,99,0,101,
0,54,0,1,363,
1620,1,362,1639,19,
1640,4,140,117,0,
110,0,79,0,112,
0,95,0,52,0,
53,0,99,0,50,
0,54,0,50,0,
48,0,100,0,99,
0,51,0,55,0,
52,0,52,0,97,
0,48,0,55,0,
57,0,56,0,98,
0,56,0,56,0,
98,0,101,0,50,
0,53,0,57,0,
97,0,51,0,49,
0,51,0,51,0,
101,0,95,0,52,
0,57,0,54,0,
54,0,102,0,48,
0,50,0,50,0,
55,0,56,0,54,
0,57,0,52,0,
53,0,54,0,49,
0,57,0,97,0,
98,0,56,0,98,
0,97,0,99,0,
53,0,100,0,99,
0,49,0,99,0,
52,0,100,0,97,
0,55,0,1,362,
1620,1,361,1641,19,
1642,4,74,117,0,
110,0,79,0,112,
0,95,0,52,0,
53,0,99,0,50,
0,54,0,50,0,
48,0,100,0,99,
0,51,0,55,0,
52,0,52,0,97,
0,48,0,55,0,
57,0,56,0,98,
0,56,0,56,0,
98,0,101,0,50,
0,53,0,57,0,
97,0,51,0,49,
0,51,0,51,0,
101,0,1,361,1620,
1,360,1643,19,1644,
4,74,117,0,110,
0,79,0,112,0,
95,0,53,0,56,
0,48,0,97,0,
54,0,48,0,100,
0,52,0,100,0,
49,0,100,0,53,
0,52,0,97,0,
49,0,99,0,57,
0,99,0,56,0,
102,0,53,0,99,
0,57,0,48,0,
48,0,49,0,101,
0,56,0,49,0,
56,0,98,0,49,
0,1,360,1620,1,
359,1645,19,714,1,
359,1620,1,358,1646,
19,1647,4,142,98,
0,105,0,110,0,
79,0,112,0,95,
0,98,0,98,0,
57,0,99,0,49,
0,55,0,50,0,
57,0,56,0,51,
0,98,0,55,0,
52,0,56,0,98,
0,57,0,56,0,
53,0,55,0,53,
0,53,0,52,0,
51,0,49,0,57,
0,101,0,54,0,
100,0,52,0,48,
0,98,0,98,0,
95,0,55,0,50,
0,102,0,50,0,
49,0,102,0,55,
0,57,0,51,0,
101,0,98,0,49,
0,52,0,53,0,
97,0,55,0,97,
0,100,0,49,0,
56,0,56,0,53,
0,99,0,53,0,
52,0,97,0,53,
0,53,0,53,0,
54,0,56,0,51,
0,1,358,1648,5,
1,1,672,1649,16,
0,288,1,357,1650,
19,1651,4,76,98,
0,105,0,110,0,
79,0,112,0,95,
0,98,0,98,0,
57,0,99,0,49,
0,55,0,50,0,
57,0,56,0,51,
0,98,0,55,0,
52,0,56,0,98,
0,57,0,56,0,
53,0,55,0,53,
0,53,0,52,0,
51,0,49,0,57,
0,101,0,54,0,
100,0,52,0,48,
0,98,0,98,0,
1,357,1648,1,356,
1652,19,1653,4,76,
98,0,105,0,110,
0,79,0,112,0,
95,0,100,0,52,
0,101,0,99,0,
55,0,102,0,50,
0,53,0,56,0,
49,0,102,0,54,
0,52,0,102,0,
98,0,52,0,56,
0,98,0,51,0,
99,0,53,0,48,
0,100,0,49,0,
101,0,100,0,102,
0,100,0,98,0,
99,0,101,0,52,
0,1,356,1648,1,
355,1654,19,1655,4,
142,98,0,105,0,
110,0,79,0,112,
0,95,0,100,0,
101,0,99,0,100,
0,54,0,50,0,
54,0,49,0,51,
0,99,0,48,0,
102,0,52,0,102,
0,55,0,102,0,
97,0,102,0,101,
0,51,0,56,0,
53,0,55,0,54,
0,55,0,100,0,
97,0,57,0,57,
0,102,0,98,0,
52,0,95,0,55,
0,97,0,56,0,
51,0,97,0,57,
0,54,0,56,0,
102,0,56,0,56,
0,57,0,52,0,
57,0,57,0,53,
0,98,0,51,0,
102,0,50,0,101,
0,49,0,51,0,
97,0,52,0,51,
0,101,0,56,0,
102,0,57,0,102,
0,48,0,1,355,
1648,1,354,1656,19,
1657,4,76,98,0,
105,0,110,0,79,
0,112,0,95,0,
100,0,101,0,99,
0,100,0,54,0,
50,0,54,0,49,
0,51,0,99,0,
48,0,102,0,52,
0,102,0,55,0,
102,0,97,0,102,
0,101,0,51,0,
56,0,53,0,55,
0,54,0,55,0,
100,0,97,0,57,
0,57,0,102,0,
98,0,52,0,1,
354,1648,1,353,1658,
19,1659,4,76,98,
0,105,0,110,0,
79,0,112,0,95,
0,97,0,55,0,
98,0,50,0,51,
0,100,0,57,0,
98,0,99,0,52,
0,49,0,48,0,
52,0,50,0,57,
0,102,0,56,0,
50,0,97,0,57,
0,57,0,49,0,
102,0,50,0,48,
0,48,0,49,0,
99,0,57,0,53,
0,98,0,50,0,
1,353,1648,1,352,
1660,19,1661,4,142,
98,0,105,0,110,
0,79,0,112,0,
95,0,100,0,48,
0,51,0,99,0,
98,0,50,0,57,
0,51,0,50,0,
99,0,56,0,101,
0,52,0,102,0,
48,0,97,0,98,
0,56,0,48,0,
57,0,53,0,50,
0,56,0,54,0,
49,0,50,0,51,
0,102,0,54,0,
55,0,57,0,55,
0,95,0,54,0,
100,0,48,0,49,
0,51,0,51,0,
55,0,50,0,55,
0,56,0,54,0,
98,0,52,0,101,
0,55,0,50,0,
57,0,52,0,101,
0,55,0,48,0,
55,0,51,0,54,
0,57,0,98,0,
49,0,56,0,55,
0,102,0,51,0,
57,0,1,352,1648,
1,351,1662,19,1663,
4,76,98,0,105,
0,110,0,79,0,
112,0,95,0,100,
0,48,0,51,0,
99,0,98,0,50,
0,57,0,51,0,
50,0,99,0,56,
0,101,0,52,0,
102,0,48,0,97,
0,98,0,56,0,
48,0,57,0,53,
0,50,0,56,0,
54,0,49,0,50,
0,51,0,102,0,
54,0,55,0,57,
0,55,0,1,351,
1648,1,350,1664,19,
1665,4,76,98,0,
105,0,110,0,79,
0,112,0,95,0,
54,0,55,0,102,
0,52,0,99,0,
97,0,53,0,55,
0,97,0,48,0,
98,0,51,0,52,
0,50,0,56,0,
100,0,57,0,50,
0,53,0,55,0,
48,0,101,0,50,
0,102,0,49,0,
50,0,55,0,55,
0,100,0,97,0,
50,0,99,0,1,
350,1648,1,349,1666,
19,290,1,349,1648,
1,348,1667,19,1668,
4,112,100,0,97,
0,116,0,97,0,
118,0,97,0,108,
0,101,0,114,0,
70,0,111,0,108,
0,108,0,111,0,
119,0,101,0,100,
0,66,0,121,0,
76,0,105,0,115,
0,116,0,95,0,
51,0,49,0,51,
0,53,0,56,0,
99,0,102,0,55,
0,98,0,52,0,
54,0,56,0,52,
0,49,0,98,0,
53,0,98,0,48,
0,48,0,55,0,
57,0,48,0,52,
0,102,0,49,0,
53,0,99,0,56,
0,101,0,49,0,
49,0,51,0,1,
348,1669,5,2,1,
593,1670,16,0,695,
1,1358,1671,16,0,
695,1,347,1672,19,
1673,4,112,100,0,
97,0,116,0,97,
0,118,0,97,0,
108,0,101,0,114,
0,70,0,111,0,
108,0,108,0,111,
0,119,0,101,0,
100,0,66,0,121,
0,76,0,105,0,
115,0,116,0,95,
0,102,0,54,0,
54,0,97,0,53,
0,101,0,102,0,
56,0,53,0,57,
0,53,0,53,0,
52,0,56,0,102,
0,50,0,56,0,
101,0,101,0,99,
0,102,0,50,0,
50,0,53,0,102,
0,101,0,101,0,
49,0,52,0,54,
0,101,0,100,0,
1,347,1669,1,346,
1674,19,1675,4,102,
100,0,97,0,116,
0,97,0,118,0,
97,0,108,0,101,
0,114,0,84,0,
105,0,109,0,101,
0,115,0,76,0,
105,0,115,0,116,
0,95,0,98,0,
50,0,55,0,101,
0,99,0,49,0,
53,0,56,0,53,
0,52,0,99,0,
50,0,52,0,97,
0,99,0,56,0,
57,0,55,0,51,
0,51,0,55,0,
51,0,52,0,99,
0,102,0,55,0,
55,0,48,0,55,
0,50,0,100,0,
50,0,1,346,1676,
5,2,1,593,1677,
16,0,681,1,1358,
1678,16,0,681,1,
345,1679,19,1680,4,
102,100,0,97,0,
116,0,97,0,118,
0,97,0,108,0,
101,0,114,0,84,
0,105,0,109,0,
101,0,115,0,76,
0,105,0,115,0,
116,0,95,0,102,
0,53,0,97,0,
53,0,100,0,51,
0,56,0,51,0,
48,0,50,0,53,
0,55,0,52,0,
100,0,51,0,50,
0,56,0,50,0,
102,0,101,0,100,
0,101,0,48,0,
99,0,56,0,48,
0,100,0,52,0,
50,0,99,0,52,
0,53,0,1,345,
1676,1,344,1681,19,
1682,4,100,100,0,
97,0,116,0,97,
0,118,0,97,0,
108,0,101,0,114,
0,80,0,108,0,
117,0,115,0,76,
0,105,0,115,0,
116,0,95,0,49,
0,48,0,50,0,
55,0,100,0,52,
0,100,0,55,0,
97,0,49,0,100,
0,52,0,52,0,
102,0,50,0,52,
0,56,0,99,0,
98,0,98,0,55,
0,52,0,57,0,
97,0,55,0,98,
0,56,0,51,0,
55,0,57,0,99,
0,52,0,1,344,
1683,5,2,1,593,
1684,16,0,436,1,
1358,1685,16,0,436,
1,343,1686,19,1687,
4,100,100,0,97,
0,116,0,97,0,
118,0,97,0,108,
0,101,0,114,0,
80,0,108,0,117,
0,115,0,76,0,
105,0,115,0,116,
0,95,0,99,0,
102,0,57,0,54,
0,97,0,100,0,
101,0,97,0,98,
0,97,0,99,0,
54,0,52,0,97,
0,52,0,102,0,
57,0,55,0,54,
0,56,0,50,0,
55,0,48,0,101,
0,52,0,102,0,
55,0,98,0,52,
0,51,0,97,0,
53,0,1,343,1683,
1,342,1688,19,1689,
4,146,101,0,113,
0,117,0,97,0,
108,0,84,0,111,
0,95,0,48,0,
50,0,101,0,49,
0,48,0,50,0,
57,0,54,0,51,
0,49,0,98,0,
102,0,52,0,98,
0,55,0,48,0,
57,0,97,0,52,
0,54,0,57,0,
100,0,102,0,48,
0,51,0,100,0,
51,0,55,0,101,
0,99,0,48,0,
49,0,95,0,97,
0,98,0,48,0,
54,0,56,0,51,
0,99,0,55,0,
51,0,98,0,49,
0,101,0,52,0,
55,0,54,0,49,
0,57,0,98,0,
49,0,50,0,56,
0,50,0,52,0,
101,0,53,0,49,
0,98,0,100,0,
56,0,57,0,51,
0,56,0,1,342,
1690,5,14,1,1183,
1691,16,0,287,1,
1167,1692,16,0,708,
1,876,1693,16,0,
160,1,1208,1694,16,
0,680,1,762,1695,
16,0,282,1,1056,
1696,16,0,782,1,
1126,1697,16,0,757,
1,1016,1698,16,0,
810,1,978,1699,16,
0,329,1,940,1700,
16,0,899,1,1233,
1701,16,0,655,1,
1117,1702,16,0,731,
1,1002,1703,16,0,
818,1,1093,1704,16,
0,763,1,341,1705,
19,1706,4,80,101,
0,113,0,117,0,
97,0,108,0,84,
0,111,0,95,0,
48,0,50,0,101,
0,49,0,48,0,
50,0,57,0,54,
0,51,0,49,0,
98,0,102,0,52,
0,98,0,55,0,
48,0,57,0,97,
0,52,0,54,0,
57,0,100,0,102,
0,48,0,51,0,
100,0,51,0,55,
0,101,0,99,0,
48,0,49,0,1,
341,1690,1,340,1707,
19,1708,4,80,101,
0,113,0,117,0,
97,0,108,0,84,
0,111,0,95,0,
100,0,55,0,51,
0,48,0,49,0,
101,0,51,0,99,
0,100,0,99,0,
48,0,56,0,52,
0,99,0,50,0,
102,0,57,0,55,
0,97,0,53,0,
57,0,52,0,53,
0,51,0,56,0,
100,0,51,0,56,
0,57,0,53,0,
102,0,55,0,1,
340,1690,1,339,1709,
19,1710,4,146,101,
0,113,0,117,0,
97,0,108,0,84,
0,111,0,95,0,
100,0,97,0,49,
0,97,0,53,0,
99,0,101,0,52,
0,101,0,102,0,
97,0,102,0,52,
0,55,0,57,0,
101,0,56,0,57,
0,100,0,57,0,
57,0,50,0,97,
0,51,0,49,0,
51,0,51,0,55,
0,50,0,48,0,
98,0,55,0,95,
0,99,0,55,0,
55,0,99,0,99,
0,99,0,48,0,
102,0,53,0,54,
0,51,0,101,0,
52,0,98,0,101,
0,98,0,57,0,
53,0,101,0,57,
0,99,0,51,0,
50,0,51,0,100,
0,54,0,55,0,
55,0,50,0,97,
0,100,0,55,0,
1,339,1690,1,338,
1711,19,1712,4,80,
101,0,113,0,117,
0,97,0,108,0,
84,0,111,0,95,
0,100,0,97,0,
49,0,97,0,53,
0,99,0,101,0,
52,0,101,0,102,
0,97,0,102,0,
52,0,55,0,57,
0,101,0,56,0,
57,0,100,0,57,
0,57,0,50,0,
97,0,51,0,49,
0,51,0,51,0,
55,0,50,0,48,
0,98,0,55,0,
1,338,1690,1,337,
1713,19,1714,4,80,
101,0,113,0,117,
0,97,0,108,0,
84,0,111,0,95,
0,98,0,99,0,
53,0,48,0,97,
0,51,0,52,0,
97,0,52,0,50,
0,50,0,100,0,
52,0,53,0,100,
0,99,0,57,0,
102,0,56,0,97,
0,97,0,97,0,
98,0,57,0,101,
0,51,0,99,0,
56,0,57,0,100,
0,102,0,54,0,
1,337,1690,1,336,
1715,19,162,1,336,
1690,1,335,1716,19,
1717,4,150,99,0,
111,0,109,0,112,
0,97,0,114,0,
101,0,114,0,50,
0,95,0,49,0,
49,0,101,0,49,
0,48,0,54,0,
101,0,99,0,55,
0,51,0,53,0,
55,0,52,0,101,
0,48,0,100,0,
56,0,56,0,53,
0,51,0,97,0,
100,0,50,0,57,
0,100,0,102,0,
98,0,51,0,101,
0,100,0,56,0,
101,0,95,0,50,
0,55,0,98,0,
50,0,57,0,48,
0,97,0,52,0,
56,0,101,0,102,
0,53,0,52,0,
53,0,99,0,49,
0,56,0,52,0,
56,0,102,0,100,
0,54,0,102,0,
51,0,52,0,48,
0,98,0,102,0,
56,0,50,0,51,
0,57,0,1,335,
1718,5,1,1,672,
1719,16,0,271,1,
334,1720,19,1721,4,
84,99,0,111,0,
109,0,112,0,97,
0,114,0,101,0,
114,0,50,0,95,
0,49,0,49,0,
101,0,49,0,48,
0,54,0,101,0,
99,0,55,0,51,
0,53,0,55,0,
52,0,101,0,48,
0,100,0,56,0,
56,0,53,0,51,
0,97,0,100,0,
50,0,57,0,100,
0,102,0,98,0,
51,0,101,0,100,
0,56,0,101,0,
1,334,1718,1,333,
1722,19,1723,4,84,
99,0,111,0,109,
0,112,0,97,0,
114,0,101,0,114,
0,50,0,95,0,
99,0,101,0,49,
0,97,0,54,0,
102,0,102,0,56,
0,101,0,50,0,
55,0,55,0,52,
0,56,0,51,0,
99,0,57,0,54,
0,102,0,57,0,
55,0,52,0,48,
0,99,0,55,0,
101,0,51,0,53,
0,99,0,98,0,
55,0,57,0,1,
333,1718,1,332,1724,
19,1725,4,150,99,
0,111,0,109,0,
112,0,97,0,114,
0,101,0,114,0,
50,0,95,0,52,
0,54,0,57,0,
99,0,98,0,57,
0,99,0,53,0,
102,0,51,0,53,
0,97,0,52,0,
56,0,55,0,56,
0,98,0,56,0,
52,0,98,0,55,
0,53,0,51,0,
101,0,100,0,53,
0,97,0,97,0,
54,0,97,0,49,
0,97,0,95,0,
100,0,97,0,102,
0,50,0,99,0,
57,0,99,0,54,
0,101,0,53,0,
99,0,56,0,52,
0,50,0,50,0,
97,0,57,0,101,
0,55,0,49,0,
55,0,56,0,50,
0,97,0,100,0,
54,0,51,0,102,
0,49,0,97,0,
102,0,52,0,1,
332,1718,1,331,1726,
19,1727,4,84,99,
0,111,0,109,0,
112,0,97,0,114,
0,101,0,114,0,
50,0,95,0,52,
0,54,0,57,0,
99,0,98,0,57,
0,99,0,53,0,
102,0,51,0,53,
0,97,0,52,0,
56,0,55,0,56,
0,98,0,56,0,
52,0,98,0,55,
0,53,0,51,0,
101,0,100,0,53,
0,97,0,97,0,
54,0,97,0,49,
0,97,0,1,331,
1718,1,330,1728,19,
1729,4,84,99,0,
111,0,109,0,112,
0,97,0,114,0,
101,0,114,0,50,
0,95,0,97,0,
101,0,50,0,51,
0,99,0,101,0,
54,0,49,0,102,
0,56,0,101,0,
100,0,52,0,55,
0,51,0,100,0,
98,0,57,0,49,
0,48,0,102,0,
99,0,101,0,55,
0,51,0,50,0,
52,0,56,0,49,
0,102,0,54,0,
51,0,1,330,1718,
1,329,1730,19,1731,
4,150,99,0,111,
0,109,0,112,0,
97,0,114,0,101,
0,114,0,50,0,
95,0,50,0,49,
0,52,0,52,0,
48,0,54,0,100,
0,55,0,51,0,
48,0,101,0,55,
0,52,0,53,0,
100,0,102,0,57,
0,102,0,55,0,
51,0,52,0,101,
0,49,0,48,0,
57,0,50,0,57,
0,48,0,97,0,
100,0,55,0,55,
0,95,0,100,0,
99,0,51,0,51,
0,53,0,57,0,
54,0,52,0,48,
0,100,0,100,0,
48,0,52,0,100,
0,98,0,49,0,
57,0,48,0,98,
0,102,0,53,0,
51,0,97,0,98,
0,98,0,54,0,
54,0,102,0,100,
0,101,0,57,0,
97,0,1,329,1718,
1,328,1732,19,1733,
4,84,99,0,111,
0,109,0,112,0,
97,0,114,0,101,
0,114,0,50,0,
95,0,50,0,49,
0,52,0,52,0,
48,0,54,0,100,
0,55,0,51,0,
48,0,101,0,55,
0,52,0,53,0,
100,0,102,0,57,
0,102,0,55,0,
51,0,52,0,101,
0,49,0,48,0,
57,0,50,0,57,
0,48,0,97,0,
100,0,55,0,55,
0,1,328,1718,1,
327,1734,19,1735,4,
84,99,0,111,0,
109,0,112,0,97,
0,114,0,101,0,
114,0,50,0,95,
0,54,0,98,0,
101,0,53,0,100,
0,49,0,57,0,
55,0,53,0,102,
0,52,0,97,0,
52,0,54,0,102,
0,100,0,57,0,
52,0,99,0,50,
0,102,0,48,0,
56,0,100,0,97,
0,55,0,100,0,
55,0,97,0,57,
0,99,0,102,0,
1,327,1718,1,326,
1736,19,1737,4,150,
99,0,111,0,109,
0,112,0,97,0,
114,0,101,0,114,
0,50,0,95,0,
101,0,100,0,98,
0,51,0,100,0,
48,0,48,0,53,
0,56,0,48,0,
56,0,97,0,52,
0,50,0,49,0,
52,0,57,0,56,
0,49,0,48,0,
49,0,56,0,53,
0,57,0,53,0,
50,0,50,0,48,
0,56,0,102,0,
99,0,53,0,95,
0,56,0,101,0,
51,0,99,0,52,
0,54,0,52,0,
98,0,51,0,99,
0,49,0,100,0,
52,0,102,0,100,
0,56,0,98,0,
97,0,49,0,101,
0,54,0,57,0,
53,0,49,0,102,
0,49,0,53,0,
99,0,55,0,97,
0,57,0,101,0,
1,326,1718,1,325,
1738,19,1739,4,84,
99,0,111,0,109,
0,112,0,97,0,
114,0,101,0,114,
0,50,0,95,0,
101,0,100,0,98,
0,51,0,100,0,
48,0,48,0,53,
0,56,0,48,0,
56,0,97,0,52,
0,50,0,49,0,
52,0,57,0,56,
0,49,0,48,0,
49,0,56,0,53,
0,57,0,53,0,
50,0,50,0,48,
0,56,0,102,0,
99,0,53,0,1,
325,1718,1,324,1740,
19,1741,4,84,99,
0,111,0,109,0,
112,0,97,0,114,
0,101,0,114,0,
50,0,95,0,52,
0,50,0,55,0,
52,0,57,0,100,
0,50,0,48,0,
52,0,52,0,55,
0,49,0,52,0,
98,0,52,0,100,
0,56,0,101,0,
101,0,49,0,57,
0,56,0,102,0,
51,0,98,0,101,
0,56,0,53,0,
57,0,50,0,48,
0,54,0,1,324,
1718,1,323,1742,19,
1743,4,150,99,0,
111,0,109,0,112,
0,97,0,114,0,
101,0,114,0,50,
0,95,0,98,0,
48,0,102,0,101,
0,54,0,55,0,
54,0,101,0,57,
0,55,0,55,0,
51,0,52,0,102,
0,49,0,98,0,
97,0,53,0,53,
0,101,0,97,0,
55,0,50,0,51,
0,49,0,102,0,
51,0,53,0,98,
0,56,0,98,0,
99,0,95,0,52,
0,56,0,102,0,
54,0,52,0,98,
0,49,0,99,0,
101,0,51,0,48,
0,50,0,52,0,
101,0,97,0,52,
0,97,0,56,0,
55,0,98,0,55,
0,100,0,48,0,
97,0,52,0,97,
0,48,0,55,0,
97,0,52,0,102,
0,54,0,1,323,
1718,1,322,1744,19,
1745,4,84,99,0,
111,0,109,0,112,
0,97,0,114,0,
101,0,114,0,50,
0,95,0,98,0,
48,0,102,0,101,
0,54,0,55,0,
54,0,101,0,57,
0,55,0,55,0,
51,0,52,0,102,
0,49,0,98,0,
97,0,53,0,53,
0,101,0,97,0,
55,0,50,0,51,
0,49,0,102,0,
51,0,53,0,98,
0,56,0,98,0,
99,0,1,322,1718,
1,321,1746,19,1747,
4,84,99,0,111,
0,109,0,112,0,
97,0,114,0,101,
0,114,0,50,0,
95,0,53,0,56,
0,55,0,102,0,
102,0,49,0,98,
0,98,0,102,0,
50,0,100,0,97,
0,52,0,101,0,
55,0,100,0,56,
0,98,0,56,0,
56,0,52,0,49,
0,55,0,97,0,
53,0,51,0,99,
0,102,0,98,0,
53,0,101,0,55,
0,1,321,1718,1,
320,1748,19,273,1,
320,1718,1,319,1749,
19,1750,4,86,100,
0,97,0,116,0,
97,0,118,0,97,
0,108,0,118,0,
97,0,108,0,95,
0,98,0,97,0,
102,0,99,0,49,
0,57,0,53,0,
102,0,53,0,54,
0,54,0,53,0,
52,0,56,0,100,
0,55,0,57,0,
54,0,51,0,50,
0,98,0,55,0,
98,0,102,0,50,
0,98,0,57,0,
55,0,100,0,98,
0,51,0,55,0,
1,319,1751,5,52,
1,629,1752,16,0,
407,1,727,1753,16,
0,308,1,709,1754,
16,0,328,1,1220,
1755,16,0,657,1,
794,1756,16,0,248,
1,1245,1757,16,0,
646,1,1057,1758,16,
0,781,1,611,1759,
16,0,424,1,877,
1760,16,0,152,1,
779,1761,16,0,268,
1,1142,1762,16,0,
727,1,695,1763,16,
0,338,1,1048,1764,
16,0,783,1,602,
1765,16,0,433,1,
868,1766,16,0,809,
1,1030,1767,16,0,
548,1,1118,1768,16,
0,741,1,686,1769,
16,0,350,1,1039,
1770,16,0,788,1,
593,1771,16,0,362,
1,979,1772,16,0,
270,1,941,1773,16,
0,269,1,1209,1774,
16,0,805,1,674,
1775,16,0,357,1,
620,1776,16,0,415,
1,1094,1777,16,0,
760,1,1195,1778,16,
0,358,1,754,1779,
16,0,283,1,1109,
1780,16,0,752,1,
1003,1781,16,0,816,
1,929,1782,16,0,
759,1,638,1783,16,
0,401,1,921,1784,
16,0,912,1,1017,
1785,16,0,806,1,
743,1786,16,0,291,
1,1184,1787,16,0,
690,1,763,1788,16,
0,278,1,647,1789,
16,0,390,1,1358,
1790,16,0,362,1,
1446,1791,16,0,504,
1,1398,1792,16,0,
809,1,1085,1793,16,
0,764,1,816,1794,
16,0,216,1,1127,
1795,16,0,359,1,
1168,1796,16,0,594,
1,1076,1797,16,0,
772,1,1234,1798,16,
0,653,1,718,1799,
16,0,315,1,805,
1800,16,0,237,1,
1159,1801,16,0,709,
1,1425,1802,16,0,
525,1,890,1803,16,
0,116,1,318,1804,
19,1805,4,86,100,
0,97,0,116,0,
97,0,118,0,97,
0,108,0,118,0,
97,0,114,0,95,
0,100,0,48,0,
100,0,100,0,101,
0,53,0,101,0,
49,0,56,0,98,
0,56,0,57,0,
52,0,56,0,99,
0,48,0,57,0,
52,0,97,0,102,
0,48,0,53,0,
102,0,101,0,57,
0,54,0,48,0,
102,0,57,0,100,
0,56,0,100,0,
1,318,1751,1,317,
1806,19,1807,4,86,
111,0,98,0,106,
0,101,0,99,0,
116,0,114,0,95,
0,105,0,111,0,
95,0,101,0,101,
0,57,0,57,0,
56,0,51,0,97,
0,55,0,50,0,
51,0,102,0,100,
0,52,0,50,0,
54,0,55,0,97,
0,57,0,50,0,
52,0,56,0,101,
0,100,0,99,0,
50,0,97,0,50,
0,56,0,49,0,
98,0,55,0,98,
0,1,317,1808,5,
8,1,1358,1809,16,
0,631,1,1306,1810,
16,0,316,1,1271,
1811,16,0,621,1,
1336,1812,16,0,579,
1,976,1813,16,0,
710,1,1316,1814,16,
0,592,1,593,1815,
16,0,631,1,938,
1816,16,0,900,1,
316,1817,19,1818,4,
88,111,0,98,0,
106,0,101,0,99,
0,116,0,114,0,
95,0,110,0,105,
0,111,0,95,0,
51,0,101,0,48,
0,100,0,51,0,
56,0,51,0,48,
0,102,0,48,0,
57,0,99,0,52,
0,55,0,56,0,
98,0,57,0,54,
0,52,0,52,0,
52,0,102,0,101,
0,102,0,53,0,
50,0,54,0,100,
0,52,0,101,0,
102,0,50,0,1,
316,1808,1,315,1819,
19,1820,4,84,105,
0,110,0,115,0,
116,0,97,0,110,
0,99,0,101,0,
114,0,95,0,98,
0,50,0,55,0,
54,0,102,0,48,
0,98,0,48,0,
49,0,54,0,48,
0,102,0,52,0,
48,0,100,0,55,
0,56,0,54,0,
101,0,51,0,49,
0,52,0,98,0,
55,0,53,0,50,
0,101,0,98,0,
101,0,49,0,57,
0,53,0,1,315,
1821,5,18,1,938,
1822,16,0,119,1,
1441,1823,16,0,119,
1,1506,1824,16,0,
119,1,1398,1825,16,
0,119,1,1435,1826,
16,0,119,1,1358,
1827,16,0,119,1,
1468,1828,16,0,119,
1,1316,1829,16,0,
119,1,1306,1830,16,
0,119,1,1484,1831,
16,0,119,1,868,
1832,16,0,119,1,
976,1833,16,0,119,
1,1271,1834,16,0,
119,1,1497,1835,16,
0,119,1,1490,1836,
16,0,119,1,1336,
1837,16,0,119,1,
890,1838,16,0,119,
1,593,1839,16,0,
119,1,314,1840,19,
1841,4,84,105,0,
110,0,115,0,116,
0,97,0,110,0,
99,0,101,0,114,
0,95,0,54,0,
55,0,102,0,98,
0,54,0,51,0,
97,0,50,0,50,
0,55,0,54,0,
99,0,52,0,52,
0,99,0,53,0,
56,0,48,0,99,
0,57,0,48,0,
51,0,49,0,56,
0,102,0,97,0,
99,0,56,0,52,
0,98,0,56,0,
56,0,1,314,1821,
1,313,1842,19,1843,
4,98,105,0,100,
0,101,0,110,0,
116,0,111,0,98,
0,106,0,101,0,
99,0,116,0,95,
0,105,0,110,0,
115,0,116,0,95,
0,51,0,56,0,
52,0,49,0,102,
0,55,0,55,0,
102,0,48,0,102,
0,55,0,51,0,
52,0,98,0,99,
0,100,0,56,0,
53,0,51,0,48,
0,54,0,49,0,
49,0,50,0,54,
0,101,0,53,0,
97,0,48,0,55,
0,97,0,101,0,
1,313,1844,5,18,
1,938,1845,16,0,
106,1,1441,1846,16,
0,566,1,1506,1847,
16,0,691,1,1398,
1848,16,0,745,1,
1435,1849,16,0,691,
1,1358,1850,16,0,
106,1,1468,1851,16,
0,363,1,1316,1852,
16,0,106,1,1306,
1853,16,0,106,1,
1484,1854,16,0,711,
1,868,1855,16,0,
745,1,976,1856,16,
0,106,1,1271,1857,
16,0,106,1,1497,
1858,16,0,691,1,
1490,1859,16,0,527,
1,1336,1860,16,0,
106,1,890,1861,16,
0,115,1,593,1862,
16,0,106,1,312,
1863,19,1864,4,98,
105,0,100,0,101,
0,110,0,116,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,95,0,110,
0,97,0,109,0,
101,0,95,0,50,
0,102,0,55,0,
49,0,101,0,99,
0,98,0,55,0,
54,0,100,0,56,
0,49,0,52,0,
53,0,48,0,55,
0,98,0,56,0,
57,0,48,0,56,
0,56,0,48,0,
49,0,54,0,97,
0,102,0,99,0,
55,0,53,0,54,
0,98,0,1,312,
1844,1,311,1865,19,
1866,4,98,105,0,
100,0,101,0,110,
0,116,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
95,0,110,0,97,
0,109,0,101,0,
95,0,100,0,98,
0,54,0,100,0,
102,0,56,0,51,
0,101,0,50,0,
51,0,48,0,102,
0,52,0,99,0,
56,0,51,0,98,
0,48,0,97,0,
51,0,51,0,98,
0,101,0,56,0,
98,0,101,0,53,
0,57,0,99,0,
56,0,101,0,101,
0,1,311,1844,1,
310,1867,19,1868,4,
98,105,0,100,0,
101,0,110,0,116,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,95,0,
110,0,97,0,109,
0,101,0,95,0,
97,0,55,0,52,
0,57,0,57,0,
51,0,99,0,51,
0,101,0,56,0,
101,0,102,0,52,
0,98,0,53,0,
51,0,98,0,52,
0,101,0,51,0,
52,0,49,0,99,
0,101,0,51,0,
97,0,51,0,100,
0,52,0,53,0,
52,0,98,0,1,
310,1844,1,309,1869,
19,1870,4,98,105,
0,100,0,101,0,
110,0,116,0,111,
0,98,0,106,0,
101,0,99,0,116,
0,95,0,110,0,
97,0,109,0,101,
0,95,0,101,0,
55,0,53,0,51,
0,102,0,53,0,
49,0,48,0,99,
0,54,0,51,0,
50,0,52,0,49,
0,53,0,99,0,
97,0,101,0,99,
0,102,0,101,0,
57,0,50,0,102,
0,100,0,102,0,
101,0,48,0,52,
0,49,0,51,0,
50,0,1,309,1844,
1,308,1871,19,1872,
4,94,110,0,111,
0,116,0,105,0,
100,0,101,0,110,
0,116,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
95,0,97,0,51,
0,49,0,57,0,
57,0,55,0,99,
0,48,0,55,0,
53,0,57,0,57,
0,52,0,100,0,
55,0,51,0,57,
0,57,0,99,0,
51,0,54,0,100,
0,52,0,99,0,
102,0,102,0,50,
0,52,0,56,0,
48,0,55,0,51,
0,1,308,1873,5,
8,1,1358,1874,16,
0,765,1,1306,1875,
16,0,765,1,1271,
1876,16,0,765,1,
1336,1877,16,0,765,
1,976,1878,16,0,
765,1,1316,1879,16,
0,765,1,593,1880,
16,0,765,1,938,
1881,16,0,765,1,
307,1882,19,1883,4,
94,110,0,111,0,
116,0,105,0,100,
0,101,0,110,0,
116,0,111,0,98,
0,106,0,101,0,
99,0,116,0,95,
0,98,0,57,0,
52,0,97,0,97,
0,53,0,48,0,
52,0,50,0,98,
0,48,0,98,0,
52,0,99,0,100,
0,48,0,98,0,
55,0,102,0,98,
0,52,0,55,0,
99,0,51,0,49,
0,99,0,100,0,
50,0,49,0,56,
0,56,0,52,0,
1,307,1873,1,306,
1884,19,1885,4,94,
110,0,111,0,116,
0,105,0,100,0,
101,0,110,0,116,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,95,0,
50,0,49,0,49,
0,55,0,56,0,
98,0,50,0,48,
0,49,0,54,0,
101,0,101,0,52,
0,51,0,100,0,
100,0,57,0,98,
0,55,0,56,0,
50,0,56,0,102,
0,55,0,53,0,
52,0,100,0,102,
0,51,0,101,0,
101,0,52,0,1,
306,1873,1,305,1886,
19,1887,4,94,110,
0,111,0,116,0,
105,0,100,0,101,
0,110,0,116,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,95,0,50,
0,57,0,100,0,
55,0,102,0,57,
0,51,0,52,0,
54,0,52,0,98,
0,98,0,52,0,
57,0,101,0,101,
0,57,0,50,0,
52,0,99,0,55,
0,49,0,102,0,
56,0,56,0,52,
0,55,0,53,0,
97,0,100,0,53,
0,52,0,1,305,
1873,1,304,1888,19,
1889,4,80,101,0,
120,0,101,0,97,
0,114,0,103,0,
115,0,95,0,48,
0,57,0,49,0,
57,0,56,0,99,
0,50,0,52,0,
97,0,52,0,99,
0,53,0,52,0,
49,0,55,0,49,
0,98,0,53,0,
52,0,97,0,51,
0,97,0,99,0,
49,0,48,0,51,
0,57,0,57,0,
48,0,100,0,97,
0,48,0,1,304,
1890,5,2,1,868,
1891,16,0,163,1,
1398,1892,16,0,549,
1,303,1893,19,1894,
4,80,101,0,120,
0,101,0,97,0,
114,0,103,0,115,
0,95,0,100,0,
101,0,100,0,98,
0,55,0,98,0,
101,0,51,0,57,
0,55,0,53,0,
49,0,52,0,98,
0,51,0,98,0,
56,0,48,0,51,
0,50,0,57,0,
55,0,56,0,101,
0,52,0,50,0,
57,0,56,0,53,
0,98,0,52,0,
53,0,1,303,1890,
1,302,1895,19,1896,
4,80,101,0,120,
0,101,0,97,0,
114,0,103,0,115,
0,95,0,53,0,
54,0,97,0,49,
0,48,0,57,0,
99,0,56,0,52,
0,57,0,99,0,
97,0,52,0,102,
0,102,0,102,0,
98,0,55,0,99,
0,48,0,52,0,
49,0,100,0,53,
0,100,0,49,0,
98,0,51,0,52,
0,52,0,57,0,
51,0,1,302,1890,
1,301,1897,19,1898,
4,80,101,0,120,
0,101,0,97,0,
114,0,103,0,115,
0,95,0,50,0,
54,0,99,0,54,
0,100,0,102,0,
97,0,52,0,100,
0,53,0,55,0,
97,0,52,0,50,
0,50,0,56,0,
97,0,97,0,102,
0,98,0,49,0,
100,0,100,0,55,
0,48,0,53,0,
54,0,48,0,56,
0,48,0,50,0,
52,0,1,301,1890,
1,300,1899,19,1900,
4,126,99,0,111,
0,110,0,100,0,
105,0,116,0,105,
0,111,0,110,0,
95,0,114,0,101,
0,115,0,117,0,
108,0,116,0,95,
0,100,0,97,0,
116,0,97,0,95,
0,112,0,114,0,
111,0,112,0,101,
0,114,0,116,0,
121,0,95,0,99,
0,100,0,50,0,
50,0,48,0,56,
0,101,0,98,0,
52,0,55,0,53,
0,53,0,52,0,
100,0,48,0,53,
0,97,0,56,0,
56,0,98,0,99,
0,49,0,57,0,
98,0,48,0,101,
0,48,0,102,0,
51,0,53,0,53,
0,55,0,1,300,
1901,5,3,1,1497,
1902,16,0,462,1,
1506,1903,16,0,458,
1,1435,1904,16,0,
458,1,299,1905,19,
1906,4,120,99,0,
111,0,110,0,100,
0,105,0,116,0,
105,0,111,0,110,
0,95,0,114,0,
101,0,115,0,117,
0,108,0,116,0,
95,0,100,0,101,
0,102,0,105,0,
110,0,105,0,116,
0,105,0,111,0,
110,0,95,0,98,
0,102,0,97,0,
51,0,56,0,99,
0,57,0,55,0,
51,0,51,0,56,
0,100,0,52,0,
49,0,50,0,98,
0,56,0,53,0,
49,0,97,0,101,
0,51,0,97,0,
54,0,57,0,98,
0,57,0,99,0,
102,0,98,0,57,
0,50,0,1,299,
1901,1,298,1907,19,
1908,4,104,99,0,
111,0,110,0,100,
0,105,0,116,0,
105,0,111,0,110,
0,95,0,114,0,
101,0,115,0,117,
0,108,0,116,0,
95,0,105,0,115,
0,95,0,97,0,
55,0,54,0,99,
0,49,0,50,0,
56,0,98,0,54,
0,99,0,52,0,
97,0,52,0,102,
0,100,0,48,0,
56,0,48,0,101,
0,56,0,50,0,
48,0,55,0,98,
0,98,0,53,0,
54,0,56,0,54,
0,97,0,97,0,
102,0,1,298,1901,
1,297,1909,19,1910,
4,104,99,0,111,
0,110,0,100,0,
105,0,116,0,105,
0,111,0,110,0,
95,0,114,0,101,
0,115,0,117,0,
108,0,116,0,95,
0,105,0,115,0,
95,0,57,0,50,
0,99,0,97,0,
99,0,52,0,97,
0,98,0,48,0,
49,0,52,0,98,
0,52,0,50,0,
57,0,102,0,98,
0,101,0,99,0,
100,0,48,0,53,
0,99,0,48,0,
48,0,57,0,101,
0,52,0,102,0,
51,0,100,0,51,
0,1,297,1901,1,
296,1911,19,1912,4,
108,99,0,111,0,
110,0,100,0,105,
0,116,0,105,0,
111,0,110,0,95,
0,114,0,101,0,
115,0,117,0,108,
0,116,0,95,0,
114,0,111,0,108,
0,101,0,95,0,
48,0,56,0,102,
0,54,0,48,0,
98,0,55,0,57,
0,101,0,56,0,
55,0,51,0,52,
0,55,0,54,0,
50,0,57,0,99,
0,52,0,48,0,
101,0,48,0,53,
0,99,0,48,0,
48,0,98,0,97,
0,55,0,51,0,
50,0,48,0,1,
296,1901,1,295,1913,
19,1914,4,108,99,
0,111,0,110,0,
100,0,105,0,116,
0,105,0,111,0,
110,0,95,0,114,
0,101,0,115,0,
117,0,108,0,116,
0,95,0,114,0,
111,0,108,0,101,
0,95,0,51,0,
49,0,49,0,56,
0,50,0,50,0,
56,0,99,0,99,
0,53,0,97,0,
56,0,52,0,102,
0,97,0,49,0,
97,0,99,0,51,
0,51,0,57,0,
55,0,100,0,55,
0,55,0,97,0,
54,0,97,0,53,
0,97,0,56,0,
51,0,1,295,1901,
1,294,1915,19,1916,
4,100,99,0,111,
0,110,0,100,0,
105,0,116,0,105,
0,111,0,110,0,
95,0,98,0,117,
0,105,0,108,0,
116,0,105,0,110,
0,95,0,52,0,
48,0,52,0,101,
0,56,0,55,0,
49,0,51,0,57,
0,53,0,50,0,
48,0,52,0,97,
0,52,0,57,0,
97,0,97,0,100,
0,52,0,100,0,
97,0,55,0,102,
0,101,0,54,0,
54,0,57,0,57,
0,55,0,100,0,
49,0,1,294,1917,
5,2,1,593,1918,
16,0,444,1,1358,
1919,16,0,562,1,
293,1920,19,1921,4,
106,99,0,111,0,
110,0,100,0,105,
0,116,0,105,0,
111,0,110,0,95,
0,100,0,97,0,
116,0,97,0,95,
0,98,0,111,0,
117,0,110,0,100,
0,95,0,56,0,
49,0,100,0,55,
0,52,0,98,0,
101,0,55,0,56,
0,53,0,100,0,
57,0,52,0,57,
0,54,0,102,0,
56,0,54,0,49,
0,48,0,54,0,
97,0,99,0,57,
0,56,0,52,0,
100,0,102,0,57,
0,100,0,54,0,
101,0,1,293,1917,
1,292,1922,19,1923,
4,124,99,0,111,
0,110,0,100,0,
105,0,116,0,105,
0,111,0,110,0,
95,0,100,0,97,
0,116,0,97,0,
95,0,112,0,114,
0,111,0,112,0,
101,0,114,0,116,
0,121,0,95,0,
98,0,111,0,117,
0,110,0,100,0,
95,0,49,0,57,
0,57,0,50,0,
56,0,49,0,100,
0,102,0,56,0,
51,0,99,0,100,
0,52,0,52,0,
48,0,49,0,97,
0,101,0,53,0,
102,0,53,0,55,
0,52,0,53,0,
52,0,52,0,57,
0,54,0,49,0,
98,0,49,0,101,
0,1,292,1917,1,
291,1924,19,1925,4,
112,99,0,111,0,
110,0,100,0,105,
0,116,0,105,0,
111,0,110,0,95,
0,100,0,97,0,
116,0,97,0,95,
0,112,0,114,0,
111,0,112,0,101,
0,114,0,116,0,
121,0,95,0,52,
0,97,0,52,0,
49,0,50,0,100,
0,57,0,56,0,
55,0,53,0,100,
0,50,0,52,0,
98,0,101,0,52,
0,98,0,53,0,
49,0,49,0,102,
0,51,0,99,0,
101,0,52,0,102,
0,101,0,54,0,
97,0,102,0,55,
0,102,0,1,291,
1917,1,290,1926,19,
1927,4,90,99,0,
111,0,110,0,100,
0,105,0,116,0,
105,0,111,0,110,
0,95,0,105,0,
115,0,95,0,50,
0,99,0,53,0,
99,0,56,0,98,
0,50,0,100,0,
54,0,56,0,99,
0,56,0,52,0,
50,0,101,0,55,
0,57,0,55,0,
55,0,48,0,53,
0,99,0,102,0,
99,0,52,0,98,
0,101,0,52,0,
99,0,99,0,102,
0,99,0,1,290,
1917,1,289,1928,19,
1929,4,90,99,0,
111,0,110,0,100,
0,105,0,116,0,
105,0,111,0,110,
0,95,0,105,0,
115,0,95,0,57,
0,56,0,53,0,
49,0,99,0,100,
0,99,0,53,0,
101,0,101,0,52,
0,53,0,52,0,
55,0,100,0,101,
0,56,0,102,0,
54,0,102,0,50,
0,49,0,101,0,
100,0,98,0,98,
0,53,0,101,0,
102,0,52,0,53,
0,101,0,1,289,
1917,1,288,1930,19,
1931,4,106,99,0,
111,0,110,0,100,
0,105,0,116,0,
105,0,111,0,110,
0,95,0,100,0,
101,0,102,0,105,
0,110,0,105,0,
116,0,105,0,111,
0,110,0,95,0,
56,0,51,0,53,
0,99,0,52,0,
55,0,102,0,57,
0,48,0,56,0,
51,0,57,0,52,
0,101,0,54,0,
56,0,98,0,49,
0,52,0,54,0,
50,0,101,0,51,
0,55,0,54,0,
102,0,54,0,55,
0,48,0,56,0,
51,0,55,0,1,
288,1917,1,287,1932,
19,1933,4,98,99,
0,111,0,110,0,
100,0,105,0,116,
0,105,0,111,0,
110,0,95,0,101,
0,120,0,105,0,
115,0,116,0,115,
0,95,0,51,0,
98,0,55,0,102,
0,97,0,98,0,
99,0,97,0,51,
0,54,0,101,0,
57,0,52,0,99,
0,54,0,52,0,
56,0,102,0,98,
0,53,0,56,0,
99,0,56,0,100,
0,56,0,53,0,
54,0,101,0,55,
0,102,0,102,0,
56,0,1,287,1917,
1,286,1934,19,1935,
4,94,99,0,111,
0,110,0,100,0,
105,0,116,0,105,
0,111,0,110,0,
95,0,114,0,111,
0,108,0,101,0,
95,0,97,0,50,
0,55,0,54,0,
98,0,49,0,56,
0,57,0,48,0,
50,0,57,0,48,
0,52,0,52,0,
99,0,57,0,57,
0,48,0,100,0,
54,0,101,0,56,
0,55,0,97,0,
99,0,102,0,98,
0,49,0,54,0,
57,0,48,0,57,
0,1,286,1917,1,
285,1936,19,1937,4,
94,99,0,111,0,
110,0,100,0,105,
0,116,0,105,0,
111,0,110,0,95,
0,114,0,111,0,
108,0,101,0,95,
0,52,0,53,0,
48,0,101,0,100,
0,56,0,101,0,
50,0,50,0,50,
0,55,0,97,0,
52,0,50,0,99,
0,102,0,98,0,
57,0,52,0,102,
0,51,0,52,0,
100,0,53,0,55,
0,49,0,99,0,
52,0,57,0,49,
0,51,0,56,0,
1,285,1917,1,284,
1938,19,1939,4,92,
99,0,108,0,97,
0,117,0,115,0,
101,0,95,0,114,
0,101,0,115,0,
117,0,108,0,116,
0,95,0,51,0,
52,0,101,0,49,
0,57,0,101,0,
55,0,55,0,53,
0,55,0,51,0,
101,0,52,0,99,
0,101,0,101,0,
57,0,49,0,97,
0,55,0,102,0,
102,0,54,0,102,
0,48,0,98,0,
55,0,49,0,48,
0,55,0,56,0,
48,0,1,284,1940,
5,2,1,1435,1941,
16,0,295,1,1506,
1942,16,0,652,1,
283,1943,19,1944,4,
92,99,0,108,0,
97,0,117,0,115,
0,101,0,95,0,
114,0,101,0,115,
0,117,0,108,0,
116,0,95,0,101,
0,52,0,57,0,
54,0,54,0,97,
0,50,0,48,0,
55,0,49,0,53,
0,102,0,52,0,
97,0,100,0,54,
0,97,0,57,0,
102,0,52,0,101,
0,97,0,101,0,
98,0,51,0,51,
0,97,0,53,0,
101,0,97,0,57,
0,57,0,1,283,
1940,1,282,1945,19,
1946,4,78,99,0,
108,0,97,0,117,
0,115,0,101,0,
95,0,56,0,57,
0,54,0,55,0,
50,0,49,0,50,
0,50,0,56,0,
102,0,48,0,55,
0,52,0,57,0,
98,0,49,0,56,
0,51,0,53,0,
55,0,56,0,55,
0,101,0,52,0,
51,0,56,0,56,
0,48,0,48,0,
98,0,56,0,48,
0,1,282,1947,5,
1,1,593,1948,16,
0,569,1,281,1949,
19,1950,4,78,99,
0,108,0,97,0,
117,0,115,0,101,
0,95,0,52,0,
97,0,102,0,98,
0,53,0,48,0,
51,0,52,0,54,
0,100,0,98,0,
99,0,52,0,101,
0,48,0,97,0,
98,0,57,0,55,
0,55,0,57,0,
49,0,55,0,52,
0,57,0,54,0,
97,0,101,0,55,
0,52,0,54,0,
53,0,1,281,1947,
1,280,1951,19,1952,
4,156,118,0,97,
0,108,0,117,0,
101,0,79,0,114,
0,84,0,104,0,
105,0,110,0,103,
0,95,0,54,0,
48,0,54,0,102,
0,57,0,49,0,
53,0,49,0,53,
0,99,0,57,0,
97,0,52,0,102,
0,49,0,55,0,
56,0,101,0,98,
0,100,0,101,0,
50,0,101,0,57,
0,101,0,49,0,
53,0,100,0,97,
0,49,0,56,0,
48,0,95,0,97,
0,48,0,49,0,
57,0,52,0,53,
0,51,0,49,0,
99,0,57,0,97,
0,48,0,52,0,
54,0,55,0,53,
0,56,0,98,0,
48,0,56,0,54,
0,52,0,98,0,
49,0,98,0,101,
0,98,0,56,0,
102,0,49,0,98,
0,48,0,1,280,
1953,5,1,1,1418,
1954,16,0,535,1,
279,1955,19,1956,4,
90,118,0,97,0,
108,0,117,0,101,
0,79,0,114,0,
84,0,104,0,105,
0,110,0,103,0,
95,0,54,0,48,
0,54,0,102,0,
57,0,49,0,53,
0,49,0,53,0,
99,0,57,0,97,
0,52,0,102,0,
49,0,55,0,56,
0,101,0,98,0,
100,0,101,0,50,
0,101,0,57,0,
101,0,49,0,53,
0,100,0,97,0,
49,0,56,0,48,
0,1,279,1953,1,
278,1957,19,1958,4,
90,118,0,97,0,
108,0,117,0,101,
0,79,0,114,0,
84,0,104,0,105,
0,110,0,103,0,
95,0,57,0,57,
0,50,0,100,0,
54,0,52,0,97,
0,57,0,54,0,
97,0,49,0,100,
0,52,0,102,0,
54,0,99,0,98,
0,52,0,57,0,
48,0,54,0,102,
0,56,0,48,0,
50,0,99,0,52,
0,52,0,101,0,
51,0,99,0,101,
0,1,278,1953,1,
277,1959,19,1960,4,
156,118,0,97,0,
108,0,117,0,101,
0,79,0,114,0,
84,0,104,0,105,
0,110,0,103,0,
95,0,98,0,50,
0,57,0,50,0,
101,0,53,0,101,
0,102,0,102,0,
101,0,98,0,99,
0,52,0,99,0,
102,0,48,0,56,
0,102,0,54,0,
56,0,50,0,50,
0,55,0,100,0,
52,0,52,0,52,
0,55,0,54,0,
53,0,100,0,97,
0,95,0,101,0,
51,0,57,0,52,
0,49,0,48,0,
49,0,100,0,53,
0,52,0,56,0,
102,0,52,0,98,
0,49,0,55,0,
57,0,48,0,98,
0,51,0,97,0,
55,0,102,0,98,
0,50,0,99,0,
102,0,102,0,97,
0,97,0,101,0,
99,0,1,277,1953,
1,276,1961,19,1962,
4,90,118,0,97,
0,108,0,117,0,
101,0,79,0,114,
0,84,0,104,0,
105,0,110,0,103,
0,95,0,98,0,
50,0,57,0,50,
0,101,0,53,0,
101,0,102,0,102,
0,101,0,98,0,
99,0,52,0,99,
0,102,0,48,0,
56,0,102,0,54,
0,56,0,50,0,
50,0,55,0,100,
0,52,0,52,0,
52,0,55,0,54,
0,53,0,100,0,
97,0,1,276,1953,
1,275,1963,19,1964,
4,90,118,0,97,
0,108,0,117,0,
101,0,79,0,114,
0,84,0,104,0,
105,0,110,0,103,
0,95,0,49,0,
49,0,54,0,57,
0,51,0,49,0,
49,0,48,0,102,
0,54,0,51,0,
56,0,52,0,50,
0,53,0,98,0,
98,0,57,0,57,
0,56,0,99,0,
56,0,52,0,56,
0,55,0,52,0,
56,0,52,0,97,
0,99,0,99,0,
98,0,1,275,1953,
1,274,1965,19,1966,
4,74,99,0,111,
0,100,0,101,0,
95,0,99,0,98,
0,101,0,48,0,
55,0,48,0,56,
0,52,0,52,0,
97,0,54,0,48,
0,52,0,98,0,
99,0,100,0,56,
0,54,0,54,0,
55,0,102,0,49,
0,53,0,52,0,
50,0,99,0,56,
0,51,0,49,0,
50,0,52,0,49,
0,1,274,1967,5,
2,1,1780,1968,16,
0,159,1,0,1969,
16,0,153,1,273,
1970,19,1971,4,80,
101,0,120,0,101,
0,114,0,117,0,
108,0,101,0,95,
0,48,0,98,0,
51,0,100,0,57,
0,50,0,51,0,
53,0,99,0,57,
0,102,0,48,0,
52,0,57,0,51,
0,48,0,56,0,
101,0,97,0,97,
0,49,0,53,0,
48,0,102,0,97,
0,55,0,102,0,
101,0,54,0,100,
0,99,0,53,0,
1,273,1967,1,272,
1972,19,1973,4,88,
115,0,119,0,114,
0,108,0,114,0,
117,0,108,0,101,
0,102,0,111,0,
114,0,95,0,49,
0,51,0,50,0,
98,0,100,0,48,
0,98,0,50,0,
97,0,52,0,98,
0,49,0,52,0,
97,0,98,0,53,
0,57,0,53,0,
57,0,98,0,101,
0,98,0,56,0,
55,0,49,0,99,
0,55,0,53,0,
57,0,55,0,100,
0,50,0,1,272,
1967,1,271,1974,19,
1975,4,82,115,0,
119,0,114,0,108,
0,114,0,117,0,
108,0,101,0,95,
0,57,0,52,0,
51,0,99,0,56,
0,98,0,97,0,
99,0,57,0,55,
0,99,0,57,0,
52,0,99,0,56,
0,50,0,97,0,
56,0,55,0,101,
0,53,0,55,0,
54,0,48,0,50,
0,53,0,49,0,
52,0,99,0,49,
0,100,0,53,0,
1,271,1967,1,270,
1976,19,457,1,270,
1453,1,269,1977,19,
1978,4,78,104,0,
97,0,115,0,107,
0,101,0,121,0,
95,0,52,0,50,
0,100,0,55,0,
53,0,102,0,100,
0,102,0,56,0,
48,0,97,0,98,
0,52,0,53,0,
57,0,51,0,98,
0,52,0,55,0,
101,0,100,0,102,
0,55,0,49,0,
53,0,57,0,100,
0,52,0,55,0,
51,0,48,0,55,
0,1,269,1967,1,
268,1979,19,1980,4,
86,101,0,120,0,
99,0,108,0,117,
0,115,0,105,0,
118,0,101,0,115,
0,95,0,57,0,
49,0,102,0,102,
0,97,0,53,0,
50,0,100,0,57,
0,48,0,53,0,
53,0,52,0,57,
0,98,0,48,0,
97,0,97,0,101,
0,97,0,53,0,
49,0,53,0,57,
0,56,0,56,0,
97,0,99,0,48,
0,51,0,48,0,
49,0,1,268,1967,
1,267,1981,19,1982,
4,94,101,0,120,
0,99,0,108,0,
117,0,115,0,105,
0,118,0,101,0,
117,0,110,0,105,
0,111,0,110,0,
95,0,57,0,100,
0,51,0,102,0,
101,0,98,0,50,
0,52,0,97,0,
102,0,99,0,48,
0,52,0,98,0,
97,0,48,0,97,
0,54,0,49,0,
57,0,53,0,53,
0,51,0,53,0,
50,0,54,0,97,
0,52,0,52,0,
54,0,52,0,54,
0,1,267,1967,1,
266,1983,19,1984,4,
106,100,0,97,0,
116,0,97,0,114,
0,111,0,108,0,
101,0,101,0,113,
0,117,0,105,0,
118,0,97,0,108,
0,101,0,110,0,
99,0,101,0,50,
0,95,0,55,0,
57,0,101,0,56,
0,101,0,51,0,
99,0,54,0,51,
0,56,0,55,0,
99,0,52,0,57,
0,97,0,98,0,
57,0,57,0,53,
0,49,0,51,0,
57,0,97,0,100,
0,49,0,56,0,
50,0,49,0,52,
0,49,0,50,0,
50,0,1,266,1967,
1,265,1985,19,1986,
4,98,114,0,111,
0,108,0,101,0,
101,0,113,0,117,
0,105,0,118,0,
97,0,108,0,101,
0,110,0,99,0,
101,0,50,0,95,
0,55,0,51,0,
50,0,57,0,54,
0,54,0,48,0,
50,0,52,0,55,
0,97,0,51,0,
52,0,50,0,51,
0,100,0,98,0,
98,0,101,0,54,
0,100,0,55,0,
53,0,49,0,101,
0,97,0,50,0,
53,0,52,0,97,
0,55,0,102,0,
1,265,1967,1,264,
1987,19,1988,4,90,
101,0,113,0,117,
0,105,0,118,0,
97,0,108,0,101,
0,110,0,99,0,
101,0,50,0,95,
0,50,0,101,0,
99,0,101,0,53,
0,56,0,50,0,
99,0,48,0,53,
0,56,0,49,0,
52,0,100,0,49,
0,56,0,57,0,
98,0,48,0,55,
0,101,0,50,0,
54,0,98,0,51,
0,102,0,99,0,
52,0,49,0,53,
0,102,0,48,0,
1,264,1967,1,263,
1989,19,1990,4,100,
100,0,97,0,116,
0,97,0,114,0,
111,0,108,0,101,
0,100,0,105,0,
115,0,106,0,111,
0,105,0,110,0,
116,0,50,0,95,
0,52,0,52,0,
51,0,97,0,101,
0,49,0,99,0,
57,0,100,0,102,
0,99,0,51,0,
52,0,57,0,48,
0,55,0,56,0,
55,0,57,0,100,
0,98,0,53,0,
56,0,101,0,53,
0,52,0,97,0,
52,0,51,0,53,
0,53,0,50,0,
1,263,1967,1,262,
1991,19,1992,4,92,
114,0,111,0,108,
0,101,0,100,0,
105,0,115,0,106,
0,111,0,105,0,
110,0,116,0,50,
0,95,0,48,0,
101,0,49,0,53,
0,55,0,97,0,
101,0,100,0,99,
0,52,0,99,0,
52,0,52,0,50,
0,48,0,50,0,
56,0,54,0,98,
0,99,0,54,0,
54,0,56,0,53,
0,48,0,102,0,
50,0,55,0,98,
0,52,0,97,0,
50,0,1,262,1967,
1,261,1993,19,1994,
4,104,100,0,97,
0,116,0,97,0,
114,0,111,0,108,
0,101,0,115,0,
117,0,98,0,115,
0,117,0,109,0,
112,0,116,0,105,
0,111,0,110,0,
95,0,53,0,51,
0,98,0,56,0,
102,0,97,0,52,
0,55,0,99,0,
53,0,57,0,54,
0,52,0,52,0,
48,0,97,0,56,
0,52,0,56,0,
99,0,51,0,54,
0,56,0,54,0,
100,0,56,0,52,
0,102,0,102,0,
57,0,102,0,97,
0,1,261,1967,1,
260,1995,19,1996,4,
96,114,0,111,0,
108,0,101,0,115,
0,117,0,98,0,
115,0,117,0,109,
0,112,0,116,0,
105,0,111,0,110,
0,95,0,55,0,
98,0,52,0,52,
0,52,0,50,0,
56,0,101,0,97,
0,56,0,51,0,
52,0,52,0,102,
0,99,0,101,0,
98,0,101,0,57,
0,101,0,98,0,
53,0,100,0,54,
0,98,0,49,0,
99,0,53,0,99,
0,56,0,52,0,
102,0,1,260,1967,
1,259,1997,19,1998,
4,96,114,0,111,
0,108,0,101,0,
115,0,117,0,98,
0,115,0,117,0,
109,0,112,0,116,
0,105,0,111,0,
110,0,95,0,55,
0,97,0,102,0,
54,0,53,0,50,
0,51,0,101,0,
55,0,50,0,56,
0,98,0,52,0,
53,0,48,0,100,
0,97,0,57,0,
51,0,54,0,98,
0,53,0,48,0,
54,0,49,0,98,
0,97,0,53,0,
51,0,48,0,48,
0,56,0,1,259,
1967,1,258,1999,19,
2000,4,88,100,0,
97,0,116,0,97,
0,116,0,121,0,
112,0,101,0,100,
0,101,0,102,0,
95,0,101,0,100,
0,101,0,56,0,
53,0,56,0,100,
0,56,0,101,0,
53,0,100,0,99,
0,52,0,97,0,
102,0,100,0,97,
0,97,0,102,0,
54,0,102,0,56,
0,56,0,55,0,
98,0,50,0,52,
0,54,0,52,0,
102,0,97,0,100,
0,1,258,1967,1,
257,2001,19,2002,4,
92,110,0,111,0,
115,0,117,0,98,
0,115,0,117,0,
109,0,112,0,116,
0,105,0,111,0,
110,0,95,0,50,
0,52,0,49,0,
48,0,55,0,48,
0,56,0,57,0,
56,0,98,0,100,
0,51,0,52,0,
98,0,48,0,55,
0,98,0,101,0,
52,0,52,0,97,
0,101,0,56,0,
98,0,48,0,51,
0,98,0,57,0,
102,0,97,0,50,
0,53,0,1,257,
1967,1,256,2003,19,
2004,4,88,115,0,
117,0,98,0,115,
0,117,0,109,0,
112,0,116,0,105,
0,111,0,110,0,
95,0,101,0,49,
0,49,0,98,0,
56,0,102,0,101,
0,99,0,97,0,
53,0,50,0,97,
0,52,0,51,0,
50,0,57,0,56,
0,50,0,99,0,
52,0,51,0,99,
0,55,0,101,0,
101,0,102,0,52,
0,101,0,57,0,
102,0,102,0,102,
0,1,256,1967,1,
255,2005,19,2006,4,
86,97,0,110,0,
110,0,111,0,116,
0,97,0,116,0,
105,0,111,0,110,
0,95,0,52,0,
52,0,57,0,52,
0,55,0,100,0,
55,0,54,0,50,
0,54,0,101,0,
50,0,52,0,51,
0,97,0,51,0,
56,0,50,0,101,
0,98,0,48,0,
48,0,54,0,57,
0,51,0,50,0,
53,0,98,0,50,
0,100,0,50,0,
99,0,1,255,1967,
1,254,2007,19,2008,
4,84,112,0,97,
0,114,0,97,0,
103,0,114,0,97,
0,112,0,104,0,
95,0,99,0,55,
0,51,0,97,0,
52,0,98,0,102,
0,101,0,55,0,
99,0,48,0,54,
0,52,0,98,0,
52,0,99,0,56,
0,52,0,56,0,
53,0,53,0,101,
0,51,0,49,0,
57,0,57,0,57,
0,57,0,56,0,
57,0,57,0,53,
0,1,254,2009,5,
1,1,0,2010,16,
0,104,1,253,2011,
19,2012,4,84,112,
0,97,0,114,0,
97,0,103,0,114,
0,97,0,112,0,
104,0,95,0,53,
0,54,0,54,0,
50,0,52,0,53,
0,99,0,56,0,
55,0,100,0,102,
0,53,0,52,0,
101,0,101,0,51,
0,98,0,98,0,
55,0,56,0,100,
0,53,0,54,0,
48,0,54,0,99,
0,48,0,102,0,
99,0,49,0,101,
0,56,0,1,253,
2009,1,252,2013,19,
2014,4,20,100,0,
117,0,114,0,97,
0,116,0,105,0,
111,0,110,0,95,
0,119,0,1,252,
1552,1,251,2015,19,
2016,4,20,100,0,
117,0,114,0,97,
0,116,0,105,0,
111,0,110,0,95,
0,109,0,1,251,
1552,1,250,2017,19,
813,1,250,1552,1,
249,2018,19,697,1,
249,1669,1,248,2019,
19,683,1,248,1676,
1,247,2020,19,438,
1,247,1683,1,246,
2021,19,2022,4,22,
98,0,117,0,105,
0,108,0,116,0,
105,0,110,0,95,
0,101,0,120,0,
101,0,1,246,1575,
1,245,2023,19,2024,
4,26,98,0,117,
0,105,0,108,0,
116,0,105,0,110,
0,95,0,97,0,
110,0,110,0,111,
0,116,0,1,245,
1575,1,244,2025,19,
2026,4,26,98,0,
117,0,105,0,108,
0,116,0,105,0,
110,0,95,0,97,
0,108,0,112,0,
104,0,97,0,1,
244,1575,1,243,2027,
19,2028,4,32,98,
0,117,0,105,0,
108,0,116,0,105,
0,110,0,95,0,
100,0,97,0,116,
0,101,0,116,0,
105,0,109,0,101,
0,1,243,1575,1,
242,2029,19,2030,4,
32,98,0,117,0,
105,0,108,0,116,
0,105,0,110,0,
95,0,100,0,117,
0,114,0,97,0,
116,0,105,0,111,
0,110,0,1,242,
1575,1,241,2031,19,
2032,4,26,98,0,
117,0,105,0,108,
0,116,0,105,0,
110,0,95,0,116,
0,114,0,97,0,
110,0,115,0,1,
241,1575,1,240,2033,
19,2034,4,28,98,
0,117,0,105,0,
108,0,116,0,105,
0,110,0,95,0,
115,0,117,0,98,
0,115,0,116,0,
114,0,1,240,1575,
1,239,2035,19,2036,
4,36,98,0,117,
0,105,0,108,0,
116,0,105,0,110,
0,95,0,117,0,
110,0,97,0,114,
0,121,0,95,0,
102,0,114,0,101,
0,101,0,1,239,
1575,1,238,2037,19,
2038,4,34,98,0,
117,0,105,0,108,
0,116,0,105,0,
110,0,95,0,117,
0,110,0,97,0,
114,0,121,0,95,
0,99,0,109,0,
112,0,1,238,1575,
1,237,2039,19,2040,
4,22,98,0,117,
0,105,0,108,0,
116,0,105,0,110,
0,95,0,98,0,
105,0,110,0,1,
237,1575,1,236,2041,
19,2042,4,24,98,
0,117,0,105,0,
108,0,116,0,105,
0,110,0,95,0,
108,0,105,0,115,
0,116,0,1,236,
1575,1,235,2043,19,
2044,4,22,98,0,
117,0,105,0,108,
0,116,0,105,0,
110,0,95,0,99,
0,109,0,112,0,
1,235,1575,1,234,
2045,19,634,1,234,
1575,1,233,2046,19,
2047,4,22,115,0,
119,0,114,0,108,
0,114,0,117,0,
108,0,101,0,102,
0,111,0,114,0,
1,233,1967,1,232,
2048,19,165,1,232,
1890,1,231,2049,19,
2050,4,8,99,0,
111,0,100,0,101,
0,1,231,1967,1,
230,2051,19,2052,4,
14,101,0,120,0,
101,0,114,0,117,
0,108,0,101,0,
1,230,1967,1,229,
2053,19,2054,4,20,
100,0,97,0,116,
0,97,0,118,0,
97,0,108,0,118,
0,97,0,108,0,
1,229,1751,1,228,
2055,19,2056,4,20,
100,0,97,0,116,
0,97,0,118,0,
97,0,108,0,118,
0,97,0,114,0,
1,228,1751,1,227,
2057,19,118,1,227,
1751,1,226,2058,19,
121,1,226,1821,1,
225,2059,19,2060,4,
32,105,0,100,0,
101,0,110,0,116,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,95,0,
105,0,110,0,115,
0,116,0,1,225,
1844,1,224,2061,19,
2062,4,32,105,0,
100,0,101,0,110,
0,116,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
95,0,110,0,97,
0,109,0,101,0,
1,224,1844,1,223,
2063,19,108,1,223,
1844,1,222,2064,19,
767,1,222,1873,1,
221,2065,19,2066,4,
20,111,0,98,0,
106,0,101,0,99,
0,116,0,114,0,
95,0,105,0,111,
0,1,221,1808,1,
220,2067,19,2068,4,
22,111,0,98,0,
106,0,101,0,99,
0,116,0,114,0,
95,0,110,0,105,
0,111,0,1,220,
1808,1,219,2069,19,
318,1,219,1808,1,
218,2070,19,2071,4,
48,99,0,111,0,
110,0,100,0,105,
0,116,0,105,0,
111,0,110,0,95,
0,114,0,101,0,
115,0,117,0,108,
0,116,0,95,0,
98,0,117,0,105,
0,108,0,116,0,
105,0,110,0,1,
218,1901,1,217,2072,
19,2073,4,60,99,
0,111,0,110,0,
100,0,105,0,116,
0,105,0,111,0,
110,0,95,0,114,
0,101,0,115,0,
117,0,108,0,116,
0,95,0,100,0,
97,0,116,0,97,
0,95,0,112,0,
114,0,111,0,112,
0,101,0,114,0,
116,0,121,0,1,
217,1901,1,216,2074,
19,2075,4,42,99,
0,111,0,110,0,
100,0,105,0,116,
0,105,0,111,0,
110,0,95,0,114,
0,101,0,115,0,
117,0,108,0,116,
0,95,0,114,0,
111,0,108,0,101,
0,1,216,1901,1,
215,2076,19,2077,4,
54,99,0,111,0,
110,0,100,0,105,
0,116,0,105,0,
111,0,110,0,95,
0,114,0,101,0,
115,0,117,0,108,
0,116,0,95,0,
100,0,101,0,102,
0,105,0,110,0,
105,0,116,0,105,
0,111,0,110,0,
1,215,1901,1,214,
2078,19,2079,4,38,
99,0,111,0,110,
0,100,0,105,0,
116,0,105,0,111,
0,110,0,95,0,
114,0,101,0,115,
0,117,0,108,0,
116,0,95,0,105,
0,115,0,1,214,
1901,1,213,2080,19,
460,1,213,1901,1,
212,2081,19,297,1,
212,1940,1,211,2082,
19,2083,4,34,99,
0,111,0,110,0,
100,0,105,0,116,
0,105,0,111,0,
110,0,95,0,98,
0,117,0,105,0,
108,0,116,0,105,
0,110,0,1,211,
1917,1,210,2084,19,
2085,4,40,99,0,
111,0,110,0,100,
0,105,0,116,0,
105,0,111,0,110,
0,95,0,100,0,
97,0,116,0,97,
0,95,0,98,0,
111,0,117,0,110,
0,100,0,1,210,
1917,1,209,2086,19,
2087,4,58,99,0,
111,0,110,0,100,
0,105,0,116,0,
105,0,111,0,110,
0,95,0,100,0,
97,0,116,0,97,
0,95,0,112,0,
114,0,111,0,112,
0,101,0,114,0,
116,0,121,0,95,
0,98,0,111,0,
117,0,110,0,100,
0,1,209,1917,1,
208,2088,19,2089,4,
46,99,0,111,0,
110,0,100,0,105,
0,116,0,105,0,
111,0,110,0,95,
0,100,0,97,0,
116,0,97,0,95,
0,112,0,114,0,
111,0,112,0,101,
0,114,0,116,0,
121,0,1,208,1917,
1,207,2090,19,2091,
4,28,99,0,111,
0,110,0,100,0,
105,0,116,0,105,
0,111,0,110,0,
95,0,114,0,111,
0,108,0,101,0,
1,207,1917,1,206,
2092,19,2093,4,40,
99,0,111,0,110,
0,100,0,105,0,
116,0,105,0,111,
0,110,0,95,0,
100,0,101,0,102,
0,105,0,110,0,
105,0,116,0,105,
0,111,0,110,0,
1,206,1917,1,205,
2094,19,2095,4,32,
99,0,111,0,110,
0,100,0,105,0,
116,0,105,0,111,
0,110,0,95,0,
101,0,120,0,105,
0,115,0,116,0,
115,0,1,205,1917,
1,204,2096,19,2097,
4,24,99,0,111,
0,110,0,100,0,
105,0,116,0,105,
0,111,0,110,0,
95,0,105,0,115,
0,1,204,1917,1,
203,2098,19,446,1,
203,1917,1,202,2099,
19,571,1,202,1947,
1,201,2100,19,2101,
4,16,115,0,119,
0,114,0,108,0,
114,0,117,0,108,
0,101,0,1,201,
1967,1,200,2102,19,
886,1,200,969,1,
199,2103,19,739,1,
199,989,1,197,2104,
19,215,1,197,929,
1,196,2105,19,489,
1,196,1034,1,195,
2106,19,2107,4,16,
98,0,111,0,117,
0,110,0,100,0,
78,0,111,0,116,
0,1,195,1125,1,
194,2108,19,2109,4,
14,98,0,111,0,
117,0,110,0,100,
0,79,0,114,0,
1,194,1125,1,193,
2110,19,2111,4,16,
98,0,111,0,117,
0,110,0,100,0,
65,0,110,0,100,
0,1,193,1125,1,
192,2112,19,2113,4,
20,98,0,111,0,
117,0,110,0,100,
0,73,0,100,0,
101,0,110,0,116,
0,1,192,1125,1,
191,2114,19,2115,4,
26,98,0,111,0,
117,0,110,0,100,
0,68,0,97,0,
116,0,97,0,84,
0,121,0,112,0,
101,0,1,191,1125,
1,190,2116,19,2117,
4,20,98,0,111,
0,117,0,110,0,
100,0,84,0,111,
0,116,0,97,0,
108,0,1,190,1125,
1,189,2118,19,2119,
4,16,98,0,111,
0,117,0,110,0,
100,0,84,0,111,
0,112,0,1,189,
1125,1,188,2120,19,
2121,4,20,98,0,
111,0,117,0,110,
0,100,0,79,0,
110,0,101,0,79,
0,102,0,1,188,
1125,1,187,2122,19,
848,1,187,1040,1,
186,2123,19,2124,4,
16,98,0,111,0,
117,0,110,0,100,
0,86,0,97,0,
108,0,1,186,1125,
1,185,2125,19,2126,
4,22,98,0,111,
0,117,0,110,0,
100,0,70,0,97,
0,99,0,101,0,
116,0,115,0,1,
185,1125,1,184,2127,
19,203,1,184,1125,
1,183,2128,19,803,
1,183,1162,1,182,
2129,19,786,1,182,
1181,1,181,2130,19,
2131,4,16,68,0,
117,0,114,0,97,
0,116,0,105,0,
111,0,110,0,1,
181,1047,1,180,2132,
19,2133,4,24,68,
0,97,0,116,0,
101,0,84,0,105,
0,109,0,101,0,
68,0,97,0,116,
0,97,0,1,180,
1047,1,179,2134,19,
2135,4,8,66,0,
111,0,111,0,108,
0,1,179,1047,1,
178,2136,19,2137,4,
10,70,0,108,0,
111,0,97,0,116,
0,1,178,1047,1,
177,2138,19,2139,4,
14,83,0,116,0,
114,0,68,0,97,
0,116,0,97,0,
1,177,1047,1,176,
2140,19,2141,4,12,
78,0,117,0,109,
0,98,0,101,0,
114,0,1,176,1047,
1,175,2142,19,389,
1,175,1047,1,174,
2143,19,718,1,174,
1205,1,173,2144,19,
725,1,173,1219,1,
172,2145,19,219,1,
172,1235,1,171,2146,
19,744,1,171,1246,
1,170,2147,19,2148,
4,20,116,0,104,
0,97,0,116,0,
79,0,114,0,76,
0,111,0,111,0,
112,0,1,170,1258,
1,169,2149,19,516,
1,169,1258,1,168,
2150,19,2151,4,22,
115,0,105,0,110,
0,103,0,108,0,
101,0,79,0,110,
0,101,0,79,0,
102,0,1,168,1276,
1,167,2152,19,2153,
4,30,115,0,105,
0,110,0,103,0,
108,0,101,0,84,
0,104,0,105,0,
110,0,103,0,84,
0,104,0,97,0,
116,0,1,167,1276,
1,166,2154,19,2155,
4,28,115,0,105,
0,110,0,103,0,
108,0,101,0,78,
0,97,0,109,0,
101,0,84,0,104,
0,97,0,116,0,
1,166,1276,1,165,
2156,19,2157,4,22,
115,0,105,0,110,
0,103,0,108,0,
101,0,84,0,104,
0,105,0,110,0,
103,0,1,165,1276,
1,164,2158,19,2159,
4,20,115,0,105,
0,110,0,103,0,
108,0,101,0,78,
0,97,0,109,0,
101,0,1,164,1276,
1,163,2160,19,509,
1,163,1276,1,162,
2161,19,379,1,162,
1518,1,161,2162,19,
227,1,161,1524,1,
160,2163,19,242,1,
160,1426,1,159,2164,
19,2165,4,48,111,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,79,0,
110,0,108,0,121,
0,83,0,111,0,
109,0,101,0,116,
0,104,0,105,0,
110,0,103,0,84,
0,104,0,97,0,
116,0,1,159,1313,
1,158,2166,19,2167,
4,40,111,0,111,
0,98,0,106,0,
101,0,99,0,116,
0,83,0,111,0,
109,0,101,0,116,
0,104,0,105,0,
110,0,103,0,84,
0,104,0,97,0,
116,0,1,158,1337,
1,157,2168,19,2169,
4,36,111,0,111,
0,98,0,106,0,
101,0,99,0,116,
0,79,0,110,0,
108,0,121,0,78,
0,111,0,116,0,
104,0,105,0,110,
0,103,0,1,157,
1313,1,156,2170,19,
2171,4,28,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,78,0,111,
0,116,0,104,0,
105,0,110,0,103,
0,1,156,1337,1,
155,2172,19,2173,4,
32,111,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
83,0,111,0,109,
0,101,0,116,0,
104,0,105,0,110,
0,103,0,1,155,
1337,1,154,2174,19,
2175,4,22,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,83,0,101,
0,108,0,102,0,
1,154,1313,1,153,
2176,19,2177,4,26,
111,0,111,0,98,
0,106,0,101,0,
99,0,116,0,67,
0,109,0,112,0,
66,0,110,0,100,
0,1,153,1313,1,
152,2178,19,2179,4,
28,111,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
79,0,110,0,108,
0,121,0,66,0,
110,0,100,0,1,
152,1313,1,151,2180,
19,2181,4,20,111,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,66,0,
110,0,100,0,1,
151,1313,1,150,2182,
19,2183,4,36,111,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,67,0,
109,0,112,0,73,
0,110,0,115,0,
116,0,97,0,110,
0,99,0,101,0,
1,150,1313,1,149,
2184,19,2185,4,20,
111,0,111,0,98,
0,106,0,101,0,
99,0,116,0,67,
0,109,0,112,0,
1,149,1313,1,148,
2186,19,2187,4,30,
111,0,111,0,98,
0,106,0,101,0,
99,0,116,0,67,
0,97,0,114,0,
100,0,105,0,110,
0,97,0,108,0,
1,148,1313,1,147,
2188,19,2189,4,38,
111,0,111,0,98,
0,106,0,101,0,
99,0,116,0,79,
0,110,0,108,0,
121,0,73,0,110,
0,115,0,116,0,
97,0,110,0,99,
0,101,0,1,147,
1313,1,146,2190,19,
2191,4,22,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,79,0,110,
0,108,0,121,0,
1,146,1313,1,145,
2192,19,583,1,145,
1313,1,144,2193,19,
2194,4,30,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,73,0,110,
0,115,0,116,0,
97,0,110,0,99,
0,101,0,1,144,
1337,1,143,2195,19,
2196,4,16,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,65,0,1,
143,1337,1,142,2197,
19,178,1,142,1337,
1,141,2198,19,496,
1,141,1508,1,140,
2199,19,281,1,140,
1532,1,139,2200,19,
578,1,139,1539,1,
138,2201,19,910,1,
138,1360,1,137,2202,
19,2203,4,30,105,
0,110,0,115,0,
116,0,97,0,110,
0,99,0,101,0,
66,0,105,0,103,
0,78,0,97,0,
109,0,101,0,1,
137,1368,1,136,2204,
19,2205,4,22,105,
0,110,0,115,0,
116,0,97,0,110,
0,99,0,101,0,
84,0,104,0,101,
0,1,136,1368,1,
135,2206,19,672,1,
135,1368,1,134,2207,
19,537,1,134,1953,
1,133,2208,19,294,
1,133,942,1,132,
2209,19,301,1,132,
1007,1,131,2210,19,
194,1,131,1467,1,
130,2211,19,2212,4,
30,111,0,98,0,
106,0,101,0,99,
0,116,0,82,0,
111,0,108,0,101,
0,69,0,120,0,
112,0,114,0,51,
0,1,130,1392,1,
129,2213,19,2214,4,
30,111,0,98,0,
106,0,101,0,99,
0,116,0,82,0,
111,0,108,0,101,
0,69,0,120,0,
112,0,114,0,50,
0,1,129,1392,1,
128,2215,19,2216,4,
30,111,0,98,0,
106,0,101,0,99,
0,116,0,82,0,
111,0,108,0,101,
0,69,0,120,0,
112,0,114,0,49,
0,1,128,1392,1,
127,2217,19,332,1,
127,1392,1,126,2218,
19,2219,4,28,115,
0,117,0,98,0,
106,0,101,0,99,
0,116,0,78,0,
111,0,116,0,104,
0,105,0,110,0,
103,0,1,126,1484,
1,125,2220,19,2221,
4,18,115,0,117,
0,98,0,106,0,
101,0,99,0,116,
0,78,0,111,0,
1,125,1484,1,124,
2222,19,223,1,124,
1484,1,123,2223,19,
2224,4,20,115,0,
117,0,98,0,106,
0,101,0,99,0,
116,0,84,0,104,
0,101,0,1,123,
1491,1,122,2225,19,
2226,4,28,115,0,
117,0,98,0,106,
0,101,0,99,0,
116,0,66,0,105,
0,103,0,78,0,
97,0,109,0,101,
0,1,122,1491,1,
121,2227,19,2228,4,
34,115,0,117,0,
98,0,106,0,101,
0,99,0,116,0,
69,0,118,0,101,
0,114,0,121,0,
116,0,104,0,105,
0,110,0,103,0,
1,121,1491,1,120,
2229,19,2230,4,24,
115,0,117,0,98,
0,106,0,101,0,
99,0,116,0,69,
0,118,0,101,0,
114,0,121,0,1,
120,1491,1,119,2231,
19,197,1,119,1491,
1,118,2232,19,2233,
4,12,104,0,97,
0,115,0,107,0,
101,0,121,0,1,
118,1967,1,117,2234,
19,2235,4,34,100,
0,97,0,116,0,
97,0,114,0,111,
0,108,0,101,0,
100,0,105,0,115,
0,106,0,111,0,
105,0,110,0,116,
0,50,0,1,117,
1967,1,116,2236,19,
2237,4,40,100,0,
97,0,116,0,97,
0,114,0,111,0,
108,0,101,0,101,
0,113,0,117,0,
105,0,118,0,97,
0,108,0,101,0,
110,0,99,0,101,
0,50,0,1,116,
1967,1,115,2238,19,
2239,4,38,100,0,
97,0,116,0,97,
0,114,0,111,0,
108,0,101,0,115,
0,117,0,98,0,
115,0,117,0,109,
0,112,0,116,0,
105,0,111,0,110,
0,1,115,1967,1,
114,2240,19,2241,4,
26,114,0,111,0,
108,0,101,0,100,
0,105,0,115,0,
106,0,111,0,105,
0,110,0,116,0,
50,0,1,114,1967,
1,113,2242,19,2243,
4,32,114,0,111,
0,108,0,101,0,
101,0,113,0,117,
0,105,0,118,0,
97,0,108,0,101,
0,110,0,99,0,
101,0,50,0,1,
113,1967,1,112,2244,
19,2245,4,30,114,
0,111,0,108,0,
101,0,115,0,117,
0,98,0,115,0,
117,0,109,0,112,
0,116,0,105,0,
111,0,110,0,1,
112,1967,1,111,2246,
19,2247,4,28,101,
0,120,0,99,0,
108,0,117,0,115,
0,105,0,118,0,
101,0,117,0,110,
0,105,0,111,0,
110,0,1,111,1967,
1,110,2248,19,2249,
4,20,101,0,120,
0,99,0,108,0,
117,0,115,0,105,
0,118,0,101,0,
115,0,1,110,1967,
1,109,2250,19,2251,
4,24,101,0,113,
0,117,0,105,0,
118,0,97,0,108,
0,101,0,110,0,
99,0,101,0,50,
0,1,109,1967,1,
108,2252,19,2253,4,
22,100,0,97,0,
116,0,97,0,116,
0,121,0,112,0,
101,0,100,0,101,
0,102,0,1,108,
1967,1,107,2254,19,
2255,4,28,115,0,
117,0,98,0,115,
0,117,0,109,0,
112,0,116,0,105,
0,111,0,110,0,
95,0,105,0,102,
0,1,107,1967,1,
106,2256,19,2257,4,
26,110,0,111,0,
115,0,117,0,98,
0,115,0,117,0,
109,0,112,0,116,
0,105,0,111,0,
110,0,1,106,1967,
1,105,2258,19,2259,
4,22,115,0,117,
0,98,0,115,0,
117,0,109,0,112,
0,116,0,105,0,
111,0,110,0,1,
105,1967,1,104,2260,
19,2261,4,20,97,
0,110,0,110,0,
111,0,116,0,97,
0,116,0,105,0,
111,0,110,0,1,
104,1967,1,103,2262,
19,155,1,103,1967,
1,102,2263,19,103,
1,102,2009,1,101,
2264,19,187,1,101,
2265,5,124,1,393,
2266,17,2267,15,2268,
4,10,37,0,114,
0,111,0,108,0,
101,0,1,-1,1,
5,2269,20,1450,1,
438,1,3,1,2,
1,1,2270,22,1,
150,1,1574,2271,17,
2272,15,2273,4,28,
37,0,110,0,111,
0,116,0,82,0,
111,0,108,0,101,
0,87,0,105,0,
116,0,104,0,88,
0,89,0,1,-1,
1,5,2274,20,1517,
1,412,1,3,1,
5,1,4,2275,22,
1,119,1,391,2276,
17,2277,15,2278,4,
32,37,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
82,0,111,0,108,
0,101,0,69,0,
120,0,112,0,114,
0,50,0,1,-1,
1,5,2279,20,1419,
1,442,1,3,1,
3,1,2,2280,22,
1,154,1,390,2281,
17,2282,15,2278,1,
-1,1,5,2283,20,
1417,1,443,1,3,
1,3,1,2,2284,
22,1,155,1,1495,
2285,17,2286,15,2287,
4,40,37,0,99,
0,111,0,110,0,
100,0,105,0,116,
0,105,0,111,0,
110,0,95,0,114,
0,101,0,115,0,
117,0,108,0,116,
0,95,0,105,0,
115,0,1,-1,1,
5,2288,20,1910,1,
297,1,3,1,4,
1,3,2289,22,1,
40,1,111,2290,17,
2291,15,2292,4,18,
37,0,98,0,111,
0,117,0,110,0,
100,0,86,0,97,
0,108,0,1,-1,
1,5,2293,20,1157,
1,508,1,3,1,
3,1,2,2294,22,
1,212,1,1567,2295,
16,0,396,1,905,
2296,17,2297,15,2298,
4,34,37,0,105,
0,100,0,101,0,
110,0,116,0,111,
0,98,0,106,0,
101,0,99,0,116,
0,95,0,110,0,
97,0,109,0,101,
0,1,-1,1,5,
2299,20,1870,1,309,
1,3,1,3,1,
2,2300,22,1,52,
1,1762,2301,16,0,
185,1,579,2302,16,
0,464,1,1563,2303,
16,0,402,1,182,
2304,17,2305,15,2306,
4,32,37,0,105,
0,110,0,115,0,
116,0,97,0,110,
0,99,0,101,0,
66,0,105,0,103,
0,78,0,97,0,
109,0,101,0,1,
-1,1,5,2307,20,
1389,1,450,1,3,
1,2,1,1,2308,
22,1,162,1,181,
2309,17,2310,15,2306,
1,-1,1,5,2311,
20,1387,1,451,1,
3,1,2,1,1,
2312,22,1,163,1,
573,2313,17,2314,15,
2315,4,32,37,0,
97,0,110,0,100,
0,97,0,110,0,
121,0,114,0,111,
0,108,0,101,0,
99,0,104,0,97,
0,105,0,110,0,
1,-1,1,5,2316,
20,1515,1,413,1,
3,1,4,1,3,
2317,22,1,120,1,
572,2318,17,2319,15,
2315,1,-1,1,5,
2320,20,1513,1,414,
1,3,1,5,1,
4,2321,22,1,121,
1,389,2322,17,2323,
15,2324,4,32,37,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,82,0,
111,0,108,0,101,
0,69,0,120,0,
112,0,114,0,51,
0,1,-1,1,5,
2325,20,1415,1,444,
1,3,1,3,1,
2,2326,22,1,156,
1,67,2327,17,2328,
15,2329,4,18,37,
0,68,0,117,0,
114,0,97,0,116,
0,105,0,111,0,
110,0,1,-1,1,
5,2330,20,1114,1,
522,1,3,1,2,
1,1,2331,22,1,
226,1,563,2332,17,
2333,15,2315,1,-1,
1,5,2334,20,1511,
1,415,1,3,1,
6,1,5,2335,22,
1,122,1,562,2336,
17,2337,15,2315,1,
-1,1,5,2338,20,
1507,1,416,1,3,
1,7,1,6,2339,
22,1,123,1,1742,
2340,16,0,442,1,
65,2341,17,2342,15,
2343,4,10,37,0,
66,0,111,0,111,
0,108,0,1,-1,
1,5,2344,20,1046,
1,524,1,3,1,
2,1,1,2345,22,
1,228,1,1512,2346,
16,0,447,1,1737,
2347,16,0,224,1,
1538,2348,16,0,668,
1,1537,2349,17,2350,
15,2351,4,22,37,
0,114,0,111,0,
108,0,101,0,87,
0,105,0,116,0,
104,0,88,0,89,
0,1,-1,1,5,
2352,20,1529,1,409,
1,3,1,4,1,
3,2353,22,1,116,
1,284,2354,17,2355,
15,2356,4,50,37,
0,111,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
79,0,110,0,108,
0,121,0,83,0,
111,0,109,0,101,
0,116,0,104,0,
105,0,110,0,103,
0,84,0,104,0,
97,0,116,0,1,
-1,1,5,2357,20,
1328,1,466,1,3,
1,4,1,3,2358,
22,1,178,1,1534,
2359,17,2360,15,2351,
1,-1,1,5,2361,
20,1523,1,410,1,
3,1,4,1,3,
2362,22,1,117,1,
1731,2363,16,0,734,
1,117,2364,17,2365,
15,2366,4,12,37,
0,102,0,97,0,
99,0,101,0,116,
0,1,-1,1,5,
2367,20,1180,1,504,
1,3,1,4,1,
3,2368,22,1,208,
1,1583,2369,16,0,
374,1,1332,2370,17,
2371,15,2372,4,22,
37,0,115,0,105,
0,110,0,103,0,
108,0,101,0,78,
0,97,0,109,0,
101,0,1,-1,1,
5,2373,20,1310,1,
473,1,3,1,2,
1,1,2374,22,1,
185,1,346,2375,17,
2376,15,2278,1,-1,
1,5,2377,20,1421,
1,441,1,3,1,
2,1,1,2378,22,
1,153,1,344,2379,
17,2380,15,2381,4,
32,37,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
82,0,111,0,108,
0,101,0,69,0,
120,0,112,0,114,
0,49,0,1,-1,
1,5,2382,20,1423,
1,440,1,3,1,
3,1,2,2383,22,
1,152,1,257,2384,
17,2385,15,2386,4,
22,37,0,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,67,0,109,
0,112,0,1,-1,
1,5,2387,20,1320,
1,470,1,3,1,
4,1,3,2388,22,
1,182,1,342,2389,
17,2390,15,2381,1,
-1,1,5,2391,20,
1413,1,445,1,3,
1,4,1,3,2392,
22,1,157,1,549,
2393,16,0,479,1,
401,2394,17,2395,15,
2396,4,32,37,0,
115,0,105,0,110,
0,103,0,108,0,
101,0,84,0,104,
0,105,0,110,0,
103,0,84,0,104,
0,97,0,116,0,
1,-1,1,5,2397,
20,1298,1,479,1,
3,1,4,1,3,
2398,22,1,191,1,
130,2399,17,2400,15,
2401,4,20,37,0,
102,0,97,0,99,
0,101,0,116,0,
76,0,105,0,115,
0,116,0,1,-1,
1,5,2402,20,1178,
1,505,1,3,1,
2,1,1,2403,22,
1,209,1,129,2404,
17,2405,15,2366,1,
-1,1,5,2406,20,
1202,1,501,1,3,
1,3,1,2,2407,
22,1,205,1,1505,
2408,17,2409,15,2410,
4,28,37,0,99,
0,108,0,97,0,
117,0,115,0,101,
0,95,0,114,0,
101,0,115,0,117,
0,108,0,116,0,
1,-1,1,5,2411,
20,1944,1,283,1,
3,1,2,1,1,
2412,22,1,26,1,
1503,2413,17,2414,15,
2410,1,-1,1,5,
2415,20,1939,1,284,
1,3,1,4,1,
3,2416,22,1,27,
1,911,2417,17,2418,
15,2419,4,34,37,
0,105,0,100,0,
101,0,110,0,116,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,95,0,
105,0,110,0,115,
0,116,0,1,-1,
1,5,2420,20,1843,
1,313,1,3,1,
2,1,1,2421,22,
1,56,1,910,2422,
17,2423,15,2424,4,
20,37,0,105,0,
110,0,115,0,116,
0,97,0,110,0,
99,0,101,0,114,
0,1,-1,1,5,
2425,20,1841,1,314,
1,3,1,2,1,
1,2426,22,1,57,
1,909,2427,17,2428,
15,2424,1,-1,1,
5,2429,20,1820,1,
315,1,3,1,2,
1,1,2430,22,1,
58,1,908,2431,17,
2432,15,2298,1,-1,
1,5,2433,20,1866,
1,311,1,3,1,
6,1,5,2434,22,
1,54,1,1670,2435,
17,2436,15,2437,4,
18,37,0,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,65,0,1,
-1,1,5,2438,20,
1355,1,457,1,3,
1,3,1,2,2439,
22,1,169,1,118,
2440,17,2441,15,2366,
1,-1,1,5,2442,
20,1198,1,503,1,
3,1,3,1,2,
2443,22,1,207,1,
1496,2444,16,0,461,
1,904,2445,17,2446,
15,2298,1,-1,1,
5,2447,20,1864,1,
312,1,3,1,6,
1,5,2448,22,1,
55,1,114,2449,17,
2450,15,2401,1,-1,
1,5,2451,20,1161,
1,506,1,3,1,
4,1,3,2452,22,
1,210,1,901,2453,
17,2454,15,2298,1,
-1,1,5,2455,20,
1868,1,310,1,3,
1,3,1,2,2456,
22,1,53,1,112,
2457,17,2458,15,2459,
4,24,37,0,98,
0,111,0,117,0,
110,0,100,0,70,
0,97,0,99,0,
101,0,116,0,115,
0,1,-1,1,5,
2460,20,1159,1,507,
1,3,1,2,1,
1,2461,22,1,211,
1,1687,2462,16,0,
277,1,1489,2463,17,
2464,15,2287,1,-1,
1,5,2465,20,1908,
1,298,1,3,1,
4,1,3,2466,22,
1,41,1,306,2467,
17,2468,15,2278,1,
-1,1,5,2469,20,
1411,1,446,1,3,
1,4,1,3,2470,
22,1,158,1,305,
2471,17,2472,15,2278,
1,-1,1,5,2473,
20,1409,1,447,1,
3,1,4,1,3,
2474,22,1,159,1,
159,2475,17,2476,15,
2477,4,22,37,0,
111,0,111,0,98,
0,106,0,101,0,
99,0,116,0,66,
0,110,0,100,0,
1,-1,1,5,2478,
20,1324,1,468,1,
3,1,2,1,1,
2479,22,1,180,1,
1483,2480,17,2481,15,
2482,4,56,37,0,
99,0,111,0,110,
0,100,0,105,0,
116,0,105,0,111,
0,110,0,95,0,
114,0,101,0,115,
0,117,0,108,0,
116,0,95,0,100,
0,101,0,102,0,
105,0,110,0,105,
0,116,0,105,0,
111,0,110,0,1,
-1,1,5,2483,20,
1906,1,299,1,3,
1,4,1,3,2484,
22,1,42,1,300,
2485,17,2486,15,2437,
1,-1,1,5,2487,
20,1357,1,456,1,
3,1,2,1,1,
2488,22,1,168,1,
299,2489,17,2490,15,
2491,4,30,37,0,
111,0,111,0,98,
0,106,0,101,0,
99,0,116,0,78,
0,111,0,116,0,
104,0,105,0,110,
0,103,0,1,-1,
1,5,2492,20,1349,
1,460,1,3,1,
2,1,1,2493,22,
1,172,1,298,2494,
17,2495,15,2496,4,
42,37,0,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,83,0,111,
0,109,0,101,0,
116,0,104,0,105,
0,110,0,103,0,
84,0,104,0,97,
0,116,0,1,-1,
1,5,2497,20,1347,
1,461,1,3,1,
3,1,2,2498,22,
1,173,1,70,2499,
17,2500,15,2501,4,
14,37,0,78,0,
117,0,109,0,98,
0,101,0,114,0,
1,-1,1,5,2502,
20,1120,1,519,1,
3,1,2,1,1,
2503,22,1,223,1,
42,2504,17,2505,15,
2506,4,18,37,0,
98,0,111,0,117,
0,110,0,100,0,
65,0,110,0,100,
0,1,-1,1,5,
2507,20,1143,1,515,
1,3,1,4,1,
3,2508,22,1,219,
1,295,2509,17,2510,
15,2511,4,34,37,
0,111,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
83,0,111,0,109,
0,101,0,116,0,
104,0,105,0,110,
0,103,0,1,-1,
1,5,2512,20,1351,
1,459,1,3,1,
2,1,1,2513,22,
1,171,1,294,2514,
17,2515,15,2516,4,
32,37,0,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,73,0,110,
0,115,0,116,0,
97,0,110,0,99,
0,101,0,1,-1,
1,5,2517,20,1336,
1,462,1,3,1,
2,1,1,2518,22,
1,174,1,293,2519,
17,2520,15,2521,4,
38,37,0,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,79,0,110,
0,108,0,121,0,
78,0,111,0,116,
0,104,0,105,0,
110,0,103,0,1,
-1,1,5,2522,20,
1330,1,465,1,3,
1,2,1,1,2523,
22,1,177,1,318,
2524,17,2525,15,2268,
1,-1,1,5,2526,
20,1425,1,439,1,
3,1,4,1,3,
2527,22,1,151,1,
1473,2528,17,2529,15,
2530,4,44,37,0,
99,0,111,0,110,
0,100,0,105,0,
116,0,105,0,111,
0,110,0,95,0,
114,0,101,0,115,
0,117,0,108,0,
116,0,95,0,114,
0,111,0,108,0,
101,0,1,-1,1,
5,2531,20,1912,1,
296,1,3,1,6,
1,5,2532,22,1,
39,1,69,2533,17,
2534,15,2535,4,16,
37,0,83,0,116,
0,114,0,68,0,
97,0,116,0,97,
0,1,-1,1,5,
2536,20,1118,1,520,
1,3,1,2,1,
1,2537,22,1,224,
1,286,2538,17,2539,
15,2540,4,24,37,
0,111,0,111,0,
98,0,106,0,101,
0,99,0,116,0,
79,0,110,0,108,
0,121,0,1,-1,
1,5,2541,20,1334,
1,463,1,3,1,
3,1,2,2542,22,
1,175,1,285,2543,
17,2544,15,2545,4,
40,37,0,111,0,
111,0,98,0,106,
0,101,0,99,0,
116,0,79,0,110,
0,108,0,121,0,
73,0,110,0,115,
0,116,0,97,0,
110,0,99,0,101,
0,1,-1,1,5,
2546,20,1332,1,464,
1,3,1,3,1,
2,2547,22,1,176,
1,481,2548,17,2549,
15,2550,4,24,37,
0,105,0,110,0,
115,0,116,0,97,
0,110,0,99,0,
101,0,84,0,104,
0,101,0,1,-1,
1,5,2551,20,1367,
1,453,1,3,1,
3,1,2,2552,22,
1,165,1,68,2553,
17,2554,15,2555,4,
26,37,0,68,0,
97,0,116,0,101,
0,84,0,105,0,
109,0,101,0,68,
0,97,0,116,0,
97,0,1,-1,1,
5,2556,20,1116,1,
521,1,3,1,2,
1,1,2557,22,1,
225,1,1464,2558,17,
2371,1,1,2374,1,
292,2559,17,2560,15,
2561,4,24,37,0,
111,0,111,0,98,
0,106,0,101,0,
99,0,116,0,83,
0,101,0,108,0,
102,0,1,-1,1,
5,2562,20,1326,1,
467,1,3,1,2,
1,1,2563,22,1,
179,1,8,2564,17,
2565,15,2566,4,26,
37,0,105,0,110,
0,115,0,116,0,
97,0,110,0,99,
0,101,0,76,0,
105,0,115,0,116,
0,1,-1,1,5,
2567,20,1359,1,455,
1,3,1,4,1,
3,2568,22,1,167,
1,314,2569,17,2371,
1,1,2374,1,1457,
2570,17,2571,15,2530,
1,-1,1,5,2572,
20,1914,1,295,1,
3,1,4,1,3,
2573,22,1,38,1,
1456,2574,17,2575,15,
2576,4,62,37,0,
99,0,111,0,110,
0,100,0,105,0,
116,0,105,0,111,
0,110,0,95,0,
114,0,101,0,115,
0,117,0,108,0,
116,0,95,0,100,
0,97,0,116,0,
97,0,95,0,112,
0,114,0,111,0,
112,0,101,0,114,
0,116,0,121,0,
1,-1,1,5,2577,
20,1900,1,300,1,
3,1,5,1,4,
2578,22,1,43,1,
239,2579,17,2580,15,
2581,4,28,37,0,
111,0,111,0,98,
0,106,0,101,0,
99,0,116,0,67,
0,109,0,112,0,
66,0,110,0,100,
0,1,-1,1,5,
2582,20,1312,1,472,
1,3,1,4,1,
3,2583,22,1,184,
1,467,2584,17,2585,
15,2550,1,-1,1,
5,2586,20,1385,1,
452,1,3,1,3,
1,2,2587,22,1,
164,1,72,2588,17,
2589,15,2590,4,22,
37,0,98,0,111,
0,117,0,110,0,
100,0,79,0,110,
0,101,0,79,0,
102,0,1,-1,1,
5,2591,20,1153,1,
510,1,3,1,5,
1,4,2592,22,1,
214,1,71,2593,17,
2594,15,2501,1,-1,
1,5,2595,20,1122,
1,518,1,3,1,
2,1,1,2596,22,
1,222,1,661,2597,
17,2598,15,2599,4,
22,37,0,100,0,
97,0,116,0,97,
0,118,0,97,0,
108,0,118,0,97,
0,114,0,1,-1,
1,5,2600,20,1805,
1,318,1,3,1,
6,1,5,2601,22,
1,61,1,463,2602,
17,2603,15,2396,1,
-1,1,5,2604,20,
1296,1,480,1,3,
1,3,1,2,2605,
22,1,192,1,265,
2606,17,2607,15,2608,
4,30,37,0,111,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,79,0,
110,0,108,0,121,
0,66,0,110,0,
100,0,1,-1,1,
5,2609,20,1322,1,
469,1,3,1,3,
1,2,2610,22,1,
181,1,1643,2611,16,
0,408,1,66,2612,
17,2613,15,2614,4,
12,37,0,70,0,
108,0,111,0,97,
0,116,0,1,-1,
1,5,2615,20,1112,
1,523,1,3,1,
2,1,1,2616,22,
1,227,1,656,2617,
17,2618,15,2619,4,
22,37,0,100,0,
97,0,116,0,97,
0,118,0,97,0,
108,0,118,0,97,
0,108,0,1,-1,
1,5,2620,20,1750,
1,319,1,3,1,
2,1,1,2621,22,
1,62,1,1636,2622,
17,2623,15,2624,4,
44,37,0,111,0,
114,0,79,0,98,
0,106,0,101,0,
99,0,116,0,82,
0,111,0,108,0,
101,0,69,0,120,
0,112,0,114,0,
67,0,104,0,97,
0,105,0,110,0,
1,-1,1,5,2625,
20,1536,1,407,1,
3,1,4,1,3,
2626,22,1,114,1,
256,2627,17,2628,15,
2629,4,38,37,0,
111,0,111,0,98,
0,106,0,101,0,
99,0,116,0,67,
0,109,0,112,0,
73,0,110,0,115,
0,116,0,97,0,
110,0,99,0,101,
0,1,-1,1,5,
2630,20,1318,1,471,
1,3,1,4,1,
3,2631,22,1,183,
1,58,2632,17,2633,
15,2634,4,22,37,
0,98,0,111,0,
117,0,110,0,100,
0,84,0,111,0,
116,0,97,0,108,
0,1,-1,1,5,
2635,20,1149,1,512,
1,3,1,6,1,
5,2636,22,1,216,
1,120,2637,17,2638,
15,2366,1,-1,1,
5,2639,20,1200,1,
502,1,3,1,3,
1,2,2640,22,1,
206,1,55,2641,17,
2642,15,2643,4,28,
37,0,98,0,111,
0,117,0,110,0,
100,0,68,0,97,
0,116,0,97,0,
84,0,121,0,112,
0,101,0,1,-1,
1,5,2644,20,1147,
1,513,1,3,1,
6,1,5,2645,22,
1,217,1,447,2646,
17,2647,15,2648,4,
22,37,0,116,0,
104,0,97,0,116,
0,79,0,114,0,
76,0,111,0,111,
0,112,0,1,-1,
1,5,2649,20,1257,
1,484,1,3,1,
5,1,4,2650,22,
1,196,1,50,2651,
17,2652,15,2653,4,
22,37,0,98,0,
111,0,117,0,110,
0,100,0,73,0,
100,0,101,0,110,
0,116,0,1,-1,
1,5,2654,20,1145,
1,514,1,3,1,
4,1,3,2655,22,
1,218,1,208,2656,
17,2657,15,2658,4,
16,37,0,97,0,
110,0,100,0,108,
0,111,0,111,0,
112,0,1,-1,1,
5,2659,20,1255,1,
485,1,3,1,2,
1,1,2660,22,1,
197,1,60,2661,17,
2662,15,2663,4,18,
37,0,98,0,111,
0,117,0,110,0,
100,0,84,0,111,
0,112,0,1,-1,
1,5,2664,20,1151,
1,511,1,3,1,
5,1,4,2665,22,
1,215,1,35,2666,
17,2667,15,2668,4,
18,37,0,98,0,
111,0,117,0,110,
0,100,0,78,0,
111,0,116,0,1,
-1,1,5,2669,20,
1124,1,517,1,3,
1,3,1,2,2670,
22,1,221,1,1618,
2671,16,0,341,1,
1617,2672,17,2673,15,
2624,1,-1,1,5,
2674,20,1531,1,408,
1,3,1,4,1,
3,2675,22,1,115,
1,38,2676,17,2677,
15,2678,4,16,37,
0,98,0,111,0,
117,0,110,0,100,
0,79,0,114,0,
1,-1,1,5,2679,
20,1141,1,516,1,
3,1,4,1,3,
2680,22,1,220,1,
233,2681,17,2682,15,
2683,4,30,37,0,
115,0,105,0,110,
0,103,0,108,0,
101,0,78,0,97,
0,109,0,101,0,
84,0,104,0,97,
0,116,0,1,-1,
1,5,2684,20,1302,
1,477,1,3,1,
3,1,2,2685,22,
1,189,1,1414,2686,
16,0,543,1,230,
2687,17,2371,1,1,
2374,1,229,2688,17,
2689,15,2396,1,-1,
1,5,2690,20,1300,
1,478,1,3,1,
3,1,2,2691,22,
1,190,1,30,2692,
17,2693,15,2658,1,
-1,1,5,2694,20,
1245,1,486,1,3,
1,4,1,3,2695,
22,1,198,1,226,
2696,17,2697,15,2698,
4,24,37,0,115,
0,105,0,110,0,
103,0,108,0,101,
0,84,0,104,0,
105,0,110,0,103,
0,1,-1,1,5,
2699,20,1308,1,474,
1,3,1,2,1,
1,2700,22,1,186,
1,28,2701,17,2702,
15,2703,4,14,37,
0,111,0,114,0,
108,0,111,0,111,
0,112,0,1,-1,
1,5,2704,20,1234,
1,488,1,3,1,
4,1,3,2705,22,
1,200,1,421,2706,
17,2707,15,2278,1,
-1,1,5,2708,20,
1407,1,448,1,3,
1,5,1,4,2709,
22,1,160,1,420,
2710,17,2711,15,2278,
1,-1,1,5,2712,
20,1391,1,449,1,
3,1,5,1,4,
2713,22,1,161,1,
23,2714,17,2715,15,
2698,1,-1,1,5,
2716,20,1304,1,476,
1,3,1,2,1,
1,2717,22,1,188,
1,18,2718,17,2719,
15,2566,1,-1,1,
5,2720,20,1365,1,
454,1,3,1,4,
1,3,2721,22,1,
166,1,102,2722,17,
2723,15,2292,1,-1,
1,5,2724,20,1155,
1,509,1,3,1,
3,1,2,2725,22,
1,213,1,12,2726,
17,2727,15,2728,4,
24,37,0,115,0,
105,0,110,0,103,
0,108,0,101,0,
79,0,110,0,101,
0,79,0,102,0,
1,-1,1,5,2729,
20,1294,1,481,1,
3,1,3,1,2,
2730,22,1,193,1,
405,2731,17,2732,15,
2437,1,-1,1,5,
2733,20,1353,1,458,
1,3,1,4,1,
3,2734,22,1,170,
1,206,2735,17,2736,
15,2703,1,-1,1,
5,2737,20,1243,1,
487,1,3,1,2,
1,1,2738,22,1,
199,1,402,2739,17,
2436,1,2,2439,1,
204,2740,17,2741,15,
2648,1,-1,1,5,
2742,20,1273,1,483,
1,3,1,3,1,
2,2743,22,1,195,
1,6,2744,17,2745,
15,2728,1,-1,1,
5,2746,20,1275,1,
482,1,3,1,5,
1,4,2747,22,1,
194,1,1581,2748,16,
0,376,1,201,2749,
17,2750,15,2698,1,
-1,1,5,2751,20,
1306,1,475,1,3,
1,3,1,2,2752,
22,1,187,1,1579,
2753,17,2754,15,2273,
1,-1,1,5,2755,
20,1521,1,411,1,
3,1,5,1,4,
2756,22,1,118,1,
591,2757,16,0,451,
1,100,2758,19,493,
1,100,2759,5,95,
1,393,2266,1,391,
2276,1,390,2281,1,
389,2322,1,182,2304,
1,181,2309,1,573,
2313,1,572,2318,1,
563,2332,1,562,2336,
1,16,2760,16,0,
907,1,159,2475,1,
549,2761,16,0,491,
1,111,2290,1,1332,
2370,1,405,2731,1,
344,2379,1,257,2384,
1,342,2389,1,230,
2687,1,401,2394,1,
130,2399,1,129,2404,
1,318,2524,1,120,
2637,1,118,2440,1,
117,2364,1,114,2449,
1,28,2701,1,112,
2762,16,0,800,1,
1687,2763,16,0,907,
1,306,2467,1,305,
2471,1,300,2485,1,
299,2489,1,298,2494,
1,70,2499,1,42,
2504,1,295,2509,1,
294,2514,1,293,2519,
1,292,2559,1,1670,
2435,1,69,2533,1,
286,2538,1,285,2543,
1,284,2354,1,68,
2553,1,1464,2558,1,
8,2564,1,314,2569,
1,77,2764,17,2765,
15,2766,4,24,37,
0,100,0,97,0,
116,0,97,0,118,
0,97,0,108,0,
76,0,105,0,115,
0,116,0,1,-1,
1,5,2767,20,1044,
1,525,1,3,1,
4,1,3,2768,22,
1,229,1,75,2769,
16,0,907,1,467,
2584,1,72,2588,1,
71,2593,1,346,2375,
1,463,2602,1,265,
2606,1,67,2327,1,
66,2612,1,65,2341,
1,64,2770,17,2771,
15,2766,1,-1,1,
5,2772,20,1039,1,
526,1,3,1,4,
1,3,2773,22,1,
230,1,62,2774,16,
0,907,1,1636,2622,
1,256,2627,1,58,
2632,1,55,2641,1,
447,2646,1,50,2651,
1,1620,2775,16,0,
907,1,239,2579,1,
1617,2672,1,38,2676,
1,233,2681,1,35,
2666,1,481,2548,1,
229,2688,1,30,2692,
1,226,2696,1,60,
2661,1,421,2706,1,
420,2710,1,1601,2776,
16,0,907,1,23,
2714,1,18,2718,1,
102,2722,1,12,2777,
16,0,907,1,208,
2656,1,206,2735,1,
402,2739,1,204,2740,
1,6,2744,1,5,
2778,16,0,907,1,
201,2749,1,99,2779,
19,127,1,99,2780,
5,75,1,393,2266,
1,661,2597,1,1764,
2781,17,2782,15,2783,
4,24,37,0,115,
0,117,0,98,0,
115,0,117,0,109,
0,112,0,116,0,
105,0,111,0,110,
0,1,-1,1,5,
2784,20,2004,1,256,
1,3,1,5,1,
4,2785,22,1,4,
1,1568,2786,17,2787,
15,2788,4,40,37,
0,100,0,97,0,
116,0,97,0,114,
0,111,0,108,0,
101,0,115,0,117,
0,98,0,115,0,
117,0,109,0,112,
0,116,0,105,0,
111,0,110,0,1,
-1,1,5,2789,20,
1994,1,261,1,3,
1,12,1,11,2790,
22,1,9,1,582,
2791,17,2792,15,2793,
4,24,37,0,100,
0,97,0,116,0,
97,0,116,0,121,
0,112,0,101,0,
100,0,101,0,102,
0,1,-1,1,5,
2794,20,2000,1,258,
1,3,1,8,1,
7,2795,22,1,6,
1,1564,2796,17,2797,
15,2798,4,36,37,
0,100,0,97,0,
116,0,97,0,114,
0,111,0,108,0,
101,0,100,0,105,
0,115,0,106,0,
111,0,105,0,110,
0,116,0,50,0,
1,-1,1,5,2799,
20,1990,1,263,1,
3,1,13,1,12,
2800,22,1,11,1,
1468,2801,16,0,125,
1,1358,2802,16,0,
125,1,564,2803,17,
2804,15,2805,4,14,
37,0,104,0,97,
0,115,0,107,0,
101,0,121,0,1,
-1,1,5,2806,20,
1978,1,269,1,3,
1,8,1,7,2807,
22,1,17,1,1744,
2808,17,2809,15,2810,
4,28,37,0,110,
0,111,0,115,0,
117,0,98,0,115,
0,117,0,109,0,
112,0,116,0,105,
0,111,0,110,0,
1,-1,1,5,2811,
20,2002,1,257,1,
3,1,5,1,4,
2812,22,1,5,1,
167,2813,16,0,762,
1,976,2814,16,0,
125,1,65,2341,1,
1738,2815,17,2816,15,
2817,4,34,37,0,
114,0,111,0,108,
0,101,0,101,0,
113,0,117,0,105,
0,118,0,97,0,
108,0,101,0,110,
0,99,0,101,0,
50,0,1,-1,1,
5,2818,20,1986,1,
265,1,3,1,7,
1,6,2819,22,1,
13,1,1539,2820,17,
2821,15,2822,4,32,
37,0,114,0,111,
0,108,0,101,0,
115,0,117,0,98,
0,115,0,117,0,
109,0,112,0,116,
0,105,0,111,0,
110,0,1,-1,1,
5,2823,20,1996,1,
260,1,3,1,8,
1,7,2824,22,1,
8,1,15,2825,17,
2826,15,2827,4,16,
37,0,111,0,114,
0,67,0,111,0,
109,0,109,0,97,
0,1,-1,1,5,
214,1,1,1,1,
2828,22,1,143,1,
1732,2829,17,2830,15,
2831,4,42,37,0,
100,0,97,0,116,
0,97,0,114,0,
111,0,108,0,101,
0,101,0,113,0,
117,0,105,0,118,
0,97,0,108,0,
101,0,110,0,99,
0,101,0,50,0,
1,-1,1,5,2832,
20,1984,1,266,1,
3,1,11,1,10,
2833,22,1,14,1,
1336,2834,16,0,125,
1,1779,2835,17,2836,
15,2837,4,22,37,
0,97,0,110,0,
110,0,111,0,116,
0,97,0,116,0,
105,0,111,0,110,
0,1,-1,1,5,
2838,20,2006,1,255,
1,3,1,2,1,
1,2839,22,1,3,
1,346,2840,16,0,
762,1,1326,2841,16,
0,762,1,1645,2842,
17,2843,15,2844,4,
26,37,0,101,0,
113,0,117,0,105,
0,118,0,97,0,
108,0,101,0,110,
0,99,0,101,0,
50,0,1,-1,1,
5,2845,20,1988,1,
264,1,3,1,7,
1,6,2846,22,1,
12,1,1514,2847,17,
2848,15,2849,4,18,
37,0,115,0,119,
0,114,0,108,0,
114,0,117,0,108,
0,101,0,1,-1,
1,5,2850,20,1975,
1,271,1,3,1,
7,1,6,2851,22,
1,18,1,1316,2852,
16,0,125,1,327,
2853,16,0,762,1,
1506,2854,16,0,125,
1,1504,2855,17,2856,
15,2857,4,24,37,
0,115,0,119,0,
114,0,108,0,114,
0,117,0,108,0,
101,0,102,0,111,
0,114,0,1,-1,
1,5,2858,20,1973,
1,272,1,3,1,
14,1,13,2859,22,
1,19,1,1306,2860,
16,0,125,1,318,
2524,1,1497,2861,16,
0,125,1,1691,2862,
17,2863,15,2864,4,
30,37,0,101,0,
120,0,99,0,108,
0,117,0,115,0,
105,0,118,0,101,
0,117,0,110,0,
105,0,111,0,110,
0,1,-1,1,5,
2865,20,1982,1,267,
1,3,1,9,1,
8,2866,22,1,15,
1,308,2867,16,0,
762,1,1484,2868,16,
0,125,1,890,2869,
16,0,125,1,938,
2870,16,0,125,1,
1271,2871,16,0,125,
1,1664,2872,16,0,
762,1,868,2873,16,
0,125,1,1458,2874,
16,0,762,1,1490,
2875,16,0,125,1,
66,2612,1,71,2593,
1,70,2499,1,69,
2533,1,68,2553,1,
67,2327,1,263,2876,
16,0,762,1,656,
2617,1,1441,2877,16,
0,125,1,14,2878,
17,2879,15,2827,1,
-1,1,5,214,1,
1,1,1,2880,22,
1,144,1,1435,2881,
16,0,125,1,7,
2882,16,0,762,1,
1582,2883,17,2884,15,
2885,4,28,37,0,
114,0,111,0,108,
0,101,0,100,0,
105,0,115,0,106,
0,111,0,105,0,
110,0,116,0,50,
0,1,-1,1,5,
2886,20,1992,1,262,
1,3,1,8,1,
7,2887,22,1,10,
1,1619,2888,17,2889,
15,2890,4,22,37,
0,101,0,120,0,
99,0,108,0,117,
0,115,0,105,0,
118,0,101,0,115,
0,1,-1,1,5,
2891,20,1980,1,268,
1,3,1,7,1,
6,2892,22,1,16,
1,237,2893,16,0,
762,1,236,2894,17,
2895,15,2896,4,156,
37,0,119,0,111,
0,114,0,100,0,
95,0,110,0,117,
0,109,0,98,0,
101,0,114,0,95,
0,102,0,50,0,
57,0,102,0,52,
0,98,0,52,0,
53,0,100,0,52,
0,102,0,54,0,
52,0,52,0,48,
0,102,0,97,0,
97,0,98,0,55,
0,98,0,48,0,
51,0,56,0,100,
0,54,0,51,0,
101,0,56,0,48,
0,49,0,54,0,
95,0,49,0,99,
0,101,0,49,0,
54,0,56,0,51,
0,49,0,55,0,
57,0,54,0,99,
0,52,0,100,0,
97,0,51,0,97,
0,101,0,102,0,
49,0,97,0,99,
0,101,0,51,0,
53,0,53,0,101,
0,51,0,48,0,
98,0,98,0,101,
0,1,-1,1,5,
2897,20,1212,1,497,
1,3,1,2,1,
1,2898,22,1,203,
1,235,2899,17,2900,
15,2901,4,156,37,
0,119,0,111,0,
114,0,100,0,95,
0,110,0,117,0,
109,0,98,0,101,
0,114,0,95,0,
55,0,53,0,98,
0,100,0,53,0,
97,0,54,0,99,
0,100,0,100,0,
102,0,51,0,52,
0,55,0,97,0,
48,0,57,0,99,
0,97,0,54,0,
51,0,48,0,50,
0,49,0,99,0,
56,0,101,0,100,
0,50,0,54,0,
97,0,100,0,95,
0,102,0,97,0,
98,0,97,0,50,
0,98,0,54,0,
100,0,54,0,54,
0,97,0,98,0,
52,0,53,0,53,
0,48,0,97,0,
48,0,50,0,98,
0,98,0,55,0,
52,0,51,0,51,
0,51,0,48,0,
52,0,49,0,101,
0,99,0,57,0,
1,-1,1,5,2902,
20,1204,1,500,1,
3,1,2,1,1,
2903,22,1,204,1,
1415,2904,17,2905,15,
2906,4,16,37,0,
101,0,120,0,101,
0,114,0,117,0,
108,0,101,0,1,
-1,1,5,2907,20,
1971,1,273,1,3,
1,9,1,8,2908,
22,1,20,1,33,
2909,16,0,762,1,
1799,2910,17,2911,15,
2912,4,20,37,0,
112,0,97,0,114,
0,97,0,103,0,
114,0,97,0,112,
0,104,0,1,-1,
1,5,2913,20,2012,
1,253,1,3,1,
2,1,1,2914,22,
1,1,1,1797,2915,
17,2916,15,2912,1,
-1,1,5,2917,20,
2008,1,254,1,3,
1,3,1,2,2918,
22,1,2,1,1398,
2919,16,0,125,1,
1397,2920,17,2921,15,
2922,4,152,37,0,
109,0,111,0,100,
0,97,0,108,0,
105,0,116,0,121,
0,50,0,95,0,
54,0,53,0,99,
0,52,0,102,0,
53,0,52,0,50,
0,100,0,100,0,
98,0,100,0,52,
0,101,0,49,0,
56,0,98,0,99,
0,98,0,48,0,
56,0,100,0,102,
0,97,0,55,0,
102,0,56,0,57,
0,101,0,102,0,
99,0,54,0,95,
0,49,0,55,0,
100,0,51,0,57,
0,56,0,100,0,
54,0,54,0,49,
0,102,0,98,0,
52,0,100,0,53,
0,50,0,56,0,
102,0,48,0,57,
0,98,0,98,0,
54,0,98,0,98,
0,97,0,98,0,
49,0,52,0,53,
0,48,0,102,0,
1,-1,1,5,2923,
20,1452,1,437,1,
3,1,4,1,3,
2924,22,1,136,1,
17,2925,16,0,762,
1,1394,2926,17,2927,
15,2928,4,152,37,
0,109,0,111,0,
100,0,97,0,108,
0,105,0,116,0,
121,0,50,0,95,
0,97,0,57,0,
57,0,48,0,51,
0,98,0,98,0,
55,0,53,0,56,
0,48,0,50,0,
52,0,53,0,98,
0,53,0,56,0,
56,0,51,0,48,
0,54,0,48,0,
97,0,100,0,98,
0,52,0,49,0,
99,0,102,0,51,
0,101,0,55,0,
95,0,53,0,57,
0,55,0,56,0,
102,0,55,0,56,
0,49,0,54,0,
54,0,53,0,99,
0,52,0,54,0,
102,0,53,0,56,
0,57,0,56,0,
100,0,50,0,54,
0,49,0,50,0,
51,0,102,0,55,
0,51,0,99,0,
55,0,100,0,97,
0,1,-1,1,5,
2929,20,1460,1,434,
1,3,1,1,1,
0,2930,22,1,135,
1,211,2931,16,0,
762,1,11,2932,16,
0,762,1,1584,2933,
17,2934,15,2822,1,
-1,1,5,2935,20,
1998,1,259,1,3,
1,8,1,7,2936,
22,1,7,1,1780,
2937,16,0,523,1,
400,2938,17,2939,15,
2940,4,16,37,0,
105,0,115,0,66,
0,101,0,65,0,
114,0,101,0,1,
-1,1,5,300,1,
1,1,1,2941,22,
1,139,1,399,2942,
17,2943,15,2940,1,
-1,1,5,300,1,
1,1,1,2944,22,
1,140,1,4,2945,
16,0,762,1,593,
2946,16,0,125,1,
592,2947,17,2948,15,
2949,4,10,37,0,
99,0,111,0,100,
0,101,0,1,-1,
1,5,2950,20,1966,
1,274,1,3,1,
3,1,2,2951,22,
1,21,1,0,2952,
16,0,523,1,98,
2953,19,124,1,98,
2954,5,75,1,393,
2266,1,661,2597,1,
1764,2781,1,1568,2786,
1,582,2791,1,1564,
2796,1,1468,2955,16,
0,122,1,1358,2956,
16,0,122,1,564,
2803,1,1744,2808,1,
167,2957,16,0,761,
1,976,2958,16,0,
122,1,65,2341,1,
1738,2815,1,1539,2820,
1,15,2825,1,1732,
2829,1,1336,2959,16,
0,122,1,1779,2835,
1,346,2960,16,0,
761,1,1326,2961,16,
0,761,1,1645,2842,
1,1514,2847,1,1316,
2962,16,0,122,1,
327,2963,16,0,761,
1,1506,2964,16,0,
122,1,1504,2855,1,
1306,2965,16,0,122,
1,318,2524,1,1497,
2966,16,0,122,1,
1691,2862,1,308,2967,
16,0,761,1,1484,
2968,16,0,122,1,
890,2969,16,0,122,
1,938,2970,16,0,
122,1,1271,2971,16,
0,122,1,1664,2972,
16,0,761,1,868,
2973,16,0,122,1,
1458,2974,16,0,761,
1,1490,2975,16,0,
122,1,66,2612,1,
71,2593,1,70,2499,
1,69,2533,1,68,
2553,1,67,2327,1,
263,2976,16,0,761,
1,656,2617,1,1441,
2977,16,0,122,1,
14,2878,1,1435,2978,
16,0,122,1,7,
2979,16,0,761,1,
1582,2883,1,1619,2888,
1,237,2980,16,0,
761,1,236,2894,1,
235,2899,1,1415,2904,
1,33,2981,16,0,
761,1,1799,2910,1,
1797,2915,1,1398,2982,
16,0,122,1,1397,
2920,1,17,2983,16,
0,761,1,1394,2926,
1,211,2984,16,0,
761,1,11,2985,16,
0,761,1,1584,2933,
1,1780,2986,16,0,
522,1,400,2938,1,
399,2942,1,4,2987,
16,0,761,1,593,
2988,16,0,122,1,
592,2947,1,0,2989,
16,0,522,1,97,
2990,19,139,1,97,
2991,5,174,1,1715,
2992,16,0,614,1,
421,2706,1,420,2710,
1,42,2504,1,1332,
2370,1,1270,2993,16,
0,630,1,405,2731,
1,402,2739,1,401,
2394,1,400,2938,1,
399,2942,1,398,2994,
17,2995,15,2996,4,
16,37,0,100,0,
111,0,101,0,115,
0,78,0,111,0,
116,0,1,-1,1,
5,738,1,1,1,
1,2997,22,1,145,
1,397,2998,17,2999,
15,2996,1,-1,1,
5,738,1,1,1,
1,3000,22,1,146,
1,396,3001,17,3002,
15,3003,4,20,37,
0,100,0,111,0,
101,0,115,0,78,
0,111,0,116,0,
66,0,121,0,1,
-1,1,5,885,1,
1,1,1,3004,22,
1,147,1,395,3005,
17,3006,15,3003,1,
-1,1,5,885,1,
1,1,1,3007,22,
1,148,1,394,3008,
17,3009,15,3003,1,
-1,1,5,885,1,
1,1,1,3010,22,
1,149,1,393,2266,
1,391,2276,1,1551,
3011,16,0,614,1,
389,2322,1,1674,3012,
16,0,614,1,1670,
2435,1,1668,3013,16,
0,693,1,1664,3014,
16,0,656,1,292,
2559,1,955,3015,17,
3016,15,3017,4,24,
37,0,111,0,98,
0,106,0,101,0,
99,0,116,0,114,
0,95,0,110,0,
105,0,111,0,1,
-1,1,5,3018,20,
1818,1,316,1,3,
1,2,1,1,3019,
22,1,59,1,33,
3020,16,0,728,1,
1642,3021,16,0,614,
1,1639,3022,16,0,
614,1,1637,3023,17,
3024,15,3025,4,150,
37,0,109,0,111,
0,100,0,97,0,
108,0,105,0,116,
0,121,0,95,0,
56,0,102,0,54,
0,57,0,98,0,
99,0,50,0,56,
0,50,0,54,0,
101,0,49,0,52,
0,97,0,54,0,
52,0,98,0,54,
0,53,0,53,0,
101,0,49,0,100,
0,54,0,52,0,
100,0,52,0,57,
0,55,0,97,0,
55,0,53,0,95,
0,54,0,101,0,
55,0,100,0,49,
0,99,0,53,0,
99,0,98,0,57,
0,53,0,99,0,
52,0,57,0,53,
0,56,0,56,0,
54,0,99,0,97,
0,99,0,50,0,
52,0,99,0,54,
0,99,0,53,0,
48,0,53,0,99,
0,57,0,101,0,
1,-1,1,5,3026,
20,1477,1,428,1,
3,1,1,1,0,
3027,22,1,133,1,
342,2389,1,69,2533,
1,1623,3028,16,0,
614,1,327,3029,16,
0,728,1,318,2524,
1,1586,3030,17,3031,
15,3032,4,150,37,
0,109,0,111,0,
100,0,97,0,108,
0,105,0,116,0,
121,0,95,0,50,
0,57,0,57,0,
52,0,57,0,56,
0,53,0,100,0,
48,0,99,0,100,
0,99,0,52,0,
100,0,55,0,52,
0,98,0,100,0,
101,0,56,0,49,
0,52,0,53,0,
55,0,48,0,99,
0,50,0,57,0,
56,0,98,0,51,
0,49,0,95,0,
53,0,49,0,97,
0,49,0,101,0,
52,0,57,0,54,
0,55,0,101,0,
98,0,52,0,52,
0,48,0,51,0,
98,0,97,0,50,
0,101,0,100,0,
102,0,102,0,98,
0,54,0,99,0,
52,0,49,0,50,
0,55,0,101,0,
98,0,100,0,1,
-1,1,5,3033,20,
1466,1,431,1,3,
1,2,1,1,3034,
22,1,134,1,314,
2569,1,1604,3035,16,
0,614,1,1761,3036,
16,0,614,1,308,
3037,16,0,656,1,
306,2467,1,305,2471,
1,300,2485,1,299,
2489,1,298,2494,1,
1588,3038,16,0,614,
1,294,2514,1,293,
2519,1,1585,3039,17,
3024,1,0,3027,1,
286,2538,1,285,2543,
1,1577,3040,16,0,
166,1,1576,3041,16,
0,426,1,1572,3042,
16,0,391,1,1571,
3043,16,0,429,1,
265,2606,1,263,3044,
16,0,728,1,262,
3045,17,3046,15,3047,
4,8,37,0,97,
0,65,0,110,0,
1,-1,1,5,293,
1,1,1,1,3048,
22,1,137,1,50,
2651,1,344,2379,1,
257,2384,1,256,2627,
1,1542,3049,16,0,
614,1,499,3050,17,
3051,15,3052,4,20,
37,0,115,0,117,
0,98,0,106,0,
101,0,99,0,116,
0,78,0,111,0,
1,-1,1,5,3053,
20,1488,1,424,1,
3,1,3,1,2,
3054,22,1,131,1,
1556,3055,16,0,614,
1,1535,3056,16,0,
426,1,15,2825,1,
239,2579,1,237,3057,
16,0,728,1,236,
2894,1,235,2899,1,
233,2681,1,1524,3058,
16,0,614,1,230,
2687,1,229,2688,1,
226,2696,1,1517,3059,
16,0,614,1,390,
2281,1,211,3060,16,
0,728,1,210,3061,
16,0,736,1,208,
2656,1,206,2735,1,
204,2740,1,203,3062,
16,0,614,1,201,
2749,1,200,3063,16,
0,595,1,963,3064,
17,3065,15,3066,4,
30,37,0,110,0,
111,0,116,0,105,
0,100,0,101,0,
110,0,116,0,111,
0,98,0,106,0,
101,0,99,0,116,
0,1,-1,1,5,
3067,20,1885,1,306,
1,3,1,3,1,
2,3068,22,1,49,
1,182,2304,1,181,
2309,1,1464,2558,1,
1458,3069,16,0,501,
1,967,3070,17,3071,
15,3066,1,-1,1,
5,3072,20,1887,1,
305,1,3,1,3,
1,2,3073,22,1,
48,1,159,2475,1,
284,2354,1,346,3074,
16,0,728,1,1440,
3075,16,0,517,1,
574,3076,16,0,469,
1,565,3077,16,0,
614,1,35,2666,1,
130,2399,1,129,2404,
1,954,3078,17,3079,
15,3080,4,22,37,
0,111,0,98,0,
106,0,101,0,99,
0,116,0,114,0,
95,0,105,0,111,
0,1,-1,1,5,
3081,20,1807,1,317,
1,3,1,2,1,
1,3082,22,1,60,
1,554,3083,16,0,
484,1,553,3084,16,
0,614,1,120,2637,
1,118,2440,1,117,
2364,1,295,2509,1,
114,2449,1,975,3085,
16,0,137,1,112,
2457,1,111,2290,1,
970,3086,17,3087,15,
3066,1,-1,1,5,
3088,20,1883,1,307,
1,3,1,6,1,
5,3089,22,1,50,
1,1759,3090,17,3024,
1,0,3027,1,966,
3091,17,3092,15,3066,
1,-1,1,5,3093,
20,1872,1,308,1,
3,1,6,1,5,
3094,22,1,51,1,
534,3095,16,0,614,
1,102,2722,1,532,
3096,17,3097,15,3098,
4,26,37,0,115,
0,117,0,98,0,
106,0,101,0,99,
0,116,0,69,0,
118,0,101,0,114,
0,121,0,1,-1,
1,5,3099,20,1505,
1,417,1,3,1,
3,1,2,3100,22,
1,124,1,962,3101,
16,0,866,1,959,
3102,16,0,137,1,
524,3103,16,0,728,
1,523,3104,17,3105,
15,3106,4,36,37,
0,115,0,117,0,
98,0,106,0,101,
0,99,0,116,0,
69,0,118,0,101,
0,114,0,121,0,
116,0,104,0,105,
0,110,0,103,0,
1,-1,1,5,3107,
20,1501,1,419,1,
3,1,3,1,2,
3108,22,1,126,1,
520,3109,17,3110,15,
3106,1,-1,1,5,
3111,20,1503,1,418,
1,3,1,2,1,
1,3112,22,1,125,
1,519,3113,17,3114,
15,3115,4,30,37,
0,115,0,117,0,
98,0,106,0,101,
0,99,0,116,0,
66,0,105,0,103,
0,78,0,97,0,
109,0,101,0,1,
-1,1,5,3116,20,
1499,1,420,1,3,
1,2,1,1,3117,
22,1,127,1,518,
3118,17,3119,15,3115,
1,-1,1,5,3120,
20,1497,1,421,1,
3,1,2,1,1,
3121,22,1,128,1,
517,3122,17,3123,15,
3124,4,22,37,0,
115,0,117,0,98,
0,106,0,101,0,
99,0,116,0,84,
0,104,0,101,0,
1,-1,1,5,3125,
20,1495,1,422,1,
3,1,3,1,2,
3126,22,1,129,1,
509,3127,16,0,728,
1,508,3128,17,3129,
15,3124,1,-1,1,
5,3130,20,1490,1,
423,1,3,1,3,
1,2,3131,22,1,
130,1,72,2588,1,
71,2593,1,70,2499,
1,500,3132,16,0,
728,1,68,2553,1,
67,2327,1,66,2612,
1,65,2341,1,60,
2661,1,58,2632,1,
55,2641,1,52,3133,
16,0,859,1,481,
2548,1,911,2417,1,
910,2422,1,909,2427,
1,908,2431,1,905,
2296,1,904,2445,1,
901,2453,1,38,2676,
1,899,3134,16,0,
137,1,467,2584,1,
1532,3135,16,0,429,
1,1326,3136,16,0,
587,1,463,2602,1,
31,3137,16,0,883,
1,30,2692,1,29,
3138,16,0,614,1,
28,2701,1,27,3139,
16,0,614,1,25,
3140,16,0,614,1,
23,2714,1,20,3141,
16,0,728,1,18,
2718,1,1741,3142,16,
0,614,1,447,2646,
1,1739,3143,17,3024,
1,0,3027,1,14,
2878,1,12,2726,1,
9,3144,16,0,728,
1,8,2564,1,6,
2744,1,2,3145,16,
0,728,1,1,3146,
17,3147,15,3148,4,
30,37,0,115,0,
117,0,98,0,106,
0,101,0,99,0,
116,0,78,0,111,
0,116,0,104,0,
105,0,110,0,103,
0,1,-1,1,5,
3149,20,1483,1,425,
1,3,1,2,1,
1,3150,22,1,132,
1,1724,3151,16,0,
614,1,96,3152,19,
837,1,96,3153,5,
86,1,979,3154,16,
0,835,1,779,3155,
16,0,835,1,776,
3156,17,3157,15,3158,
4,148,37,0,101,
0,113,0,117,0,
97,0,108,0,84,
0,111,0,95,0,
100,0,97,0,49,
0,97,0,53,0,
99,0,101,0,52,
0,101,0,102,0,
97,0,102,0,52,
0,55,0,57,0,
101,0,56,0,57,
0,100,0,57,0,
57,0,50,0,97,
0,51,0,49,0,
51,0,51,0,55,
0,50,0,48,0,
98,0,55,0,95,
0,99,0,55,0,
55,0,99,0,99,
0,99,0,48,0,
102,0,53,0,54,
0,51,0,101,0,
52,0,98,0,101,
0,98,0,57,0,
53,0,101,0,57,
0,99,0,51,0,
50,0,51,0,100,
0,54,0,55,0,
55,0,50,0,97,
0,100,0,55,0,
1,-1,1,5,3159,
20,1710,1,339,1,
3,1,3,1,2,
3160,22,1,68,1,
1168,3161,16,0,835,
1,67,2327,1,69,
2533,1,1358,3162,16,
0,835,1,76,3163,
16,0,835,1,1159,
3164,16,0,835,1,
763,3165,16,0,835,
1,1220,3166,16,0,
835,1,167,3167,16,
0,835,1,754,3168,
16,0,835,1,1142,
3169,16,0,835,1,
1118,3170,16,0,835,
1,63,3171,16,0,
835,1,774,3172,17,
3173,15,3174,4,148,
37,0,101,0,113,
0,117,0,97,0,
108,0,84,0,111,
0,95,0,48,0,
50,0,101,0,49,
0,48,0,50,0,
57,0,54,0,51,
0,49,0,98,0,
102,0,52,0,98,
0,55,0,48,0,
57,0,97,0,52,
0,54,0,57,0,
100,0,102,0,48,
0,51,0,100,0,
51,0,55,0,101,
0,99,0,48,0,
49,0,95,0,97,
0,98,0,48,0,
54,0,56,0,51,
0,99,0,55,0,
51,0,98,0,49,
0,101,0,52,0,
55,0,54,0,49,
0,57,0,98,0,
49,0,50,0,56,
0,50,0,52,0,
101,0,53,0,49,
0,98,0,100,0,
56,0,57,0,51,
0,56,0,1,-1,
1,5,3175,20,1689,
1,342,1,3,1,
2,1,1,3176,22,
1,69,1,743,3177,
16,0,835,1,1127,
3178,16,0,835,1,
929,3179,16,0,835,
1,727,3180,16,0,
835,1,941,3181,16,
0,835,1,921,3182,
16,0,835,1,718,
3183,16,0,835,1,
1109,3184,16,0,835,
1,121,3185,16,0,
835,1,709,3186,16,
0,835,1,593,3187,
16,0,835,1,1094,
3188,16,0,835,1,
695,3189,16,0,835,
1,103,3190,16,0,
835,1,890,3191,16,
0,835,1,1085,3192,
16,0,835,1,1278,
3193,16,0,835,1,
686,3194,16,0,835,
1,94,3195,16,0,
835,1,1076,3196,16,
0,835,1,877,3197,
16,0,835,1,70,
2499,1,674,3198,16,
0,835,1,868,3199,
16,0,835,1,1261,
3200,17,3201,15,3202,
4,142,37,0,117,
0,110,0,79,0,
112,0,95,0,52,
0,53,0,99,0,
50,0,54,0,50,
0,48,0,100,0,
99,0,51,0,55,
0,52,0,52,0,
97,0,48,0,55,
0,57,0,56,0,
98,0,56,0,56,
0,98,0,101,0,
50,0,53,0,57,
0,97,0,51,0,
49,0,51,0,51,
0,101,0,95,0,
52,0,57,0,54,
0,54,0,102,0,
48,0,50,0,50,
0,55,0,56,0,
54,0,57,0,52,
0,53,0,54,0,
49,0,57,0,97,
0,98,0,56,0,
98,0,97,0,99,
0,53,0,100,0,
99,0,49,0,99,
0,52,0,100,0,
97,0,55,0,1,
-1,1,5,3203,20,
1640,1,362,1,3,
1,2,1,1,3204,
22,1,79,1,1260,
3205,17,3206,15,3207,
4,142,37,0,117,
0,110,0,79,0,
112,0,95,0,99,
0,55,0,52,0,
101,0,101,0,52,
0,49,0,56,0,
53,0,51,0,97,
0,102,0,52,0,
100,0,48,0,56,
0,56,0,57,0,
55,0,98,0,48,
0,56,0,98,0,
50,0,49,0,97,
0,56,0,98,0,
48,0,52,0,98,
0,98,0,95,0,
102,0,50,0,52,
0,54,0,99,0,
101,0,97,0,49,
0,101,0,100,0,
51,0,57,0,52,
0,51,0,57,0,
54,0,56,0,50,
0,52,0,97,0,
55,0,101,0,55,
0,97,0,50,0,
100,0,97,0,52,
0,55,0,54,0,
48,0,57,0,1,
-1,1,5,3208,20,
1634,1,365,1,3,
1,2,1,1,3209,
22,1,80,1,1259,
3210,17,3211,15,3212,
4,142,37,0,117,
0,110,0,79,0,
112,0,95,0,98,
0,50,0,57,0,
102,0,98,0,51,
0,57,0,97,0,
56,0,97,0,50,
0,99,0,52,0,
97,0,100,0,54,
0,98,0,50,0,
55,0,52,0,57,
0,56,0,49,0,
102,0,56,0,97,
0,50,0,50,0,
49,0,51,0,54,
0,99,0,95,0,
100,0,101,0,102,
0,101,0,101,0,
99,0,54,0,100,
0,51,0,101,0,
57,0,48,0,52,
0,57,0,50,0,
51,0,98,0,51,
0,100,0,99,0,
98,0,55,0,100,
0,97,0,97,0,
52,0,101,0,52,
0,51,0,97,0,
100,0,49,0,1,
-1,1,5,3213,20,
1628,1,368,1,3,
1,2,1,1,3214,
22,1,81,1,1258,
3215,17,3216,15,3217,
4,142,37,0,117,
0,110,0,79,0,
112,0,95,0,55,
0,98,0,55,0,
100,0,57,0,48,
0,97,0,55,0,
98,0,98,0,57,
0,49,0,52,0,
51,0,57,0,101,
0,57,0,97,0,
57,0,57,0,97,
0,57,0,55,0,
99,0,57,0,98,
0,54,0,56,0,
97,0,97,0,97,
0,51,0,95,0,
48,0,51,0,50,
0,97,0,50,0,
56,0,55,0,100,
0,100,0,98,0,
50,0,49,0,52,
0,52,0,49,0,
57,0,98,0,56,
0,102,0,100,0,
49,0,48,0,57,
0,99,0,54,0,
49,0,54,0,100,
0,52,0,97,0,
57,0,48,0,1,
-1,1,5,3218,20,
1619,1,371,1,3,
1,2,1,1,3219,
22,1,82,1,1048,
3220,16,0,835,1,
71,2593,1,661,2597,
1,857,3221,16,0,
835,1,68,2553,1,
1446,3222,16,0,835,
1,66,2612,1,656,
2617,1,65,2341,1,
1245,3223,16,0,835,
1,61,3224,16,0,
835,1,647,3225,16,
0,835,1,1039,3226,
16,0,835,1,1234,
3227,16,0,835,1,
835,3228,16,0,835,
1,1425,3229,16,0,
835,1,1030,3230,16,
0,835,1,828,3231,
17,3232,15,3233,4,
152,37,0,99,0,
111,0,109,0,112,
0,97,0,114,0,
101,0,114,0,50,
0,95,0,52,0,
54,0,57,0,99,
0,98,0,57,0,
99,0,53,0,102,
0,51,0,53,0,
97,0,52,0,56,
0,55,0,56,0,
98,0,56,0,52,
0,98,0,55,0,
53,0,51,0,101,
0,100,0,53,0,
97,0,97,0,54,
0,97,0,49,0,
97,0,95,0,100,
0,97,0,102,0,
50,0,99,0,57,
0,99,0,54,0,
101,0,53,0,99,
0,56,0,52,0,
50,0,50,0,97,
0,57,0,101,0,
55,0,49,0,55,
0,56,0,50,0,
97,0,100,0,54,
0,51,0,102,0,
49,0,97,0,102,
0,52,0,1,-1,
1,5,3234,20,1725,
1,332,1,3,1,
2,1,1,3235,22,
1,66,1,827,3236,
17,3237,15,3238,4,
152,37,0,99,0,
111,0,109,0,112,
0,97,0,114,0,
101,0,114,0,50,
0,95,0,49,0,
49,0,101,0,49,
0,48,0,54,0,
101,0,99,0,55,
0,51,0,53,0,
55,0,52,0,101,
0,48,0,100,0,
56,0,56,0,53,
0,51,0,97,0,
100,0,50,0,57,
0,100,0,102,0,
98,0,51,0,101,
0,100,0,56,0,
101,0,95,0,50,
0,55,0,98,0,
50,0,57,0,48,
0,97,0,52,0,
56,0,101,0,102,
0,53,0,52,0,
53,0,99,0,49,
0,56,0,52,0,
56,0,102,0,100,
0,54,0,102,0,
51,0,52,0,48,
0,98,0,102,0,
56,0,50,0,51,
0,57,0,1,-1,
1,5,3239,20,1717,
1,335,1,3,1,
2,1,1,3240,22,
1,67,1,629,3241,
16,0,835,1,1017,
3242,16,0,835,1,
620,3243,16,0,835,
1,816,3244,16,0,
835,1,1209,3245,16,
0,835,1,844,3246,
16,0,835,1,790,
3247,17,3248,15,3249,
4,144,37,0,117,
0,110,0,79,0,
112,0,50,0,95,
0,97,0,54,0,
102,0,52,0,52,
0,102,0,51,0,
55,0,52,0,100,
0,52,0,54,0,
52,0,56,0,55,
0,98,0,57,0,
51,0,97,0,100,
0,51,0,55,0,
51,0,51,0,100,
0,51,0,99,0,
54,0,56,0,97,
0,54,0,99,0,
95,0,98,0,97,
0,55,0,102,0,
52,0,57,0,101,
0,98,0,52,0,
97,0,51,0,98,
0,52,0,56,0,
52,0,97,0,57,
0,97,0,54,0,
100,0,54,0,48,
0,54,0,97,0,
102,0,49,0,53,
0,50,0,55,0,
98,0,101,0,57,
0,1,-1,1,5,
3250,20,1610,1,375,
1,3,1,2,1,
1,3251,22,1,83,
1,611,3252,16,0,
835,1,1398,3253,16,
0,835,1,1003,3254,
16,0,835,1,805,
3255,16,0,835,1,
15,2825,1,14,2878,
1,1195,3256,16,0,
835,1,602,3257,16,
0,835,1,1057,3258,
16,0,835,1,794,
3259,16,0,835,1,
793,3260,17,3261,15,
3262,4,144,37,0,
98,0,105,0,110,
0,79,0,112,0,
95,0,100,0,48,
0,51,0,99,0,
98,0,50,0,57,
0,51,0,50,0,
99,0,56,0,101,
0,52,0,102,0,
48,0,97,0,98,
0,56,0,48,0,
57,0,53,0,50,
0,56,0,54,0,
49,0,50,0,51,
0,102,0,54,0,
55,0,57,0,55,
0,95,0,54,0,
100,0,48,0,49,
0,51,0,51,0,
55,0,50,0,55,
0,56,0,54,0,
98,0,52,0,101,
0,55,0,50,0,
57,0,52,0,101,
0,55,0,48,0,
55,0,51,0,54,
0,57,0,98,0,
49,0,56,0,55,
0,102,0,51,0,
57,0,1,-1,1,
5,3263,20,1661,1,
352,1,3,1,2,
1,1,3264,22,1,
76,1,792,3265,17,
3266,15,3267,4,144,
37,0,98,0,105,
0,110,0,79,0,
112,0,95,0,100,
0,101,0,99,0,
100,0,54,0,50,
0,54,0,49,0,
51,0,99,0,48,
0,102,0,52,0,
102,0,55,0,102,
0,97,0,102,0,
101,0,51,0,56,
0,53,0,55,0,
54,0,55,0,100,
0,97,0,57,0,
57,0,102,0,98,
0,52,0,95,0,
55,0,97,0,56,
0,51,0,97,0,
57,0,54,0,56,
0,102,0,56,0,
56,0,57,0,52,
0,57,0,57,0,
53,0,98,0,51,
0,102,0,50,0,
101,0,49,0,51,
0,97,0,52,0,
51,0,101,0,56,
0,102,0,57,0,
102,0,48,0,1,
-1,1,5,3268,20,
1655,1,355,1,3,
1,2,1,1,3269,
22,1,77,1,791,
3270,17,3271,15,3272,
4,144,37,0,98,
0,105,0,110,0,
79,0,112,0,95,
0,98,0,98,0,
57,0,99,0,49,
0,55,0,50,0,
57,0,56,0,51,
0,98,0,55,0,
52,0,56,0,98,
0,57,0,56,0,
53,0,55,0,53,
0,53,0,52,0,
51,0,49,0,57,
0,101,0,54,0,
100,0,52,0,48,
0,98,0,98,0,
95,0,55,0,50,
0,102,0,50,0,
49,0,102,0,55,
0,57,0,51,0,
101,0,98,0,49,
0,52,0,53,0,
97,0,55,0,97,
0,100,0,49,0,
56,0,56,0,53,
0,99,0,53,0,
52,0,97,0,53,
0,53,0,53,0,
54,0,56,0,51,
0,1,-1,1,5,
3273,20,1647,1,358,
1,3,1,2,1,
1,3274,22,1,78,
1,1184,3275,16,0,
835,1,638,3276,16,
0,835,1,95,3277,
19,834,1,95,3278,
5,86,1,979,3279,
16,0,832,1,779,
3280,16,0,832,1,
776,3156,1,1168,3281,
16,0,832,1,67,
2327,1,69,2533,1,
1358,3282,16,0,832,
1,76,3283,16,0,
832,1,1159,3284,16,
0,832,1,763,3285,
16,0,832,1,1220,
3286,16,0,832,1,
167,3287,16,0,832,
1,754,3288,16,0,
832,1,1142,3289,16,
0,832,1,1118,3290,
16,0,832,1,63,
3291,16,0,832,1,
774,3172,1,743,3292,
16,0,832,1,1127,
3293,16,0,832,1,
929,3294,16,0,832,
1,727,3295,16,0,
832,1,941,3296,16,
0,832,1,921,3297,
16,0,832,1,718,
3298,16,0,832,1,
1109,3299,16,0,832,
1,121,3300,16,0,
832,1,709,3301,16,
0,832,1,593,3302,
16,0,832,1,1094,
3303,16,0,832,1,
695,3304,16,0,832,
1,103,3305,16,0,
832,1,890,3306,16,
0,832,1,1085,3307,
16,0,832,1,1278,
3308,16,0,832,1,
686,3309,16,0,832,
1,94,3310,16,0,
832,1,1076,3311,16,
0,832,1,877,3312,
16,0,832,1,70,
2499,1,674,3313,16,
0,832,1,868,3314,
16,0,832,1,1261,
3200,1,1260,3205,1,
1259,3210,1,1258,3215,
1,1048,3315,16,0,
832,1,71,2593,1,
661,2597,1,857,3316,
16,0,832,1,68,
2553,1,1446,3317,16,
0,832,1,66,2612,
1,656,2617,1,65,
2341,1,1245,3318,16,
0,832,1,61,3319,
16,0,832,1,647,
3320,16,0,832,1,
1039,3321,16,0,832,
1,1234,3322,16,0,
832,1,835,3323,16,
0,832,1,1425,3324,
16,0,832,1,1030,
3325,16,0,832,1,
828,3231,1,827,3236,
1,629,3326,16,0,
832,1,1017,3327,16,
0,832,1,620,3328,
16,0,832,1,816,
3329,16,0,832,1,
1209,3330,16,0,832,
1,844,3331,16,0,
832,1,790,3247,1,
611,3332,16,0,832,
1,1398,3333,16,0,
832,1,1003,3334,16,
0,832,1,805,3335,
16,0,832,1,15,
2825,1,14,2878,1,
1195,3336,16,0,832,
1,602,3337,16,0,
832,1,1057,3338,16,
0,832,1,794,3339,
16,0,832,1,793,
3260,1,792,3265,1,
791,3270,1,1184,3340,
16,0,832,1,638,
3341,16,0,832,1,
94,3342,19,130,1,
94,3343,5,95,1,
393,2266,1,391,2276,
1,390,2281,1,389,
2322,1,182,2304,1,
181,2309,1,69,2533,
1,965,3344,16,0,
773,1,117,2364,1,
42,2504,1,159,2475,
1,50,2651,1,1332,
2370,1,346,2375,1,
344,2379,1,257,2384,
1,342,2389,1,59,
3345,16,0,850,1,
299,2489,1,401,2394,
1,660,3346,16,0,
380,1,130,2399,1,
129,2404,1,318,2524,
1,120,2637,1,907,
3347,16,0,128,1,
118,2440,1,314,2569,
1,903,3348,16,0,
140,1,114,2449,1,
28,2701,1,112,2457,
1,111,2290,1,306,
2467,1,305,2471,1,
26,3349,16,0,567,
1,300,2485,1,102,
2722,1,298,2494,1,
295,2509,1,294,2514,
1,293,2519,1,292,
2559,1,1670,2435,1,
405,2731,1,286,2538,
1,285,2543,1,284,
2354,1,68,2553,1,
1464,2558,1,8,2564,
1,77,2764,1,467,
2584,1,72,2588,1,
71,2593,1,70,2499,
1,463,2602,1,265,
2606,1,67,2327,1,
66,2612,1,65,2341,
1,64,2770,1,62,
3350,16,0,826,1,
481,2548,1,256,2627,
1,1290,3351,16,0,
623,1,57,3352,16,
0,852,1,55,2641,
1,54,3353,16,0,
857,1,447,2646,1,
969,3354,16,0,863,
1,47,3355,16,0,
864,1,1423,3356,16,
0,532,1,239,2579,
1,38,2676,1,233,
2681,1,35,2666,1,
230,2687,1,229,2688,
1,30,2692,1,226,
2696,1,60,2661,1,
421,2706,1,420,2710,
1,23,2714,1,18,
2718,1,58,2632,1,
12,2726,1,208,2656,
1,206,2735,1,402,
2739,1,204,2740,1,
6,2744,1,5,3357,
16,0,916,1,201,
2749,1,93,3358,19,
136,1,93,3359,5,
52,1,1332,3360,16,
0,895,1,1420,3361,
17,3362,15,3363,4,
158,37,0,118,0,
97,0,108,0,117,
0,101,0,79,0,
114,0,84,0,104,
0,105,0,110,0,
103,0,95,0,98,
0,50,0,57,0,
50,0,101,0,53,
0,101,0,102,0,
102,0,101,0,98,
0,99,0,52,0,
99,0,102,0,48,
0,56,0,102,0,
54,0,56,0,50,
0,50,0,55,0,
100,0,52,0,52,
0,52,0,55,0,
54,0,53,0,100,
0,97,0,95,0,
101,0,51,0,57,
0,52,0,49,0,
48,0,49,0,100,
0,53,0,52,0,
56,0,102,0,52,
0,98,0,49,0,
55,0,57,0,48,
0,98,0,51,0,
97,0,55,0,102,
0,98,0,50,0,
99,0,102,0,102,
0,97,0,97,0,
101,0,99,0,1,
-1,1,5,3364,20,
1960,1,277,1,3,
1,2,1,1,3365,
22,1,22,1,1419,
3366,17,3367,15,3368,
4,158,37,0,118,
0,97,0,108,0,
117,0,101,0,79,
0,114,0,84,0,
104,0,105,0,110,
0,103,0,95,0,
54,0,48,0,54,
0,102,0,57,0,
49,0,53,0,49,
0,53,0,99,0,
57,0,97,0,52,
0,102,0,49,0,
55,0,56,0,101,
0,98,0,100,0,
101,0,50,0,101,
0,57,0,101,0,
49,0,53,0,100,
0,97,0,49,0,
56,0,48,0,95,
0,97,0,48,0,
49,0,57,0,52,
0,53,0,51,0,
49,0,99,0,57,
0,97,0,48,0,
52,0,54,0,55,
0,53,0,56,0,
98,0,48,0,56,
0,54,0,52,0,
98,0,49,0,98,
0,101,0,98,0,
56,0,102,0,49,
0,98,0,48,0,
1,-1,1,5,3369,
20,1952,1,280,1,
3,1,2,1,1,
3370,22,1,23,1,
349,3371,16,0,869,
1,1326,3372,16,0,
919,1,1421,3373,16,
0,534,1,23,3374,
16,0,895,1,967,
3375,16,0,865,1,
520,3376,16,0,895,
1,162,3377,16,0,
869,1,263,3378,16,
0,774,1,1670,3379,
16,0,895,1,509,
3380,16,0,919,1,
1664,3381,16,0,919,
1,327,3382,16,0,
919,1,237,3383,16,
0,774,1,236,2894,
1,235,2899,1,500,
3384,16,0,919,1,
230,3385,16,0,895,
1,318,2524,1,34,
3386,16,0,869,1,
226,3387,16,0,895,
1,314,3388,16,0,
895,1,402,3389,16,
0,895,1,45,3390,
16,0,869,1,400,
2938,1,577,3391,16,
0,869,1,1288,3392,
16,0,625,1,308,
3393,16,0,919,1,
1464,3394,16,0,895,
1,399,2942,1,393,
2266,1,36,3395,16,
0,869,1,658,3396,
16,0,382,1,1458,
3397,16,0,919,1,
211,3398,16,0,774,
1,40,3399,16,0,
869,1,829,3400,16,
0,869,1,524,3401,
16,0,919,1,1271,
3402,16,0,869,1,
201,3403,16,0,895,
1,33,3404,16,0,
774,1,20,3405,16,
0,919,1,905,3406,
16,0,134,1,281,
3407,16,0,895,1,
901,3408,16,0,142,
1,9,3409,16,0,
919,1,963,3410,16,
0,733,1,295,3411,
16,0,895,1,2,
3412,16,0,919,1,
346,3413,16,0,635,
1,92,3414,19,554,
1,92,3415,5,1,
1,1396,3416,16,0,
552,1,91,3417,19,
175,1,91,3418,5,
2,1,593,3419,16,
0,173,1,1358,3420,
16,0,173,1,90,
3421,19,114,1,90,
3422,5,2,1,593,
3423,16,0,112,1,
1358,3424,16,0,112,
1,89,3425,19,286,
1,89,3426,5,1,
1,975,3427,16,0,
284,1,88,3428,19,
307,1,88,3429,5,
13,1,735,3430,16,
0,305,1,71,2593,
1,70,2499,1,69,
2533,1,68,2553,1,
67,2327,1,66,2612,
1,65,2341,1,656,
2617,1,682,3431,16,
0,356,1,661,2597,
1,672,3432,16,0,
361,1,703,3433,16,
0,337,1,87,3434,
19,314,1,87,3435,
5,12,1,67,2327,
1,661,2597,1,694,
3436,16,0,349,1,
726,3437,16,0,312,
1,656,2617,1,672,
3438,16,0,360,1,
66,2612,1,65,2341,
1,71,2593,1,70,
2499,1,69,2533,1,
68,2553,1,86,3439,
19,327,1,86,3440,
5,11,1,67,2327,
1,661,2597,1,66,
2612,1,656,2617,1,
672,3441,16,0,354,
1,717,3442,16,0,
325,1,65,2341,1,
71,2593,1,70,2499,
1,69,2533,1,68,
2553,1,85,3443,19,
336,1,85,3444,5,
10,1,67,2327,1,
661,2597,1,66,2612,
1,656,2617,1,672,
3445,16,0,334,1,
65,2341,1,71,2593,
1,70,2499,1,69,
2533,1,68,2553,1,
84,3446,19,255,1,
84,3447,5,13,1,
1183,3448,16,0,689,
1,71,2593,1,70,
2499,1,69,2533,1,
68,2553,1,67,2327,
1,66,2612,1,65,
2341,1,656,2617,1,
802,3449,17,3450,15,
3451,4,48,37,0,
100,0,97,0,116,
0,97,0,118,0,
97,0,108,0,101,
0,114,0,70,0,
111,0,108,0,108,
0,111,0,119,0,
101,0,100,0,66,
0,121,0,76,0,
105,0,115,0,116,
0,1,-1,1,5,
3452,20,1673,1,347,
1,3,1,4,1,
3,3453,22,1,74,
1,1203,3454,17,3455,
15,3451,1,-1,1,
5,3456,20,1668,1,
348,1,3,1,4,
1,3,3457,22,1,
75,1,661,2597,1,
672,3458,16,0,253,
1,83,3459,19,245,
1,83,3460,5,13,
1,813,3461,17,3462,
15,3463,4,38,37,
0,100,0,97,0,
116,0,97,0,118,
0,97,0,108,0,
101,0,114,0,84,
0,105,0,109,0,
101,0,115,0,76,
0,105,0,115,0,
116,0,1,-1,1,
5,3464,20,1680,1,
345,1,3,1,4,
1,3,3465,22,1,
72,1,71,2593,1,
70,2499,1,69,2533,
1,68,2553,1,67,
2327,1,66,2612,1,
65,2341,1,656,2617,
1,1208,3466,16,0,
662,1,661,2597,1,
1228,3467,17,3468,15,
3463,1,-1,1,5,
3469,20,1675,1,346,
1,3,1,4,1,
3,3470,22,1,73,
1,672,3471,16,0,
243,1,82,3472,19,
400,1,82,3473,5,
11,1,67,2327,1,
661,2597,1,65,2341,
1,656,2617,1,66,
2612,1,637,3474,16,
0,406,1,68,2553,
1,71,2593,1,70,
2499,1,69,2533,1,
646,3475,16,0,398,
1,81,3476,19,264,
1,81,3477,5,14,
1,71,2593,1,70,
2499,1,69,2533,1,
68,2553,1,67,2327,
1,66,2612,1,65,
2341,1,619,3478,16,
0,423,1,1358,3479,
16,0,639,1,610,
3480,16,0,432,1,
661,2597,1,656,2617,
1,672,3481,16,0,
262,1,593,3482,16,
0,639,1,80,3483,
19,261,1,80,3484,
5,12,1,67,2327,
1,1358,3485,16,0,
503,1,66,2612,1,
656,2617,1,672,3486,
16,0,259,1,661,
2597,1,65,2341,1,
593,3487,16,0,503,
1,71,2593,1,70,
2499,1,69,2533,1,
68,2553,1,79,3488,
19,230,1,79,3489,
5,13,1,71,2593,
1,70,2499,1,69,
2533,1,68,2553,1,
67,2327,1,66,2612,
1,65,2341,1,656,
2617,1,661,2597,1,
1233,3490,16,0,648,
1,824,3491,17,3492,
15,3493,4,36,37,
0,100,0,97,0,
116,0,97,0,118,
0,97,0,108,0,
101,0,114,0,80,
0,108,0,117,0,
115,0,76,0,105,
0,115,0,116,0,
1,-1,1,5,3494,
20,1687,1,343,1,
3,1,4,1,3,
3495,22,1,70,1,
1253,3496,17,3497,15,
3493,1,-1,1,5,
3498,20,1682,1,344,
1,3,1,4,1,
3,3499,22,1,71,
1,672,3500,16,0,
228,1,78,3501,19,
209,1,78,3502,5,
10,1,67,2327,1,
661,2597,1,66,2612,
1,656,2617,1,672,
3503,16,0,207,1,
65,2341,1,71,2593,
1,70,2499,1,69,
2533,1,68,2553,1,
77,3504,19,212,1,
77,3505,5,59,1,
824,3491,1,966,3091,
1,709,3506,17,3507,
15,3508,4,22,37,
0,100,0,117,0,
114,0,97,0,116,
0,105,0,111,0,
110,0,95,0,109,
0,1,-1,1,5,
3509,20,1566,1,396,
1,3,1,3,1,
2,3510,22,1,103,
1,65,2341,1,704,
3511,17,3512,15,3508,
1,-1,1,5,3513,
20,1564,1,397,1,
3,1,7,1,6,
3514,22,1,104,1,
970,3086,1,1056,3515,
16,0,276,1,905,
2296,1,1233,3516,16,
0,276,1,876,3517,
16,0,276,1,963,
3064,1,695,3518,17,
3519,15,3508,1,-1,
1,5,3520,20,1562,
1,398,1,3,1,
5,1,4,3521,22,
1,105,1,1228,3467,
1,71,2593,1,69,
2533,1,68,2553,1,
67,2327,1,66,2612,
1,955,3015,1,954,
3078,1,686,3522,17,
3523,15,3508,1,-1,
1,5,3524,20,1560,
1,399,1,3,1,
3,1,2,3525,22,
1,106,1,967,3070,
1,683,3526,17,3527,
15,3508,1,-1,1,
5,3528,20,1558,1,
400,1,3,1,5,
1,4,3529,22,1,
107,1,1126,3530,16,
0,276,1,1016,3531,
16,0,276,1,1117,
3532,16,0,276,1,
674,3533,17,3534,15,
3508,1,-1,1,5,
3535,20,1556,1,401,
1,3,1,3,1,
2,3536,22,1,108,
1,762,3537,16,0,
276,1,672,3538,16,
0,210,1,1203,3454,
1,70,2499,1,978,
3539,16,0,276,1,
661,2597,1,673,3540,
17,3541,15,3508,1,
-1,1,5,3542,20,
1551,1,402,1,3,
1,3,1,2,3543,
22,1,109,1,1002,
3544,16,0,276,1,
656,2617,1,655,3545,
17,3546,15,3547,4,
18,37,0,100,0,
97,0,116,0,101,
0,116,0,105,0,
109,0,101,0,1,
-1,1,5,3548,20,
1549,1,403,1,3,
1,13,1,12,3549,
22,1,110,1,920,
3550,17,3551,15,3552,
4,16,37,0,101,
0,120,0,101,0,
97,0,114,0,103,
0,115,0,1,-1,
1,5,3553,20,1898,
1,301,1,3,1,
2,1,1,3554,22,
1,44,1,919,3555,
17,3556,15,3552,1,
-1,1,5,3557,20,
1896,1,302,1,3,
1,2,1,1,3558,
22,1,45,1,1183,
3559,16,0,276,1,
1093,3560,16,0,276,
1,736,3561,17,3562,
15,3508,1,-1,1,
5,3563,20,1572,1,
393,1,3,1,9,
1,8,3564,22,1,
100,1,913,3565,17,
3566,15,3552,1,-1,
1,5,3567,20,1894,
1,303,1,3,1,
4,1,3,3568,22,
1,46,1,912,3569,
17,3570,15,3552,1,
-1,1,5,3571,20,
1889,1,304,1,3,
1,4,1,3,3572,
22,1,47,1,911,
2417,1,910,2422,1,
909,2427,1,908,2431,
1,727,3573,17,3574,
15,3508,1,-1,1,
5,3575,20,1570,1,
394,1,3,1,7,
1,6,3576,22,1,
101,1,904,2445,1,
813,3461,1,901,2453,
1,1167,3577,16,0,
276,1,1253,3496,1,
718,3578,17,3579,15,
3508,1,-1,1,5,
3580,20,1568,1,395,
1,3,1,5,1,
4,3581,22,1,102,
1,628,3582,17,3583,
15,3547,1,-1,1,
5,3584,20,1544,1,
404,1,3,1,7,
1,6,3585,22,1,
111,1,1208,3586,16,
0,276,1,940,3587,
16,0,276,1,802,
3449,1,76,3588,19,
590,1,76,3589,5,
2,1,593,3590,16,
0,588,1,1358,3591,
16,0,588,1,75,
3592,19,267,1,75,
3593,5,10,1,67,
2327,1,661,2597,1,
66,2612,1,656,2617,
1,672,3594,16,0,
265,1,65,2341,1,
71,2593,1,70,2499,
1,69,2533,1,68,
2553,1,74,3595,19,
642,1,74,3596,5,
2,1,593,3597,16,
0,640,1,1358,3598,
16,0,640,1,73,
3599,19,771,1,73,
3600,5,10,1,67,
2327,1,661,2597,1,
65,2341,1,1084,3601,
16,0,769,1,656,
2617,1,66,2612,1,
71,2593,1,70,2499,
1,69,2533,1,68,
2553,1,72,3602,19,
353,1,72,3603,5,
10,1,67,2327,1,
661,2597,1,65,2341,
1,656,2617,1,1047,
3604,16,0,351,1,
66,2612,1,71,2593,
1,70,2499,1,69,
2533,1,68,2553,1,
71,3605,19,348,1,
71,3606,5,13,1,
71,2593,1,70,2499,
1,69,2533,1,68,
2553,1,67,2327,1,
66,2612,1,65,2341,
1,656,2617,1,1424,
3607,16,0,531,1,
661,2597,1,937,3608,
16,0,902,1,1084,
3609,16,0,758,1,
1038,3610,16,0,346,
1,70,3611,19,778,
1,70,3612,5,2,
1,593,3613,16,0,
776,1,1358,3614,16,
0,776,1,69,3615,
19,258,1,69,3616,
5,10,1,67,2327,
1,661,2597,1,66,
2612,1,656,2617,1,
672,3617,16,0,256,
1,65,2341,1,71,
2593,1,70,2499,1,
69,2533,1,68,2553,
1,68,3618,19,574,
1,68,3619,5,14,
1,955,3015,1,954,
3078,1,911,2417,1,
910,2422,1,909,2427,
1,908,2431,1,905,
2296,1,904,2445,1,
901,2453,1,1270,3620,
16,0,572,1,970,
3086,1,967,3070,1,
966,3091,1,963,3064,
1,67,3621,19,169,
1,67,3622,5,2,
1,1394,3623,16,0,
551,1,867,3624,16,
0,167,1,66,3625,
19,547,1,66,3626,
5,21,1,71,2593,
1,70,2499,1,661,
2597,1,919,3555,1,
67,2327,1,66,2612,
1,65,2341,1,656,
2617,1,913,3565,1,
912,3569,1,911,2417,
1,910,2422,1,909,
2427,1,908,2431,1,
905,2296,1,904,2445,
1,68,2553,1,901,
2453,1,1411,3627,16,
0,545,1,69,2533,
1,920,3550,1,65,
3628,19,414,1,65,
3629,5,10,1,628,
3630,16,0,412,1,
661,2597,1,67,2327,
1,656,2617,1,66,
2612,1,65,2341,1,
71,2593,1,70,2499,
1,69,2533,1,68,
2553,1,64,3631,19,
441,1,64,3632,5,
2,1,593,3633,16,
0,439,1,1358,3634,
16,0,439,1,63,
3635,19,856,1,63,
3636,5,1,1,52,
3637,16,0,854,1,
62,3638,19,472,1,
62,3639,5,1,1,
524,3640,16,0,470,
1,61,3641,19,385,
1,61,3642,5,8,
1,899,3643,16,0,
383,1,1287,3644,16,
0,626,1,657,3645,
16,0,383,1,1418,
3646,16,0,538,1,
975,3647,16,0,383,
1,56,3648,16,0,
853,1,53,3649,16,
0,858,1,52,3650,
16,0,851,1,60,
3651,19,862,1,60,
3652,5,3,1,349,
3653,16,0,860,1,
45,3654,16,0,860,
1,162,3655,16,0,
860,1,59,3656,19,
721,1,59,3657,5,
7,1,33,3658,17,
3659,15,3660,4,150,
37,0,99,0,111,
0,109,0,112,0,
97,0,114,0,101,
0,114,0,95,0,
97,0,48,0,99,
0,48,0,98,0,
98,0,57,0,51,
0,101,0,54,0,
97,0,101,0,52,
0,54,0,57,0,
55,0,57,0,51,
0,51,0,50,0,
49,0,99,0,51,
0,55,0,57,0,
53,0,54,0,97,
0,102,0,56,0,
57,0,55,0,95,
0,48,0,52,0,
98,0,49,0,99,
0,100,0,56,0,
48,0,100,0,57,
0,101,0,99,0,
52,0,100,0,99,
0,57,0,98,0,
50,0,101,0,53,
0,54,0,98,0,
97,0,100,0,52,
0,51,0,51,0,
51,0,99,0,99,
0,53,0,54,0,
1,-1,1,5,3661,
20,1228,1,491,1,
3,1,1,1,0,
3662,22,1,201,1,
234,3663,16,0,719,
1,318,2524,1,197,
3664,17,3665,15,3666,
4,150,37,0,99,
0,111,0,109,0,
112,0,97,0,114,
0,101,0,114,0,
95,0,53,0,101,
0,99,0,98,0,
97,0,97,0,100,
0,48,0,101,0,
51,0,57,0,98,
0,52,0,50,0,
50,0,52,0,57,
0,49,0,102,0,
99,0,57,0,99,
0,57,0,56,0,
55,0,50,0,56,
0,53,0,50,0,
51,0,102,0,99,
0,95,0,98,0,
97,0,54,0,52,
0,53,0,49,0,
57,0,52,0,100,
0,54,0,57,0,
50,0,52,0,98,
0,48,0,48,0,
56,0,55,0,50,
0,50,0,54,0,
51,0,50,0,56,
0,102,0,51,0,
101,0,100,0,50,
0,51,0,53,0,
49,0,1,-1,1,
5,3667,20,1218,1,
494,1,3,1,2,
1,1,3668,22,1,
202,1,211,3669,17,
3659,1,0,3662,1,
346,3670,17,3659,1,
0,3662,1,393,2266,
1,58,3671,19,236,
1,58,3672,5,17,
1,1734,3673,16,0,
333,1,1548,3674,16,
0,411,1,1562,3675,
16,0,403,1,1730,
3676,16,0,238,1,
1578,3677,16,0,779,
1,1540,3678,16,0,
395,1,318,2524,1,
1721,3679,16,0,247,
1,1720,3680,16,0,
234,1,1570,3681,16,
0,393,1,393,2266,
1,1531,3682,16,0,
333,1,1566,3683,16,
0,397,1,1529,3684,
17,3685,15,3686,4,
12,37,0,99,0,
104,0,97,0,105,
0,110,0,1,-1,
1,5,3687,20,1538,
1,406,1,3,1,
5,1,4,3688,22,
1,113,1,1536,3689,
16,0,425,1,1522,
3690,16,0,428,1,
1547,3691,17,3692,15,
3686,1,-1,1,5,
3693,20,1542,1,405,
1,3,1,5,1,
4,3694,22,1,112,
1,57,3695,19,252,
1,57,3696,5,36,
1,1779,2835,1,1415,
2904,1,1504,2855,1,
524,3697,16,0,506,
1,1764,2781,1,1691,
2862,1,1584,2933,1,
1582,2883,1,552,3698,
16,0,486,1,1573,
3699,16,0,732,1,
593,3700,16,0,443,
1,592,2947,1,1570,
3701,16,0,564,1,
1568,2786,1,1744,2808,
1,1564,2796,1,582,
2791,1,1738,2815,1,
1645,2842,1,1732,2829,
1,1550,3702,16,0,
409,1,551,3703,17,
3704,15,3705,4,18,
37,0,97,0,110,
0,100,0,67,0,
111,0,109,0,109,
0,97,0,1,-1,
1,5,488,1,1,
1,1,3706,22,1,
141,1,1619,2888,1,
1723,3707,16,0,735,
1,564,2803,1,1539,
2820,1,1533,3708,16,
0,339,1,1799,2910,
1,1531,3709,16,0,
427,1,1797,2915,1,
550,3710,17,3711,15,
3705,1,-1,1,5,
488,1,1,1,1,
3712,22,1,142,1,
1734,3713,16,0,427,
1,548,3714,16,0,
478,1,0,3715,16,
0,250,1,1514,2847,
1,1780,3716,16,0,
250,1,56,3717,19,
600,1,56,3718,5,
117,1,393,2266,1,
391,2276,1,390,2281,
1,389,2322,1,27,
3719,16,0,598,1,
1739,3143,1,1761,3720,
16,0,598,1,1759,
3090,1,182,2304,1,
181,2309,1,69,2533,
1,1556,3721,16,0,
598,1,117,2364,1,
1551,3722,16,0,598,
1,565,3723,16,0,
598,1,42,2504,1,
532,3096,1,1741,3724,
16,0,598,1,1542,
3725,16,0,598,1,
553,3726,16,0,598,
1,1332,2370,1,346,
2375,1,1724,3727,16,
0,598,1,344,2379,
1,257,2384,1,1524,
3728,16,0,598,1,
534,3729,16,0,598,
1,1715,3730,16,0,
598,1,1517,3731,16,
0,598,1,401,2394,
1,130,2399,1,523,
3104,1,18,2718,1,
520,3109,1,519,3113,
1,518,3118,1,517,
3122,1,318,2524,1,
159,2475,1,299,2489,
1,314,2569,1,508,
3128,1,28,2701,1,
112,2457,1,111,2290,
1,306,2467,1,305,
2471,1,499,3050,1,
300,2485,1,295,2509,
1,298,2494,1,1674,
3732,16,0,598,1,
294,2514,1,293,2519,
1,292,2559,1,1670,
2435,1,286,2538,1,
285,2543,1,284,2354,
1,1464,2558,1,8,
2564,1,6,2744,1,
118,2440,1,68,2553,
1,66,2612,1,239,
2579,1,467,2584,1,
72,2588,1,71,2593,
1,70,2499,1,463,
2602,1,265,2606,1,
67,2327,1,1642,3733,
16,0,598,1,65,
2341,1,114,2449,1,
1639,3734,16,0,598,
1,1637,3023,1,481,
2548,1,256,2627,1,
58,2632,1,120,2637,
1,55,2641,1,447,
2646,1,50,2651,1,
12,2726,1,208,2656,
1,1623,3735,16,0,
598,1,60,2661,1,
342,2389,1,206,2735,
1,38,2676,1,233,
2681,1,35,2666,1,
230,2687,1,229,2688,
1,30,2692,1,226,
2696,1,1604,3736,16,
0,598,1,421,2706,
1,420,2710,1,25,
3737,16,0,598,1,
23,2714,1,29,3738,
16,0,598,1,129,
2404,1,102,2722,1,
15,2825,1,14,2878,
1,1588,3739,16,0,
598,1,405,2731,1,
1586,3030,1,1585,3039,
1,402,2739,1,204,
2740,1,203,3740,16,
0,598,1,201,2749,
1,1,3146,1,55,
3741,19,557,1,55,
3742,5,93,1,393,
2266,1,391,2276,1,
390,2281,1,389,2322,
1,1759,3743,16,0,
756,1,182,2304,1,
181,2309,1,69,2533,
1,117,2364,1,42,
2504,1,1739,3744,16,
0,756,1,159,2475,
1,1332,2370,1,405,
2731,1,344,2379,1,
257,2384,1,342,2389,
1,532,3096,1,401,
2394,1,130,2399,1,
523,3104,1,102,2722,
1,520,3109,1,519,
3113,1,518,3118,1,
517,3122,1,318,2524,
1,120,2637,1,118,
2440,1,314,2569,1,
508,3128,1,1585,3745,
16,0,756,1,111,
2290,1,306,2467,1,
305,2471,1,499,3050,
1,300,2485,1,299,
2489,1,298,2494,1,
70,2499,1,295,2509,
1,294,2514,1,293,
2519,1,292,2559,1,
1670,2435,1,286,2538,
1,285,2543,1,284,
2354,1,1464,2558,1,
8,2564,1,68,2553,
1,467,2584,1,72,
2588,1,71,2593,1,
346,2375,1,463,2602,
1,265,2606,1,67,
2327,1,66,2612,1,
65,2341,1,114,2449,
1,1637,3746,16,0,
756,1,481,2548,1,
256,2627,1,58,2632,
1,112,2457,1,55,
2641,1,447,2646,1,
50,2651,1,60,2661,
1,239,2579,1,38,
2676,1,233,2681,1,
35,2666,1,230,2687,
1,229,2688,1,30,
2692,1,226,2696,1,
28,2701,1,421,2706,
1,420,2710,1,23,
2714,1,18,2718,1,
129,2404,1,1395,3747,
16,0,555,1,12,
2726,1,208,2656,1,
206,2735,1,402,2739,
1,204,2740,1,6,
2744,1,201,2749,1,
1,3146,1,54,3748,
19,678,1,54,3749,
5,5,1,33,3750,
16,0,676,1,318,
2524,1,346,3751,16,
0,676,1,393,2266,
1,211,3752,16,0,
676,1,53,3753,19,
586,1,53,3754,5,
5,1,314,3755,16,
0,654,1,32,3756,
16,0,882,1,1332,
3757,16,0,584,1,
555,3758,16,0,654,
1,1464,3759,16,0,
789,1,52,3760,19,
875,1,52,3761,5,
31,1,265,3762,16,
0,873,1,72,2588,
1,71,2593,1,159,
3763,16,0,873,1,
69,2533,1,68,2553,
1,67,2327,1,66,
2612,1,65,2341,1,
239,3764,16,0,873,
1,60,2661,1,58,
2632,1,55,2641,1,
50,2651,1,47,3765,
16,0,873,1,579,
3766,16,0,873,1,
42,2504,1,130,2399,
1,129,2404,1,38,
3767,16,0,873,1,
35,3768,16,0,873,
1,120,2637,1,831,
3769,16,0,873,1,
118,2440,1,117,2364,
1,1273,3770,16,0,
873,1,114,2449,1,
112,2457,1,111,2290,
1,102,2722,1,70,
2499,1,51,3771,19,
892,1,51,3772,5,
84,1,393,2266,1,
391,2276,1,390,2281,
1,389,2322,1,346,
2375,1,1762,3773,16,
0,890,1,182,2304,
1,181,2309,1,69,
2533,1,117,2364,1,
67,2327,1,42,2504,
1,1742,3774,16,0,
890,1,159,2475,1,
1332,2370,1,405,2731,
1,344,2379,1,257,
2384,1,342,2389,1,
299,2489,1,401,2394,
1,130,2399,1,129,
2404,1,318,2524,1,
120,2637,1,118,2440,
1,314,2569,1,114,
2449,1,112,2457,1,
111,2290,1,306,2467,
1,305,2471,1,26,
3775,16,0,890,1,
300,2485,1,102,2722,
1,298,2494,1,295,
2509,1,294,2514,1,
293,2519,1,292,2559,
1,1670,2435,1,286,
2538,1,285,2543,1,
284,2354,1,1464,2558,
1,8,2564,1,68,
2553,1,467,2584,1,
72,2588,1,71,2593,
1,70,2499,1,463,
2602,1,265,2606,1,
1643,3776,16,0,890,
1,66,2612,1,65,
2341,1,1640,3777,16,
0,890,1,481,2548,
1,256,2627,1,58,
2632,1,55,2641,1,
447,2646,1,50,2651,
1,60,2661,1,239,
2579,1,38,2676,1,
233,2681,1,35,2666,
1,230,2687,1,229,
2688,1,30,2692,1,
226,2696,1,28,2701,
1,421,2706,1,420,
2710,1,23,2714,1,
18,2718,1,12,2726,
1,208,2656,1,206,
2735,1,402,2739,1,
204,3778,16,0,890,
1,6,2744,1,201,
2749,1,50,3779,19,
879,1,50,3780,5,
94,1,393,2266,1,
391,2276,1,390,2281,
1,389,2322,1,579,
3781,16,0,877,1,
182,2304,1,181,2309,
1,69,2533,1,1687,
3782,16,0,906,1,
42,2504,1,16,3783,
16,0,906,1,159,
3784,16,0,877,1,
1332,2370,1,405,2731,
1,344,2379,1,257,
2384,1,342,2389,1,
230,2687,1,401,2394,
1,130,2399,1,129,
2404,1,318,2524,1,
120,2637,1,118,2440,
1,117,2364,1,114,
2449,1,28,2701,1,
112,2457,1,111,2290,
1,306,2467,1,305,
2471,1,300,2485,1,
299,2489,1,298,2494,
1,70,2499,1,295,
2509,1,294,2514,1,
293,2519,1,292,2559,
1,1670,2435,1,1273,
3785,16,0,877,1,
286,2538,1,285,2543,
1,284,2354,1,68,
2553,1,1464,2558,1,
8,2564,1,314,2569,
1,77,2764,1,75,
3786,16,0,906,1,
467,2584,1,72,2588,
1,71,2593,1,346,
2375,1,463,2602,1,
265,3787,16,0,877,
1,67,2327,1,66,
2612,1,65,2341,1,
64,2770,1,62,3788,
16,0,906,1,1636,
2622,1,256,2627,1,
58,2632,1,55,2641,
1,447,2646,1,50,
2651,1,47,3789,16,
0,877,1,1620,3790,
16,0,906,1,831,
3791,16,0,877,1,
239,3792,16,0,877,
1,1617,2672,1,38,
2676,1,233,2681,1,
35,3793,16,0,877,
1,481,2548,1,229,
2688,1,30,2692,1,
226,2696,1,60,2661,
1,421,2706,1,420,
2710,1,1601,3794,16,
0,906,1,23,2714,
1,18,2718,1,102,
2722,1,12,3795,16,
0,906,1,208,2656,
1,206,2735,1,402,
2739,1,204,2740,1,
6,2744,1,5,3796,
16,0,906,1,201,
2749,1,49,3797,19,
151,1,49,3798,5,
144,1,1291,3799,17,
3800,15,3801,4,48,
37,0,99,0,111,
0,110,0,100,0,
105,0,116,0,105,
0,111,0,110,0,
95,0,100,0,97,
0,116,0,97,0,
95,0,112,0,114,
0,111,0,112,0,
101,0,114,0,116,
0,121,0,1,-1,
1,5,3802,20,1925,
1,291,1,3,1,
9,1,8,3803,22,
1,34,1,118,2440,
1,421,2706,1,420,
2710,1,1273,3804,17,
3805,15,3806,4,60,
37,0,99,0,111,
0,110,0,100,0,
105,0,116,0,105,
0,111,0,110,0,
95,0,100,0,97,
0,116,0,97,0,
95,0,112,0,114,
0,111,0,112,0,
101,0,114,0,116,
0,121,0,95,0,
98,0,111,0,117,
0,110,0,100,0,
1,-1,1,5,3807,
20,1923,1,292,1,
3,1,4,1,3,
3808,22,1,35,1,
1269,3809,17,3810,15,
3811,4,36,37,0,
99,0,111,0,110,
0,100,0,105,0,
116,0,105,0,111,
0,110,0,95,0,
98,0,117,0,105,
0,108,0,116,0,
105,0,110,0,1,
-1,1,5,3812,20,
1916,1,294,1,3,
1,2,1,1,3813,
22,1,37,1,405,
2731,1,402,2739,1,
401,2394,1,831,3814,
17,3815,15,3816,4,
42,37,0,99,0,
111,0,110,0,100,
0,105,0,116,0,
105,0,111,0,110,
0,95,0,100,0,
97,0,116,0,97,
0,95,0,98,0,
111,0,117,0,110,
0,100,0,1,-1,
1,5,3817,20,1921,
1,293,1,3,1,
4,1,3,3818,22,
1,36,1,885,3819,
17,3820,15,3821,4,
24,37,0,98,0,
117,0,105,0,108,
0,116,0,105,0,
110,0,95,0,101,
0,120,0,101,0,
1,-1,1,5,3822,
20,1574,1,392,1,
3,1,7,1,6,
3823,22,1,99,1,
393,2266,1,391,2276,
1,390,2281,1,389,
2322,1,1242,3824,17,
3825,15,3826,4,26,
37,0,98,0,117,
0,105,0,108,0,
116,0,105,0,110,
0,95,0,108,0,
105,0,115,0,116,
0,1,-1,1,5,
3827,20,1606,1,377,
1,3,1,4,1,
3,3828,22,1,85,
1,1670,2435,1,1496,
3829,16,0,466,1,
12,2726,1,787,3830,
17,3831,15,3832,4,
24,37,0,98,0,
117,0,105,0,108,
0,116,0,105,0,
110,0,95,0,99,
0,109,0,112,0,
1,-1,1,5,3833,
20,1608,1,376,1,
3,1,4,1,3,
3834,22,1,84,1,
1217,3835,17,3836,15,
3826,1,-1,1,5,
3837,20,1604,1,378,
1,3,1,4,1,
3,3838,22,1,86,
1,346,2375,1,344,
2379,1,661,2597,1,
771,3839,17,3840,15,
3841,4,24,37,0,
98,0,117,0,105,
0,108,0,116,0,
105,0,110,0,95,
0,98,0,105,0,
110,0,1,-1,1,
5,3842,20,1600,1,
380,1,3,1,6,
1,5,3843,22,1,
88,1,1192,3844,17,
3845,15,3826,1,-1,
1,5,3846,20,1602,
1,379,1,3,1,
4,1,3,3847,22,
1,87,1,751,3848,
17,3849,15,3850,4,
38,37,0,98,0,
117,0,105,0,108,
0,116,0,105,0,
110,0,95,0,117,
0,110,0,97,0,
114,0,121,0,95,
0,102,0,114,0,
101,0,101,0,1,
-1,1,5,3851,20,
1596,1,382,1,3,
1,4,1,3,3852,
22,1,90,1,318,
2524,1,314,2569,1,
901,2453,1,159,2475,
1,306,2467,1,305,
2471,1,300,2485,1,
299,2489,1,298,2494,
1,295,2509,1,294,
2514,1,293,2519,1,
292,2559,1,1150,3853,
17,3854,15,3855,4,
30,37,0,98,0,
117,0,105,0,108,
0,116,0,105,0,
110,0,95,0,115,
0,117,0,98,0,
115,0,116,0,114,
0,1,-1,1,5,
3856,20,1594,1,383,
1,3,1,7,1,
6,3857,22,1,91,
1,286,2538,1,285,
2543,1,284,2354,1,
1135,3858,17,3859,15,
3855,1,-1,1,5,
3860,20,1592,1,384,
1,3,1,9,1,
8,3861,22,1,92,
1,265,2606,1,257,
2384,1,256,2627,1,
1102,3862,17,3863,15,
3855,1,-1,1,5,
3864,20,1590,1,385,
1,3,1,7,1,
6,3865,22,1,93,
1,239,2579,1,233,
2681,1,230,2687,1,
229,2688,1,226,2696,
1,656,2617,1,1516,
3866,17,3867,15,3868,
4,14,37,0,99,
0,108,0,97,0,
117,0,115,0,101,
0,1,-1,1,5,
3869,20,1950,1,281,
1,3,1,2,1,
1,3870,22,1,24,
1,1512,3871,16,0,
466,1,1505,2408,1,
1503,2413,1,208,2656,
1,206,3872,16,0,
888,1,204,2740,1,
1065,3873,17,3874,15,
3875,4,28,37,0,
98,0,117,0,105,
0,108,0,116,0,
105,0,110,0,95,
0,116,0,114,0,
97,0,110,0,115,
0,1,-1,1,5,
3876,20,1588,1,386,
1,3,1,9,1,
8,3877,22,1,94,
1,1495,2285,1,201,
2749,1,1489,2463,1,
1483,2480,1,904,2445,
1,182,2304,1,181,
2309,1,1473,2528,1,
1464,2558,1,1457,2570,
1,1025,3878,17,3879,
15,3880,4,34,37,
0,98,0,117,0,
105,0,108,0,116,
0,105,0,110,0,
95,0,100,0,117,
0,114,0,97,0,
116,0,105,0,111,
0,110,0,1,-1,
1,5,3881,20,1586,
1,387,1,3,1,
4,1,3,3882,22,
1,95,1,1456,2574,
1,1011,3883,17,3884,
15,3885,4,34,37,
0,98,0,117,0,
105,0,108,0,116,
0,105,0,110,0,
95,0,100,0,97,
0,116,0,101,0,
116,0,105,0,109,
0,101,0,1,-1,
1,5,3886,20,1583,
1,389,1,3,1,
4,1,3,3887,22,
1,96,1,912,3569,
1,573,2313,1,572,
2318,1,563,2332,1,
562,2336,1,130,2399,
1,129,2404,1,1325,
3888,17,3889,15,3890,
4,26,37,0,99,
0,111,0,110,0,
100,0,105,0,116,
0,105,0,111,0,
110,0,95,0,105,
0,115,0,1,-1,
1,5,3891,20,1929,
1,289,1,3,1,
4,1,3,3892,22,
1,32,1,987,3893,
17,3894,15,3895,4,
28,37,0,98,0,
117,0,105,0,108,
0,116,0,105,0,
110,0,95,0,97,
0,108,0,112,0,
104,0,97,0,1,
-1,1,5,3896,20,
1581,1,390,1,3,
1,6,1,5,3897,
22,1,97,1,120,
2637,1,1411,3898,16,
0,149,1,117,2364,
1,114,2449,1,112,
2457,1,111,2290,1,
970,3086,1,967,3070,
1,966,3091,1,102,
2722,1,963,3064,1,
1393,3899,17,3900,15,
3868,1,-1,1,5,
3901,20,1946,1,282,
1,3,1,4,1,
3,3902,22,1,25,
1,920,3550,1,549,
3903,16,0,490,1,
955,3015,1,954,3078,
1,949,3904,17,3905,
15,3906,4,28,37,
0,98,0,117,0,
105,0,108,0,116,
0,105,0,110,0,
95,0,97,0,110,
0,110,0,111,0,
116,0,1,-1,1,
5,3907,20,1579,1,
391,1,3,1,8,
1,7,3908,22,1,
98,1,1176,3909,17,
3910,15,3911,4,36,
37,0,98,0,117,
0,105,0,108,0,
116,0,105,0,110,
0,95,0,117,0,
110,0,97,0,114,
0,121,0,95,0,
99,0,109,0,112,
0,1,-1,1,5,
3912,20,1598,1,381,
1,3,1,5,1,
4,3913,22,1,89,
1,72,2588,1,71,
2593,1,70,2499,1,
69,2533,1,68,2553,
1,67,2327,1,66,
2612,1,65,2341,1,
1357,3914,16,0,568,
1,1356,3915,17,3916,
15,3917,4,34,37,
0,99,0,111,0,
110,0,100,0,105,
0,116,0,105,0,
111,0,110,0,95,
0,101,0,120,0,
105,0,115,0,116,
0,115,0,1,-1,
1,5,3918,20,1933,
1,287,1,3,1,
3,1,2,3919,22,
1,30,1,1355,3920,
17,3921,15,3922,4,
42,37,0,99,0,
111,0,110,0,100,
0,105,0,116,0,
105,0,111,0,110,
0,95,0,100,0,
101,0,102,0,105,
0,110,0,105,0,
116,0,105,0,111,
0,110,0,1,-1,
1,5,3923,20,1931,
1,288,1,3,1,
4,1,3,3924,22,
1,31,1,60,2661,
1,58,2632,1,919,
3555,1,55,2641,1,
342,2389,1,1345,3925,
17,3926,15,3927,4,
30,37,0,99,0,
111,0,110,0,100,
0,105,0,116,0,
105,0,111,0,110,
0,95,0,114,0,
111,0,108,0,101,
0,1,-1,1,5,
3928,20,1935,1,286,
1,3,1,6,1,
5,3929,22,1,29,
1,913,3565,1,50,
2651,1,911,2417,1,
910,2422,1,909,2427,
1,908,2431,1,905,
2296,1,42,2504,1,
481,2548,1,1332,2370,
1,38,2676,1,467,
2584,1,35,2666,1,
463,2602,1,30,2692,
1,28,3930,16,0,
888,1,23,2714,1,
1315,3931,17,3932,15,
3890,1,-1,1,5,
3933,20,1927,1,290,
1,3,1,4,1,
3,3934,22,1,33,
1,18,2718,1,447,
2646,1,876,3935,16,
0,149,1,1305,3936,
17,3937,15,3927,1,
-1,1,5,3938,20,
1937,1,285,1,3,
1,4,1,3,3939,
22,1,28,1,8,
2564,1,6,2744,1,
48,3940,19,645,1,
48,3941,5,24,1,
1664,3942,16,0,647,
1,34,3943,16,0,
881,1,162,3944,16,
0,881,1,400,2938,
1,399,2942,1,1358,
3945,16,0,643,1,
235,2899,1,211,3946,
16,0,881,1,393,
2266,1,318,2524,1,
40,3947,16,0,881,
1,45,3948,16,0,
881,1,349,3949,16,
0,881,1,829,3950,
16,0,881,1,236,
2894,1,1271,3951,16,
0,881,1,308,3952,
16,0,647,1,33,
3953,16,0,881,1,
237,3954,16,0,881,
1,577,3955,16,0,
881,1,263,3956,16,
0,881,1,346,3957,
16,0,881,1,593,
3958,16,0,643,1,
36,3959,16,0,881,
1,47,3960,19,703,
1,47,3961,5,30,
1,976,3962,16,0,
701,1,263,3963,16,
0,701,1,1326,3964,
16,0,701,1,346,
3965,16,0,701,1,
1316,3966,16,0,701,
1,509,3967,16,0,
701,1,1664,3968,16,
0,701,1,237,3969,
16,0,701,1,327,
3970,16,0,701,1,
593,3971,16,0,701,
1,236,2894,1,235,
2899,1,500,3972,16,
0,701,1,1306,3973,
16,0,701,1,318,
2524,1,938,3974,16,
0,701,1,400,2938,
1,399,2942,1,308,
3975,16,0,701,1,
393,2266,1,1458,3976,
16,0,701,1,211,
3977,16,0,701,1,
524,3978,16,0,701,
1,1271,3979,16,0,
701,1,1358,3980,16,
0,701,1,33,3981,
16,0,701,1,20,
3982,16,0,701,1,
9,3983,16,0,701,
1,2,3984,16,0,
701,1,1336,3985,16,
0,701,1,46,3986,
19,206,1,46,3987,
5,172,1,978,3988,
16,0,275,1,1715,
3989,16,0,597,1,
421,2706,1,420,2710,
1,42,2504,1,1117,
3990,16,0,275,1,
1332,2370,1,1270,3991,
16,0,591,1,405,
2731,1,402,2739,1,
401,2394,1,824,3491,
1,1253,3496,1,1551,
3992,16,0,597,1,
389,2322,1,813,3461,
1,1674,3993,16,0,
597,1,1670,2435,1,
802,3449,1,292,2559,
1,1228,3467,1,1517,
3994,16,0,597,1,
1167,3995,16,0,275,
1,1642,3996,16,0,
597,1,1208,3997,16,
0,275,1,1637,3023,
1,342,2389,1,1203,
3454,1,1639,3998,16,
0,597,1,762,3999,
16,0,275,1,1623,
4000,16,0,597,1,
58,2632,1,391,2276,
1,1183,4001,16,0,
275,1,318,2524,1,
18,2718,1,314,2569,
1,1604,4002,16,0,
597,1,1761,4003,16,
0,597,1,306,2467,
1,305,2471,1,300,
2485,1,299,2489,1,
298,2494,1,727,3573,
1,1588,4004,16,0,
597,1,294,2514,1,
1586,3030,1,1585,3039,
1,23,2714,1,718,
3578,1,286,2538,1,
285,2543,1,284,2354,
1,709,3506,1,704,
3511,1,265,2606,1,
695,3518,1,1556,4005,
16,0,597,1,15,
2825,1,50,2651,1,
344,2379,1,257,2384,
1,256,2627,1,686,
3522,1,683,3526,1,
736,3561,1,1542,4006,
16,0,597,1,674,
3533,1,673,3540,1,
672,4007,16,0,204,
1,239,2579,1,233,
2681,1,1524,4008,16,
0,597,1,230,2687,
1,229,2688,1,226,
2696,1,656,2617,1,
655,3545,1,390,2281,
1,293,2519,1,208,
2656,1,206,2735,1,
204,2740,1,203,4009,
16,0,597,1,201,
2749,1,628,3582,1,
1056,4010,16,0,275,
1,963,3064,1,182,
2304,1,181,2309,1,
1464,2558,1,159,2475,
1,1016,4011,16,0,
275,1,346,2375,1,
1440,4012,16,0,502,
1,575,4013,16,0,
468,1,912,3569,1,
1002,4014,16,0,275,
1,14,2878,1,565,
4015,16,0,597,1,
35,2666,1,130,2399,
1,129,2404,1,954,
3078,1,553,4016,16,
0,597,1,120,2637,
1,118,2440,1,117,
2364,1,295,2509,1,
1093,4017,16,0,275,
1,112,2457,1,111,
2290,1,970,3086,1,
967,3070,1,966,3091,
1,534,4018,16,0,
597,1,102,2722,1,
532,3096,1,393,2266,
1,955,3015,1,523,
3104,1,520,3109,1,
519,3113,1,518,3118,
1,517,3122,1,940,
4019,16,0,275,1,
508,3128,1,72,2588,
1,71,2593,1,70,
2499,1,69,2533,1,
499,3050,1,67,2327,
1,66,2612,1,65,
2341,1,60,2661,1,
920,3550,1,919,3555,
1,68,2553,1,55,
2641,1,913,3565,1,
481,2548,1,911,2417,
1,910,2422,1,909,
2427,1,908,2431,1,
905,2296,1,904,2445,
1,1126,4020,16,0,
275,1,901,2453,1,
38,2676,1,1233,4021,
16,0,275,1,467,
2584,1,1759,3090,1,
463,2602,1,30,2692,
1,29,4022,16,0,
597,1,28,2701,1,
27,4023,16,0,597,
1,25,4024,16,0,
597,1,661,2597,1,
114,2449,1,1741,4025,
16,0,597,1,447,
2646,1,1739,3143,1,
876,4026,16,0,275,
1,12,2726,1,8,
2564,1,6,2744,1,
1,3146,1,1724,4027,
16,0,597,1,45,
4028,19,418,1,45,
4029,5,20,1,295,
4030,16,0,746,1,
402,4031,16,0,746,
1,281,4032,16,0,
746,1,24,4033,16,
0,894,1,1541,4034,
16,0,416,1,393,
2266,1,318,2524,1,
1464,4035,16,0,746,
1,314,4036,16,0,
746,1,349,4037,16,
0,894,1,533,4038,
16,0,505,1,346,
4039,16,0,746,1,
201,4040,16,0,746,
1,23,4041,16,0,
746,1,230,4042,16,
0,746,1,1523,4043,
16,0,434,1,1670,
4044,16,0,746,1,
226,4045,16,0,746,
1,520,4046,16,0,
746,1,1332,4047,16,
0,746,1,44,4048,
19,898,1,44,4049,
5,22,1,1664,4050,
16,0,896,1,33,
4051,16,0,896,1,
1326,4052,16,0,896,
1,400,2938,1,399,
2942,1,509,4053,16,
0,896,1,211,4054,
16,0,896,1,235,
2899,1,393,2266,1,
318,2524,1,20,4055,
16,0,896,1,500,
4056,16,0,896,1,
1458,4057,16,0,896,
1,236,2894,1,346,
4058,16,0,896,1,
308,4059,16,0,896,
1,2,4060,16,0,
896,1,327,4061,16,
0,896,1,237,4062,
16,0,896,1,524,
4063,16,0,896,1,
263,4064,16,0,896,
1,9,4065,16,0,
896,1,43,4066,19,
145,1,43,4067,5,
31,1,263,4068,16,
0,730,1,262,3045,
1,1418,4069,16,0,
319,1,1326,4070,16,
0,730,1,524,4071,
16,0,730,1,252,
4072,16,0,747,1,
962,4073,16,0,870,
1,959,4074,16,0,
143,1,1668,4075,16,
0,747,1,509,4076,
16,0,730,1,1664,
4077,16,0,730,1,
327,4078,16,0,730,
1,237,4079,16,0,
730,1,236,2894,1,
235,2899,1,500,4080,
16,0,730,1,318,
2524,1,400,2938,1,
399,2942,1,308,4081,
16,0,730,1,9,
4082,16,0,730,1,
393,2266,1,1458,4083,
16,0,730,1,211,
4084,16,0,730,1,
200,4085,16,0,747,
1,20,4086,16,0,
730,1,33,4087,16,
0,730,1,899,4088,
16,0,143,1,2,
4089,16,0,730,1,
346,4090,16,0,730,
1,975,4091,16,0,
143,1,42,4092,19,
675,1,42,4093,5,
5,1,33,4094,16,
0,673,1,318,2524,
1,346,4095,16,0,
673,1,393,2266,1,
211,4096,16,0,673,
1,41,4097,19,421,
1,41,4098,5,45,
1,1779,2835,1,263,
4099,16,0,688,1,
1415,2904,1,1547,3691,
1,211,4100,16,0,
669,1,1504,2855,1,
346,4101,16,0,669,
1,1764,2781,1,1540,
4102,16,0,419,1,
1584,2933,1,1326,4103,
16,0,669,1,1582,
2883,1,1539,2820,1,
1664,4104,16,0,669,
1,327,4105,16,0,
669,1,592,2947,1,
1568,2786,1,1744,2808,
1,1564,2796,1,393,
2266,1,582,2791,1,
1738,2815,1,318,2524,
1,400,2938,1,1645,
2842,1,576,4106,16,
0,467,1,308,4107,
16,0,669,1,1691,
2862,1,571,4108,16,
0,474,1,570,4109,
16,0,473,1,1458,
4110,16,0,669,1,
1619,2888,1,564,2803,
1,1732,2829,1,399,
2942,1,561,4111,16,
0,481,1,560,4112,
16,0,480,1,33,
4113,16,0,669,1,
1799,2910,1,1797,2915,
1,1529,3684,1,1522,
4114,16,0,435,1,
0,4115,16,0,815,
1,1514,2847,1,1780,
4116,16,0,815,1,
40,4117,19,666,1,
40,4118,5,35,1,
1779,2835,1,1415,2904,
1,1326,4119,16,0,
664,1,346,4120,16,
0,664,1,1764,2781,
1,1691,2862,1,1584,
2933,1,1582,2883,1,
211,4121,16,0,664,
1,1664,4122,16,0,
664,1,327,4123,16,
0,664,1,592,2947,
1,1568,2786,1,1744,
2808,1,1564,2796,1,
318,2524,1,582,2791,
1,1738,2815,1,400,
2938,1,1645,2842,1,
308,4124,16,0,664,
1,399,2942,1,393,
2266,1,1458,4125,16,
0,664,1,1619,2888,
1,564,2803,1,1732,
2829,1,1539,2820,1,
33,4126,16,0,664,
1,1799,2910,1,1797,
2915,1,1504,2855,1,
0,4127,16,0,923,
1,1514,2847,1,1780,
4128,16,0,923,1,
39,4129,19,521,1,
39,4130,5,23,1,
1619,2888,1,1514,2847,
1,1415,2904,1,1584,
2933,1,1582,2883,1,
582,2791,1,1691,2862,
1,1764,2781,1,1504,
2855,1,1799,2910,1,
1539,2820,1,1797,2915,
1,1645,2842,1,1568,
2786,1,1732,2829,1,
1564,2796,1,564,2803,
1,1744,2808,1,1780,
4131,16,0,519,1,
1779,2835,1,1738,2815,
1,0,4132,16,0,
519,1,592,2947,1,
38,4133,19,922,1,
38,4134,5,23,1,
1619,2888,1,1514,2847,
1,1415,2904,1,1584,
2933,1,1582,2883,1,
582,2791,1,1691,2862,
1,1764,2781,1,1504,
2855,1,1799,2910,1,
1539,2820,1,1797,2915,
1,1645,2842,1,1568,
2786,1,1732,2829,1,
1564,2796,1,564,2803,
1,1744,2808,1,1780,
4135,16,0,920,1,
1779,2835,1,1738,2815,
1,0,4136,16,0,
920,1,592,2947,1,
37,4137,19,513,1,
37,4138,5,24,1,
1619,2888,1,1514,2847,
1,1415,2904,1,1584,
2933,1,1398,4139,16,
0,518,1,1582,2883,
1,582,2791,1,1691,
2862,1,1764,2781,1,
1504,2855,1,1799,2910,
1,1539,2820,1,1797,
2915,1,1645,2842,1,
1568,2786,1,1732,2829,
1,1564,2796,1,564,
2803,1,1744,2808,1,
1780,4140,16,0,511,
1,1779,2835,1,1738,
2815,1,0,4141,16,
0,511,1,592,2947,
1,36,4142,19,560,
1,36,4143,5,1,
1,1394,4144,16,0,
558,1,35,4145,19,
111,1,35,4146,5,
126,1,393,2266,1,
391,2276,1,390,2281,
1,389,2322,1,1176,
3909,1,1569,4147,16,
0,394,1,292,2559,
1,1315,3931,1,182,
2304,1,181,2309,1,
771,3839,1,69,2533,
1,966,3091,1,1357,
4148,16,0,561,1,
1356,3915,1,1355,3920,
1,1549,4149,16,0,
410,1,42,2504,1,
949,3904,1,954,3078,
1,1150,3853,1,1345,
3925,1,967,3070,1,
1291,3799,1,751,3848,
1,159,2475,1,284,
2354,1,117,2364,1,
1530,4150,16,0,109,
1,1135,3858,1,346,
2375,1,344,2379,1,
257,2384,1,342,2389,
1,1325,3888,1,1516,
3866,1,401,2394,1,
130,2399,1,129,2404,
1,18,2718,1,885,
3819,1,911,2417,1,
910,2422,1,909,2427,
1,908,2431,1,118,
2440,1,905,2296,1,
904,2445,1,114,2449,
1,901,2453,1,112,
2457,1,111,2290,1,
306,2467,1,305,2471,
1,787,3830,1,300,
2485,1,299,2489,1,
298,2494,1,70,2499,
1,295,2509,1,294,
2514,1,293,2519,1,
318,2524,1,1670,2435,
1,970,3086,1,1273,
3804,1,286,2538,1,
285,2543,1,1269,3809,
1,1464,2558,1,8,
2564,1,1065,3873,1,
314,2569,1,68,2553,
1,963,3064,1,467,
2584,1,72,2588,1,
71,2593,1,661,2597,
1,463,2602,1,265,
2606,1,67,2327,1,
66,2612,1,656,2617,
1,65,2341,1,1242,
3824,1,481,2548,1,
256,2627,1,58,2632,
1,120,2637,1,55,
2641,1,447,2646,1,
35,2666,1,50,2651,
1,208,2656,1,60,
2661,1,831,3814,1,
239,2579,1,1025,3878,
1,1102,3862,1,38,
2676,1,233,2681,1,
1217,3835,1,230,2687,
1,229,2688,1,1332,
2370,1,226,2696,1,
28,2701,1,421,2706,
1,420,2710,1,23,
2714,1,1011,3883,1,
1305,3936,1,955,3015,
1,102,2722,1,30,
2692,1,1393,3899,1,
12,2726,1,405,2731,
1,1192,3844,1,206,
2735,1,402,2739,1,
204,2740,1,6,2744,
1,201,2749,1,987,
3893,1,34,4151,19,
450,1,34,4152,5,
23,1,1619,2888,1,
1514,2847,1,1415,2904,
1,1584,2933,1,1582,
2883,1,582,2791,1,
1691,2862,1,1764,2781,
1,1504,2855,1,1799,
2910,1,1539,2820,1,
1797,2915,1,1645,2842,
1,1568,2786,1,1732,
2829,1,1564,2796,1,
564,2803,1,1744,2808,
1,1780,4153,16,0,
448,1,1779,2835,1,
1738,2815,1,0,4154,
16,0,448,1,592,
2947,1,33,4155,19,
620,1,33,4156,5,
15,1,1440,4157,16,
0,780,1,955,3015,
1,954,3078,1,911,
2417,1,910,2422,1,
909,2427,1,908,2431,
1,905,2296,1,904,
2445,1,901,2453,1,
1270,4158,16,0,618,
1,970,3086,1,967,
3070,1,966,3091,1,
963,3064,1,32,4159,
19,311,1,32,4160,
5,15,1,1440,4161,
16,0,622,1,955,
3015,1,954,3078,1,
911,2417,1,910,2422,
1,909,2427,1,908,
2431,1,905,2296,1,
904,2445,1,901,2453,
1,1270,4162,16,0,
309,1,970,3086,1,
967,3070,1,966,3091,
1,963,3064,1,31,
4163,19,613,1,31,
4164,5,108,1,393,
2266,1,391,2276,1,
390,2281,1,389,2322,
1,27,4165,16,0,
611,1,1761,4166,16,
0,611,1,1759,3090,
1,182,2304,1,181,
2309,1,69,2533,1,
117,2364,1,42,2504,
1,1741,4167,16,0,
611,1,1739,3143,1,
1585,3039,1,1332,2370,
1,346,2375,1,344,
2379,1,257,2384,1,
342,2389,1,534,4168,
16,0,611,1,532,
3096,1,401,2394,1,
130,2399,1,523,3104,
1,18,2718,1,520,
3109,1,519,3113,1,
518,3118,1,517,3122,
1,318,2524,1,159,
2475,1,299,2489,1,
314,2569,1,508,3128,
1,28,2701,1,112,
2457,1,111,2290,1,
306,2467,1,305,2471,
1,499,3050,1,300,
2485,1,295,2509,1,
298,2494,1,1674,4169,
16,0,611,1,294,
2514,1,293,2519,1,
292,2559,1,1670,2435,
1,286,2538,1,285,
2543,1,284,2354,1,
1464,2558,1,8,2564,
1,6,2744,1,118,
2440,1,68,2553,1,
66,2612,1,467,2584,
1,72,2588,1,71,
2593,1,70,2499,1,
463,2602,1,265,2606,
1,67,2327,1,1642,
4170,16,0,611,1,
65,2341,1,114,2449,
1,1639,4171,16,0,
611,1,1637,3023,1,
481,2548,1,256,2627,
1,58,2632,1,120,
2637,1,55,2641,1,
447,2646,1,50,2651,
1,12,2726,1,208,
2656,1,1623,4172,16,
0,611,1,60,2661,
1,239,2579,1,38,
2676,1,233,2681,1,
35,2666,1,230,2687,
1,229,2688,1,30,
2692,1,226,2696,1,
1604,4173,16,0,611,
1,421,2706,1,420,
2710,1,25,4174,16,
0,611,1,23,2714,
1,29,4175,16,0,
611,1,129,2404,1,
102,2722,1,15,2825,
1,14,2878,1,1588,
4176,16,0,611,1,
405,2731,1,1586,3030,
1,206,2735,1,402,
2739,1,204,2740,1,
203,4177,16,0,611,
1,201,2749,1,1,
3146,1,30,4178,19,
610,1,30,4179,5,
108,1,393,2266,1,
391,2276,1,390,2281,
1,389,2322,1,27,
4180,16,0,608,1,
1761,4181,16,0,608,
1,1759,3090,1,182,
2304,1,181,2309,1,
69,2533,1,117,2364,
1,42,2504,1,1741,
4182,16,0,608,1,
1739,3143,1,1585,3039,
1,1332,2370,1,346,
2375,1,344,2379,1,
257,2384,1,342,2389,
1,534,4183,16,0,
608,1,532,3096,1,
401,2394,1,130,2399,
1,523,3104,1,18,
2718,1,520,3109,1,
519,3113,1,518,3118,
1,517,3122,1,318,
2524,1,159,2475,1,
299,2489,1,314,2569,
1,508,3128,1,28,
2701,1,112,2457,1,
111,2290,1,306,2467,
1,305,2471,1,499,
3050,1,300,2485,1,
295,2509,1,298,2494,
1,1674,4184,16,0,
608,1,294,2514,1,
293,2519,1,292,2559,
1,1670,2435,1,286,
2538,1,285,2543,1,
284,2354,1,1464,2558,
1,8,2564,1,6,
2744,1,118,2440,1,
68,2553,1,66,2612,
1,467,2584,1,72,
2588,1,71,2593,1,
70,2499,1,463,2602,
1,265,2606,1,67,
2327,1,1642,4185,16,
0,608,1,65,2341,
1,114,2449,1,1639,
4186,16,0,608,1,
1637,3023,1,481,2548,
1,256,2627,1,58,
2632,1,120,2637,1,
55,2641,1,447,2646,
1,50,2651,1,12,
2726,1,208,2656,1,
1623,4187,16,0,608,
1,60,2661,1,239,
2579,1,38,2676,1,
233,2681,1,35,2666,
1,230,2687,1,229,
2688,1,30,2692,1,
226,2696,1,1604,4188,
16,0,608,1,421,
2706,1,420,2710,1,
25,4189,16,0,608,
1,23,2714,1,29,
4190,16,0,608,1,
129,2404,1,102,2722,
1,15,2825,1,14,
2878,1,1588,4191,16,
0,608,1,405,2731,
1,1586,3030,1,206,
2735,1,402,2739,1,
204,2740,1,203,4192,
16,0,608,1,201,
2749,1,1,3146,1,
29,4193,19,607,1,
29,4194,5,108,1,
393,2266,1,391,2276,
1,390,2281,1,389,
2322,1,27,4195,16,
0,605,1,1761,4196,
16,0,605,1,1759,
3090,1,182,2304,1,
181,2309,1,69,2533,
1,117,2364,1,42,
2504,1,1741,4197,16,
0,605,1,1739,3143,
1,1585,3039,1,1332,
2370,1,346,2375,1,
344,2379,1,257,2384,
1,342,2389,1,534,
4198,16,0,605,1,
532,3096,1,401,2394,
1,130,2399,1,523,
3104,1,18,2718,1,
520,3109,1,519,3113,
1,518,3118,1,517,
3122,1,318,2524,1,
159,2475,1,299,2489,
1,314,2569,1,508,
3128,1,28,2701,1,
112,2457,1,111,2290,
1,306,2467,1,305,
2471,1,499,3050,1,
300,2485,1,295,2509,
1,298,2494,1,1674,
4199,16,0,605,1,
294,2514,1,293,2519,
1,292,2559,1,1670,
2435,1,286,2538,1,
285,2543,1,284,2354,
1,1464,2558,1,8,
2564,1,6,2744,1,
118,2440,1,68,2553,
1,66,2612,1,467,
2584,1,72,2588,1,
71,2593,1,70,2499,
1,463,2602,1,265,
2606,1,67,2327,1,
1642,4200,16,0,605,
1,65,2341,1,114,
2449,1,1639,4201,16,
0,605,1,1637,3023,
1,481,2548,1,256,
2627,1,58,2632,1,
120,2637,1,55,2641,
1,447,2646,1,50,
2651,1,12,2726,1,
208,2656,1,1623,4202,
16,0,605,1,60,
2661,1,239,2579,1,
38,2676,1,233,2681,
1,35,2666,1,230,
2687,1,229,2688,1,
30,2692,1,226,2696,
1,1604,4203,16,0,
605,1,421,2706,1,
420,2710,1,25,4204,
16,0,605,1,23,
2714,1,29,4205,16,
0,605,1,129,2404,
1,102,2722,1,15,
2825,1,14,2878,1,
1588,4206,16,0,605,
1,405,2731,1,1586,
3030,1,206,2735,1,
402,2739,1,204,2740,
1,203,4207,16,0,
605,1,201,2749,1,
1,3146,1,28,4208,
19,604,1,28,4209,
5,108,1,393,2266,
1,391,2276,1,390,
2281,1,389,2322,1,
27,4210,16,0,602,
1,1761,4211,16,0,
602,1,1759,3090,1,
182,2304,1,181,2309,
1,69,2533,1,117,
2364,1,42,2504,1,
1741,4212,16,0,602,
1,1739,3143,1,1585,
3039,1,1332,2370,1,
346,2375,1,344,2379,
1,257,2384,1,342,
2389,1,534,4213,16,
0,602,1,532,3096,
1,401,2394,1,130,
2399,1,523,3104,1,
18,2718,1,520,3109,
1,519,3113,1,518,
3118,1,517,3122,1,
318,2524,1,159,2475,
1,299,2489,1,314,
2569,1,508,3128,1,
28,2701,1,112,2457,
1,111,2290,1,306,
2467,1,305,2471,1,
499,3050,1,300,2485,
1,295,2509,1,298,
2494,1,1674,4214,16,
0,602,1,294,2514,
1,293,2519,1,292,
2559,1,1670,2435,1,
286,2538,1,285,2543,
1,284,2354,1,1464,
2558,1,8,2564,1,
6,2744,1,118,2440,
1,68,2553,1,66,
2612,1,467,2584,1,
72,2588,1,71,2593,
1,70,2499,1,463,
2602,1,265,2606,1,
67,2327,1,1642,4215,
16,0,602,1,65,
2341,1,114,2449,1,
1639,4216,16,0,602,
1,1637,3023,1,481,
2548,1,256,2627,1,
58,2632,1,120,2637,
1,55,2641,1,447,
2646,1,50,2651,1,
12,2726,1,208,2656,
1,1623,4217,16,0,
602,1,60,2661,1,
239,2579,1,38,2676,
1,233,2681,1,35,
2666,1,230,2687,1,
229,2688,1,30,2692,
1,226,2696,1,1604,
4218,16,0,602,1,
421,2706,1,420,2710,
1,25,4219,16,0,
602,1,23,2714,1,
29,4220,16,0,602,
1,129,2404,1,102,
2722,1,15,2825,1,
14,2878,1,1588,4221,
16,0,602,1,405,
2731,1,1586,3030,1,
206,2735,1,402,2739,
1,204,2740,1,203,
4222,16,0,602,1,
201,2749,1,1,3146,
1,27,4223,19,370,
1,27,4224,5,111,
1,393,2266,1,391,
2276,1,390,2281,1,
389,2322,1,23,2714,
1,27,4225,16,0,
601,1,1761,4226,16,
0,601,1,1759,3090,
1,182,2304,1,181,
2309,1,69,2533,1,
117,2364,1,1551,4227,
16,0,706,1,42,
2504,1,1741,4228,16,
0,601,1,1739,3143,
1,159,2475,1,1332,
2370,1,346,2375,1,
344,2379,1,257,2384,
1,342,2389,1,534,
4229,16,0,601,1,
532,3096,1,401,2394,
1,130,2399,1,523,
3104,1,18,2718,1,
520,3109,1,519,3113,
1,518,3118,1,517,
3122,1,318,2524,1,
129,2404,1,299,2489,
1,314,2569,1,508,
3128,1,28,2701,1,
112,2457,1,111,2290,
1,306,2467,1,305,
2471,1,499,3050,1,
1571,4230,16,0,392,
1,295,2509,1,298,
2494,1,1674,4231,16,
0,601,1,294,2514,
1,293,2519,1,292,
2559,1,1670,2435,1,
286,2538,1,285,2543,
1,284,2354,1,1464,
2558,1,8,2564,1,
6,2744,1,118,2440,
1,68,2553,1,66,
2612,1,467,2584,1,
72,2588,1,71,2593,
1,70,2499,1,463,
2602,1,265,2606,1,
67,2327,1,1642,4232,
16,0,601,1,65,
2341,1,114,2449,1,
1639,4233,16,0,601,
1,1637,3023,1,481,
2548,1,256,2627,1,
58,2632,1,120,2637,
1,55,2641,1,447,
2646,1,50,2651,1,
12,2726,1,208,2656,
1,1623,4234,16,0,
601,1,60,2661,1,
239,2579,1,206,2735,
1,38,2676,1,233,
2681,1,35,2666,1,
230,2687,1,229,2688,
1,30,2692,1,226,
2696,1,1604,4235,16,
0,601,1,421,2706,
1,420,2710,1,25,
4236,16,0,601,1,
300,2485,1,29,4237,
16,0,601,1,102,
2722,1,15,2825,1,
14,2878,1,1588,4238,
16,0,601,1,405,
2731,1,1586,3030,1,
1585,3039,1,402,2739,
1,204,2740,1,203,
4239,16,0,601,1,
201,2749,1,1,3146,
1,1576,4240,16,0,
368,1,26,4241,19,
344,1,26,4242,5,
82,1,393,2266,1,
391,2276,1,390,2281,
1,389,2322,1,346,
2375,1,182,2304,1,
181,2309,1,69,2533,
1,117,2364,1,42,
2504,1,159,2475,1,
1332,2370,1,405,2731,
1,344,2379,1,257,
2384,1,342,2389,1,
230,2687,1,299,2489,
1,401,2394,1,130,
2399,1,129,2404,1,
318,2524,1,120,2637,
1,118,2440,1,314,
2569,1,114,2449,1,
112,2457,1,111,2290,
1,306,2467,1,305,
2471,1,300,2485,1,
102,2722,1,298,2494,
1,295,2509,1,294,
2514,1,293,2519,1,
292,2559,1,1670,2435,
1,286,2538,1,285,
2543,1,284,2354,1,
1464,2558,1,8,2564,
1,68,2553,1,467,
2584,1,72,2588,1,
71,2593,1,70,2499,
1,463,2602,1,265,
2606,1,67,2327,1,
66,2612,1,65,2341,
1,1636,2622,1,256,
2627,1,58,2632,1,
55,2641,1,447,2646,
1,50,2651,1,60,
2661,1,239,2579,1,
1617,2672,1,38,2676,
1,233,2681,1,35,
2666,1,481,2548,1,
229,2688,1,30,2692,
1,226,2696,1,28,
2701,1,421,2706,1,
420,2710,1,1601,4243,
16,0,342,1,23,
2714,1,18,2718,1,
12,2726,1,208,2656,
1,206,2735,1,402,
2739,1,204,2740,1,
6,2744,1,201,2749,
1,25,4244,19,373,
1,25,4245,5,23,
1,1619,2888,1,1514,
2847,1,1415,2904,1,
1584,2933,1,1582,2883,
1,582,2791,1,1691,
2862,1,1764,2781,1,
1504,2855,1,1799,2910,
1,1539,2820,1,1797,
2915,1,1645,2842,1,
1568,2786,1,1732,2829,
1,1564,2796,1,564,
2803,1,1744,2808,1,
1780,4246,16,0,371,
1,1779,2835,1,1738,
2815,1,0,4247,16,
0,371,1,592,2947,
1,24,4248,19,651,
1,24,4249,5,1,
1,1670,4250,16,0,
649,1,23,4251,19,
322,1,23,4252,5,
80,1,393,2266,1,
391,2276,1,390,2281,
1,389,2322,1,346,
2375,1,182,2304,1,
181,2309,1,69,2533,
1,265,2606,1,117,
2364,1,42,2504,1,
159,2475,1,1332,2370,
1,405,2731,1,344,
2379,1,257,2384,1,
342,2389,1,299,2489,
1,401,2394,1,130,
2399,1,129,2404,1,
318,2524,1,120,2637,
1,118,2440,1,314,
2569,1,114,2449,1,
112,2457,1,111,2290,
1,306,2467,1,305,
2471,1,300,2485,1,
102,2722,1,298,2494,
1,295,2509,1,294,
2514,1,293,2519,1,
292,2559,1,1670,2435,
1,286,2538,1,285,
2543,1,284,2354,1,
1464,2558,1,8,2564,
1,467,2584,1,72,
2588,1,71,2593,1,
70,2499,1,463,2602,
1,68,2553,1,67,
2327,1,66,2612,1,
65,2341,1,1640,4253,
16,0,320,1,481,
2548,1,256,2627,1,
58,2632,1,55,2641,
1,447,2646,1,50,
2651,1,60,2661,1,
239,2579,1,38,2676,
1,233,2681,1,35,
2666,1,230,2687,1,
229,2688,1,30,2692,
1,226,2696,1,28,
2701,1,421,2706,1,
420,2710,1,23,2714,
1,18,2718,1,12,
2726,1,208,2656,1,
206,2735,1,402,2739,
1,204,2740,1,6,
2744,1,201,2749,1,
22,4254,19,233,1,
22,4255,5,2,1,
1733,4256,16,0,231,
1,1722,4257,16,0,
246,1,21,4258,19,
499,1,21,4259,5,
80,1,393,2266,1,
391,2276,1,390,2281,
1,389,2322,1,346,
2375,1,182,2304,1,
181,2309,1,69,2533,
1,265,2606,1,117,
2364,1,42,2504,1,
159,2475,1,547,4260,
16,0,497,1,1332,
2370,1,405,2731,1,
344,2379,1,257,2384,
1,342,2389,1,299,
2489,1,401,2394,1,
130,2399,1,129,2404,
1,318,2524,1,120,
2637,1,118,2440,1,
314,2569,1,114,2449,
1,112,2457,1,111,
2290,1,306,2467,1,
305,2471,1,300,2485,
1,102,2722,1,298,
2494,1,295,2509,1,
294,2514,1,293,2519,
1,292,2559,1,1670,
2435,1,286,2538,1,
285,2543,1,284,2354,
1,1464,2558,1,8,
2564,1,467,2584,1,
72,2588,1,71,2593,
1,70,2499,1,463,
2602,1,68,2553,1,
67,2327,1,66,2612,
1,65,2341,1,481,
2548,1,256,2627,1,
58,2632,1,55,2641,
1,447,2646,1,50,
2651,1,60,2661,1,
239,2579,1,38,2676,
1,233,2681,1,35,
2666,1,230,2687,1,
229,2688,1,30,2692,
1,226,2696,1,28,
2701,1,421,2706,1,
420,2710,1,23,2714,
1,18,2718,1,12,
2726,1,208,2656,1,
206,2735,1,402,2739,
1,204,2740,1,6,
2744,1,201,2749,1,
20,4261,19,700,1,
20,4262,5,5,1,
33,4263,16,0,698,
1,318,2524,1,346,
4264,16,0,698,1,
393,2266,1,211,4265,
16,0,698,1,19,
4266,19,148,1,19,
4267,5,138,1,393,
2266,1,67,2327,1,
979,4268,16,0,386,
1,1764,2781,1,1568,
2786,1,582,2791,1,
71,2593,1,1003,4269,
16,0,386,1,1564,
2796,1,774,3172,1,
1468,4270,16,0,528,
1,1118,4271,16,0,
386,1,976,4272,16,
0,528,1,1159,4273,
16,0,386,1,1245,
4274,16,0,386,1,
763,4275,16,0,386,
1,1220,4276,16,0,
386,1,564,2803,1,
1744,2808,1,167,4277,
16,0,901,1,938,
4278,16,0,528,1,
754,4279,16,0,386,
1,1738,2815,1,776,
3156,1,1539,2820,1,
1261,3200,1,1142,4280,
16,0,386,1,1732,
2829,1,1336,4281,16,
0,528,1,941,4282,
16,0,386,1,743,
4283,16,0,386,1,
1779,2835,1,346,4284,
16,0,901,1,1435,
4285,16,0,528,1,
11,4286,16,0,901,
1,1326,4287,16,0,
901,1,14,2878,1,
1127,4288,16,0,386,
1,929,4289,16,0,
386,1,1506,4290,16,
0,528,1,727,4291,
16,0,386,1,1514,
2847,1,1316,4292,16,
0,528,1,921,4293,
16,0,386,1,327,
4294,16,0,901,1,
718,4295,16,0,386,
1,1504,2855,1,1306,
4296,16,0,528,1,
318,2524,1,17,4297,
16,0,901,1,1497,
4298,16,0,528,1,
857,4299,17,4300,15,
4301,4,152,37,0,
99,0,111,0,109,
0,112,0,97,0,
114,0,101,0,114,
0,50,0,95,0,
50,0,49,0,52,
0,52,0,48,0,
54,0,100,0,55,
0,51,0,48,0,
101,0,55,0,52,
0,53,0,100,0,
102,0,57,0,102,
0,55,0,51,0,
52,0,101,0,49,
0,48,0,57,0,
50,0,57,0,48,
0,97,0,100,0,
55,0,55,0,95,
0,100,0,99,0,
51,0,51,0,53,
0,57,0,54,0,
52,0,48,0,100,
0,100,0,48,0,
52,0,100,0,98,
0,49,0,57,0,
48,0,98,0,102,
0,53,0,51,0,
97,0,98,0,98,
0,54,0,54,0,
102,0,100,0,101,
0,57,0,97,0,
1,-1,1,5,4302,
20,1731,1,329,1,
3,1,3,1,2,
4303,22,1,65,1,
1691,2862,1,1490,4304,
16,0,528,1,1094,
4305,16,0,386,1,
638,4306,16,0,386,
1,1484,4307,16,0,
528,1,695,4308,16,
0,386,1,890,4309,
16,0,146,1,1085,
4310,16,0,386,1,
1278,4311,16,0,627,
1,686,4312,16,0,
386,1,1358,4313,16,
0,660,1,1076,4314,
16,0,386,1,877,
4315,16,0,386,1,
1664,4316,16,0,901,
1,1168,4317,16,0,
386,1,70,2499,1,
236,2894,1,674,4318,
16,0,386,1,66,
2612,1,868,4319,16,
0,146,1,1458,4320,
16,0,901,1,1260,
3205,1,1259,3210,1,
1258,3215,1,779,4321,
16,0,386,1,1057,
4322,16,0,386,1,
1271,4323,16,0,528,
1,661,2597,1,1645,
2842,1,68,2553,1,
1446,4324,16,0,386,
1,263,4325,16,0,
901,1,656,2617,1,
65,2341,1,1048,4326,
16,0,386,1,1441,
4327,16,0,528,1,
709,4328,16,0,386,
1,235,2899,1,1584,
2933,1,647,4329,16,
0,386,1,308,4330,
16,0,901,1,1039,
4331,16,0,386,1,
15,2825,1,1234,4332,
16,0,386,1,69,
2533,1,7,4333,16,
0,901,1,399,2942,
1,835,4334,17,4335,
15,4336,4,152,37,
0,99,0,111,0,
109,0,112,0,97,
0,114,0,101,0,
114,0,50,0,95,
0,101,0,100,0,
98,0,51,0,100,
0,48,0,48,0,
53,0,56,0,48,
0,56,0,97,0,
52,0,50,0,49,
0,52,0,57,0,
56,0,49,0,48,
0,49,0,56,0,
53,0,57,0,53,
0,50,0,50,0,
48,0,56,0,102,
0,99,0,53,0,
95,0,56,0,101,
0,51,0,99,0,
52,0,54,0,52,
0,98,0,51,0,
99,0,49,0,100,
0,52,0,102,0,
100,0,56,0,98,
0,97,0,49,0,
101,0,54,0,57,
0,53,0,49,0,
102,0,49,0,53,
0,99,0,55,0,
97,0,57,0,101,
0,1,-1,1,5,
4337,20,1737,1,326,
1,3,1,3,1,
2,4338,22,1,64,
1,1425,4339,16,0,
386,1,1030,4340,16,
0,386,1,1619,2888,
1,828,3231,1,827,
3236,1,629,4341,16,
0,386,1,794,4342,
16,0,386,1,1415,
2904,1,33,4343,16,
0,901,1,593,4344,
16,0,660,1,1017,
4345,16,0,386,1,
400,2938,1,4,4346,
16,0,901,1,620,
4347,16,0,386,1,
816,4348,16,0,386,
1,1209,4349,16,0,
386,1,1799,2910,1,
237,4350,16,0,901,
1,1797,2915,1,790,
3247,1,611,4351,16,
0,386,1,1398,4352,
16,0,146,1,1397,
2920,1,805,4353,16,
0,386,1,1394,2926,
1,211,4354,16,0,
901,1,1195,4355,16,
0,386,1,1109,4356,
16,0,386,1,602,
4357,16,0,386,1,
844,4358,17,4359,15,
4360,4,152,37,0,
99,0,111,0,109,
0,112,0,97,0,
114,0,101,0,114,
0,50,0,95,0,
98,0,48,0,102,
0,101,0,54,0,
55,0,54,0,101,
0,57,0,55,0,
55,0,51,0,52,
0,102,0,49,0,
98,0,97,0,53,
0,53,0,101,0,
97,0,55,0,50,
0,51,0,49,0,
102,0,51,0,53,
0,98,0,56,0,
98,0,99,0,95,
0,52,0,56,0,
102,0,54,0,52,
0,98,0,49,0,
99,0,101,0,51,
0,48,0,50,0,
52,0,101,0,97,
0,52,0,97,0,
56,0,55,0,98,
0,55,0,100,0,
48,0,97,0,52,
0,97,0,48,0,
55,0,97,0,52,
0,102,0,54,0,
1,-1,1,5,4361,
20,1743,1,323,1,
3,1,3,1,2,
4362,22,1,63,1,
1780,4363,16,0,529,
1,1582,2883,1,793,
3260,1,792,3265,1,
791,3270,1,1184,4364,
16,0,386,1,592,
2947,1,0,4365,16,
0,529,1,18,4366,
19,541,1,18,4367,
5,46,1,1779,2835,
1,263,4368,16,0,
913,1,1415,2904,1,
1326,4369,16,0,913,
1,346,4370,16,0,
913,1,167,4371,16,
0,913,1,1764,2781,
1,1691,2862,1,1584,
2933,1,1582,2883,1,
211,4372,16,0,913,
1,17,4373,16,0,
913,1,1664,4374,16,
0,913,1,327,4375,
16,0,913,1,237,
4376,16,0,913,1,
592,2947,1,235,2899,
1,1568,2786,1,1744,
2808,1,1564,2796,1,
318,2524,1,582,2791,
1,1738,2815,1,236,
2894,1,400,2938,1,
1645,2842,1,308,4377,
16,0,913,1,399,
2942,1,393,2266,1,
1458,4378,16,0,913,
1,1619,2888,1,564,
2803,1,1732,2829,1,
1539,2820,1,33,4379,
16,0,913,1,1799,
2910,1,1797,2915,1,
15,2825,1,14,2878,
1,11,4380,16,0,
913,1,1504,2855,1,
7,4381,16,0,913,
1,4,4382,16,0,
913,1,0,4383,16,
0,539,1,1514,2847,
1,1780,4384,16,0,
539,1,17,4385,19,
751,1,17,4386,5,
29,1,263,4387,16,
0,798,1,349,4388,
16,0,798,1,346,
4389,16,0,798,1,
162,4390,16,0,798,
1,71,2593,1,70,
2499,1,69,2533,1,
68,2553,1,67,2327,
1,66,2612,1,65,
2341,1,237,4391,16,
0,798,1,236,2894,
1,235,2899,1,318,
2524,1,1117,4392,16,
0,749,1,45,4393,
16,0,798,1,577,
4394,16,0,798,1,
40,4395,16,0,798,
1,661,2597,1,393,
2266,1,36,4396,16,
0,798,1,34,4397,
16,0,798,1,211,
4398,16,0,798,1,
829,4399,16,0,798,
1,1271,4400,16,0,
798,1,113,4401,16,
0,798,1,33,4402,
16,0,798,1,656,
2617,1,16,4403,19,
794,1,16,4404,5,
19,1,36,4405,16,
0,792,1,34,4406,
16,0,792,1,162,
4407,16,0,792,1,
211,4408,16,0,792,
1,235,2899,1,393,
2266,1,318,2524,1,
45,4409,16,0,792,
1,349,4410,16,0,
792,1,237,4411,16,
0,792,1,236,2894,
1,1271,4412,16,0,
792,1,40,4413,16,
0,792,1,33,4414,
16,0,792,1,829,
4415,16,0,792,1,
263,4416,16,0,792,
1,346,4417,16,0,
792,1,113,4418,16,
0,792,1,577,4419,
16,0,792,1,15,
4420,19,200,1,15,
4421,5,18,1,36,
4422,16,0,814,1,
34,4423,16,0,814,
1,162,4424,16,0,
814,1,211,4425,16,
0,814,1,235,2899,
1,393,2266,1,318,
2524,1,45,4426,16,
0,814,1,349,4427,
16,0,814,1,237,
4428,16,0,814,1,
236,2894,1,1271,4429,
16,0,814,1,40,
4430,16,0,814,1,
33,4431,16,0,814,
1,829,4432,16,0,
198,1,263,4433,16,
0,814,1,346,4434,
16,0,814,1,577,
4435,16,0,814,1,
14,4436,19,190,1,
14,4437,5,27,1,
263,4438,16,0,807,
1,349,4439,16,0,
807,1,346,4440,16,
0,807,1,162,4441,
16,0,807,1,36,
4442,16,0,807,1,
775,4443,16,0,274,
1,237,4444,16,0,
807,1,236,2894,1,
235,2899,1,1565,4445,
16,0,692,1,318,
2524,1,1561,4446,16,
0,404,1,45,4447,
16,0,807,1,577,
4448,16,0,807,1,
40,4449,16,0,807,
1,1729,4450,16,0,
239,1,393,2266,1,
570,4451,16,0,475,
1,34,4452,16,0,
807,1,211,4453,16,
0,807,1,1720,4454,
16,0,191,1,829,
4455,16,0,188,1,
1540,4456,16,0,684,
1,560,4457,16,0,
482,1,1271,4458,16,
0,628,1,33,4459,
16,0,807,1,1441,
4460,16,0,510,1,
13,4461,19,184,1,
13,4462,5,20,1,
36,4463,16,0,790,
1,34,4464,16,0,
790,1,162,4465,16,
0,790,1,115,4466,
16,0,797,1,211,
4467,16,0,790,1,
235,2899,1,393,2266,
1,318,2524,1,45,
4468,16,0,790,1,
349,4469,16,0,790,
1,237,4470,16,0,
790,1,236,2894,1,
1271,4471,16,0,790,
1,40,4472,16,0,
790,1,33,4473,16,
0,790,1,829,4474,
16,0,182,1,263,
4475,16,0,790,1,
346,4476,16,0,790,
1,113,4477,16,0,
790,1,577,4478,16,
0,790,1,12,4479,
19,366,1,12,4480,
5,32,1,263,4481,
16,0,911,1,349,
4482,16,0,768,1,
1326,4483,16,0,911,
1,524,4484,16,0,
911,1,1587,4485,16,
0,364,1,1586,3030,
1,1585,3039,1,1759,
3090,1,162,4486,16,
0,768,1,509,4487,
16,0,911,1,1664,
4488,16,0,911,1,
327,4489,16,0,911,
1,237,4490,16,0,
911,1,236,2894,1,
235,2899,1,500,4491,
16,0,911,1,318,
2524,1,1739,3143,1,
45,4492,16,0,849,
1,400,2938,1,399,
2942,1,308,4493,16,
0,911,1,393,2266,
1,1637,3023,1,1458,
4494,16,0,911,1,
211,4495,16,0,911,
1,33,4496,16,0,
911,1,20,4497,16,
0,911,1,9,4498,
16,0,911,1,3,
4499,16,0,918,1,
2,4500,16,0,911,
1,346,4501,16,0,
911,1,11,4502,19,
755,1,11,4503,5,
5,1,33,4504,16,
0,753,1,318,2524,
1,346,4505,16,0,
753,1,393,2266,1,
211,4506,16,0,753,
1,10,4507,19,181,
1,10,4508,5,23,
1,1619,2888,1,1514,
2847,1,1415,2904,1,
1584,2933,1,1582,2883,
1,582,2791,1,1691,
2862,1,1764,2781,1,
1504,2855,1,1799,2910,
1,1539,2820,1,1797,
2915,1,1645,2842,1,
1568,2786,1,1732,2829,
1,1564,2796,1,564,
2803,1,1744,2808,1,
1780,4509,16,0,179,
1,1779,2835,1,1738,
2815,1,0,4510,16,
0,179,1,592,2947,
1,9,4511,19,454,
1,9,4512,5,23,
1,1619,2888,1,1514,
2847,1,1415,2904,1,
1584,2933,1,1582,2883,
1,582,2791,1,1691,
2862,1,1764,2781,1,
1504,2855,1,1799,2910,
1,1539,2820,1,1797,
2915,1,1645,2842,1,
1568,2786,1,1732,2829,
1,1564,2796,1,564,
2803,1,1744,2808,1,
1780,4513,16,0,452,
1,1779,2835,1,1738,
2815,1,0,4514,16,
0,452,1,592,2947,
1,8,4515,19,843,
1,8,4516,5,86,
1,979,4517,16,0,
841,1,779,4518,16,
0,841,1,776,3156,
1,1168,4519,16,0,
841,1,67,2327,1,
69,2533,1,1358,4520,
16,0,841,1,76,
4521,16,0,841,1,
1159,4522,16,0,841,
1,763,4523,16,0,
841,1,1220,4524,16,
0,841,1,167,4525,
16,0,841,1,754,
4526,16,0,841,1,
1142,4527,16,0,841,
1,1118,4528,16,0,
841,1,63,4529,16,
0,841,1,774,3172,
1,743,4530,16,0,
841,1,1127,4531,16,
0,841,1,929,4532,
16,0,841,1,727,
4533,16,0,841,1,
941,4534,16,0,841,
1,921,4535,16,0,
841,1,718,4536,16,
0,841,1,1109,4537,
16,0,841,1,121,
4538,16,0,841,1,
709,4539,16,0,841,
1,593,4540,16,0,
841,1,1094,4541,16,
0,841,1,695,4542,
16,0,841,1,103,
4543,16,0,841,1,
890,4544,16,0,841,
1,1085,4545,16,0,
841,1,1278,4546,16,
0,841,1,686,4547,
16,0,841,1,94,
4548,16,0,841,1,
1076,4549,16,0,841,
1,877,4550,16,0,
841,1,70,2499,1,
674,4551,16,0,841,
1,868,4552,16,0,
841,1,1261,3200,1,
1260,3205,1,1259,3210,
1,1258,3215,1,1048,
4553,16,0,841,1,
71,2593,1,661,2597,
1,857,4554,16,0,
841,1,68,2553,1,
1446,4555,16,0,841,
1,66,2612,1,656,
2617,1,65,2341,1,
1245,4556,16,0,841,
1,61,4557,16,0,
841,1,647,4558,16,
0,841,1,1039,4559,
16,0,841,1,1234,
4560,16,0,841,1,
835,4561,16,0,841,
1,1425,4562,16,0,
841,1,1030,4563,16,
0,841,1,828,3231,
1,827,3236,1,629,
4564,16,0,841,1,
1017,4565,16,0,841,
1,620,4566,16,0,
841,1,816,4567,16,
0,841,1,1209,4568,
16,0,841,1,844,
4569,16,0,841,1,
790,3247,1,611,4570,
16,0,841,1,1398,
4571,16,0,841,1,
1003,4572,16,0,841,
1,805,4573,16,0,
841,1,15,2825,1,
14,2878,1,1195,4574,
16,0,841,1,602,
4575,16,0,841,1,
1057,4576,16,0,841,
1,794,4577,16,0,
841,1,793,3260,1,
792,3265,1,791,3270,
1,1184,4578,16,0,
841,1,638,4579,16,
0,841,1,7,4580,
19,840,1,7,4581,
5,86,1,979,4582,
16,0,838,1,779,
4583,16,0,838,1,
776,3156,1,1168,4584,
16,0,838,1,67,
2327,1,69,2533,1,
1358,4585,16,0,838,
1,76,4586,16,0,
838,1,1159,4587,16,
0,838,1,763,4588,
16,0,838,1,1220,
4589,16,0,838,1,
167,4590,16,0,838,
1,754,4591,16,0,
838,1,1142,4592,16,
0,838,1,1118,4593,
16,0,838,1,63,
4594,16,0,838,1,
774,3172,1,743,4595,
16,0,838,1,1127,
4596,16,0,838,1,
929,4597,16,0,838,
1,727,4598,16,0,
838,1,941,4599,16,
0,838,1,921,4600,
16,0,838,1,718,
4601,16,0,838,1,
1109,4602,16,0,838,
1,121,4603,16,0,
838,1,709,4604,16,
0,838,1,593,4605,
16,0,838,1,1094,
4606,16,0,838,1,
695,4607,16,0,838,
1,103,4608,16,0,
838,1,890,4609,16,
0,838,1,1085,4610,
16,0,838,1,1278,
4611,16,0,838,1,
686,4612,16,0,838,
1,94,4613,16,0,
838,1,1076,4614,16,
0,838,1,877,4615,
16,0,838,1,70,
2499,1,674,4616,16,
0,838,1,868,4617,
16,0,838,1,1261,
3200,1,1260,3205,1,
1259,3210,1,1258,3215,
1,1048,4618,16,0,
838,1,71,2593,1,
661,2597,1,857,4619,
16,0,838,1,68,
2553,1,1446,4620,16,
0,838,1,66,2612,
1,656,2617,1,65,
2341,1,1245,4621,16,
0,838,1,61,4622,
16,0,838,1,647,
4623,16,0,838,1,
1039,4624,16,0,838,
1,1234,4625,16,0,
838,1,835,4626,16,
0,838,1,1425,4627,
16,0,838,1,1030,
4628,16,0,838,1,
828,3231,1,827,3236,
1,629,4629,16,0,
838,1,1017,4630,16,
0,838,1,620,4631,
16,0,838,1,816,
4632,16,0,838,1,
1209,4633,16,0,838,
1,844,4634,16,0,
838,1,790,3247,1,
611,4635,16,0,838,
1,1398,4636,16,0,
838,1,1003,4637,16,
0,838,1,805,4638,
16,0,838,1,15,
2825,1,14,2878,1,
1195,4639,16,0,838,
1,602,4640,16,0,
838,1,1057,4641,16,
0,838,1,794,4642,
16,0,838,1,793,
3260,1,792,3265,1,
791,3270,1,1184,4643,
16,0,838,1,638,
4644,16,0,838,1,
6,4645,19,830,1,
6,4646,5,86,1,
979,4647,16,0,828,
1,779,4648,16,0,
828,1,776,3156,1,
1168,4649,16,0,828,
1,67,2327,1,69,
2533,1,1358,4650,16,
0,828,1,76,4651,
16,0,828,1,1159,
4652,16,0,828,1,
763,4653,16,0,828,
1,1220,4654,16,0,
828,1,167,4655,16,
0,828,1,754,4656,
16,0,828,1,1142,
4657,16,0,828,1,
1118,4658,16,0,828,
1,63,4659,16,0,
828,1,774,3172,1,
743,4660,16,0,828,
1,1127,4661,16,0,
828,1,929,4662,16,
0,828,1,727,4663,
16,0,828,1,941,
4664,16,0,828,1,
921,4665,16,0,828,
1,718,4666,16,0,
828,1,1109,4667,16,
0,828,1,121,4668,
16,0,828,1,709,
4669,16,0,828,1,
593,4670,16,0,828,
1,1094,4671,16,0,
828,1,695,4672,16,
0,828,1,103,4673,
16,0,828,1,890,
4674,16,0,828,1,
1085,4675,16,0,828,
1,1278,4676,16,0,
828,1,686,4677,16,
0,828,1,94,4678,
16,0,828,1,1076,
4679,16,0,828,1,
877,4680,16,0,828,
1,70,2499,1,674,
4681,16,0,828,1,
868,4682,16,0,828,
1,1261,3200,1,1260,
3205,1,1259,3210,1,
1258,3215,1,1048,4683,
16,0,828,1,71,
2593,1,661,2597,1,
857,4684,16,0,828,
1,68,2553,1,1446,
4685,16,0,828,1,
66,2612,1,656,2617,
1,65,2341,1,1245,
4686,16,0,828,1,
61,4687,16,0,828,
1,647,4688,16,0,
828,1,1039,4689,16,
0,828,1,1234,4690,
16,0,828,1,835,
4691,16,0,828,1,
1425,4692,16,0,828,
1,1030,4693,16,0,
828,1,828,3231,1,
827,3236,1,629,4694,
16,0,828,1,1017,
4695,16,0,828,1,
620,4696,16,0,828,
1,816,4697,16,0,
828,1,1209,4698,16,
0,828,1,844,4699,
16,0,828,1,790,
3247,1,611,4700,16,
0,828,1,1398,4701,
16,0,828,1,1003,
4702,16,0,828,1,
805,4703,16,0,828,
1,15,2825,1,14,
2878,1,1195,4704,16,
0,828,1,602,4705,
16,0,828,1,1057,
4706,16,0,828,1,
794,4707,16,0,828,
1,793,3260,1,792,
3265,1,791,3270,1,
1184,4708,16,0,828,
1,638,4709,16,0,
828,1,5,4710,19,
133,1,5,4711,5,
102,1,393,2266,1,
979,4712,16,0,827,
1,779,4713,16,0,
827,1,776,3156,1,
774,3172,1,67,2327,
1,116,4714,16,0,
796,1,968,4715,16,
0,431,1,69,2533,
1,1358,4716,16,0,
827,1,76,4717,16,
0,827,1,1159,4718,
16,0,827,1,763,
4719,16,0,827,1,
1220,4720,16,0,827,
1,167,4721,16,0,
827,1,754,4722,16,
0,827,1,65,2341,
1,1168,4723,16,0,
827,1,1142,4724,16,
0,827,1,1118,4725,
16,0,827,1,63,
4726,16,0,827,1,
941,4727,16,0,827,
1,743,4728,16,0,
827,1,346,3670,1,
61,4729,16,0,827,
1,1127,4730,16,0,
827,1,929,4731,16,
0,827,1,727,4732,
16,0,827,1,921,
4733,16,0,827,1,
964,4734,16,0,868,
1,718,4735,16,0,
827,1,1109,4736,16,
0,827,1,318,2524,
1,906,4737,16,0,
131,1,593,4738,16,
0,827,1,115,4739,
16,0,795,1,902,
4740,16,0,141,1,
1094,4741,16,0,827,
1,1289,4742,16,0,
624,1,695,4743,16,
0,827,1,103,4744,
16,0,827,1,890,
4745,16,0,827,1,
1085,4746,16,0,827,
1,1278,4747,16,0,
827,1,686,4748,16,
0,827,1,94,4749,
16,0,827,1,1076,
4750,16,0,827,1,
877,4751,16,0,827,
1,68,2553,1,70,
2499,1,674,4752,16,
0,827,1,868,4753,
16,0,827,1,1261,
3200,1,1260,3205,1,
1259,3210,1,1258,3215,
1,1048,4754,16,0,
827,1,71,2593,1,
661,2597,1,857,4755,
16,0,827,1,659,
4756,16,0,381,1,
1446,4757,16,0,827,
1,66,2612,1,656,
2617,1,121,4758,16,
0,827,1,1245,4759,
16,0,827,1,709,
4760,16,0,827,1,
14,2878,1,647,4761,
16,0,827,1,1039,
4762,16,0,827,1,
1234,4763,16,0,827,
1,835,4764,16,0,
827,1,1425,4765,16,
0,827,1,1030,4766,
16,0,827,1,1422,
4767,16,0,533,1,
828,3231,1,827,3236,
1,629,4768,16,0,
827,1,234,4769,16,
0,722,1,33,3658,
1,1017,4770,16,0,
827,1,620,4771,16,
0,827,1,816,4772,
16,0,827,1,1209,
4773,16,0,827,1,
844,4774,16,0,827,
1,790,3247,1,611,
4775,16,0,827,1,
1398,4776,16,0,827,
1,1003,4777,16,0,
827,1,805,4778,16,
0,827,1,15,2825,
1,211,3669,1,1195,
4779,16,0,827,1,
602,4780,16,0,827,
1,1057,4781,16,0,
827,1,794,4782,16,
0,827,1,793,3260,
1,792,3265,1,791,
3270,1,1184,4783,16,
0,827,1,638,4784,
16,0,827,1,197,
3664,1,3,4785,19,
172,1,3,4786,5,
89,1,979,4787,16,
0,831,1,779,4788,
16,0,831,1,776,
3156,1,1168,4789,16,
0,831,1,67,2327,
1,69,2533,1,1358,
4790,16,0,831,1,
76,4791,16,0,831,
1,1159,4792,16,0,
831,1,763,4793,16,
0,831,1,1220,4794,
16,0,831,1,167,
4795,16,0,831,1,
754,4796,16,0,831,
1,1142,4797,16,0,
831,1,63,4798,16,
0,831,1,774,3172,
1,743,4799,16,0,
831,1,1127,4800,16,
0,831,1,929,4801,
16,0,831,1,727,
4802,16,0,831,1,
1039,4803,16,0,831,
1,1118,4804,16,0,
831,1,866,4805,16,
0,170,1,718,4806,
16,0,831,1,1109,
4807,16,0,831,1,
121,4808,16,0,831,
1,119,4809,16,0,
791,1,709,4810,16,
0,831,1,593,4811,
16,0,831,1,941,
4812,16,0,831,1,
1094,4813,16,0,831,
1,695,4814,16,0,
831,1,103,4815,16,
0,831,1,890,4816,
16,0,831,1,1085,
4817,16,0,831,1,
1278,4818,16,0,831,
1,686,4819,16,0,
831,1,94,4820,16,
0,831,1,1076,4821,
16,0,831,1,877,
4822,16,0,831,1,
70,2499,1,674,4823,
16,0,831,1,868,
4824,16,0,831,1,
1261,3200,1,1260,3205,
1,1259,3210,1,1258,
3215,1,1048,4825,16,
0,831,1,71,2593,
1,661,2597,1,857,
4826,16,0,831,1,
68,2553,1,1446,4827,
16,0,831,1,66,
2612,1,656,2617,1,
65,2341,1,1245,4828,
16,0,831,1,61,
4829,16,0,831,1,
647,4830,16,0,831,
1,921,4831,16,0,
831,1,1234,4832,16,
0,831,1,835,4833,
16,0,831,1,1425,
4834,16,0,831,1,
1030,4835,16,0,831,
1,828,3231,1,827,
3236,1,629,4836,16,
0,831,1,1413,4837,
16,0,544,1,1017,
4838,16,0,831,1,
620,4839,16,0,831,
1,816,4840,16,0,
831,1,1209,4841,16,
0,831,1,844,4842,
16,0,831,1,790,
3247,1,611,4843,16,
0,831,1,1398,4844,
16,0,831,1,1003,
4845,16,0,831,1,
805,4846,16,0,831,
1,15,2825,1,14,
2878,1,1195,4847,16,
0,831,1,602,4848,
16,0,831,1,1057,
4849,16,0,831,1,
794,4850,16,0,831,
1,793,3260,1,792,
3265,1,791,3270,1,
1184,4851,16,0,831,
1,638,4852,16,0,
831,1,2,4853,19,
158,1,2,4854,5,
21,1,1619,2888,1,
1514,2847,1,1584,2933,
1,1582,2883,1,582,
2791,1,1691,2862,1,
1764,2781,1,1504,2855,
1,1799,2910,1,1539,
2820,1,1797,2915,1,
1645,2842,1,1568,2786,
1,1732,2829,1,1564,
2796,1,564,2803,1,
1744,2808,1,1415,2904,
1,1779,2835,1,1738,
2815,1,592,2947,2,
1,0};
            new Sfactory(this, "doesNotBy", new SCreator(doesNotBy_factory));
            new Sfactory(this, "oobjectOnly_318ac4d9886640ad915d368dfcce1ff8", new SCreator(oobjectOnly_318ac4d9886640ad915d368dfcce1ff8_factory));
            new Sfactory(this, "boundTop", new SCreator(boundTop_factory));
            new Sfactory(this, "oobjectOnlyNothing_8646f1419d734b9894c47da4bf657213", new SCreator(oobjectOnlyNothing_8646f1419d734b9894c47da4bf657213_factory));
            new Sfactory(this, "identobject_name_e753f510c632415caecfe92fdfe04132", new SCreator(identobject_name_e753f510c632415caecfe92fdfe04132_factory));
            new Sfactory(this, "notRoleWithXY", new SCreator(notRoleWithXY_factory));
            new Sfactory(this, "condition_is_9851cdc5ee4547de8f6f21edbb5ef45e", new SCreator(condition_is_9851cdc5ee4547de8f6f21edbb5ef45e_factory));
            new Sfactory(this, "builtin_substr_a071f16bc3694a5da45731d98723f29c", new SCreator(builtin_substr_a071f16bc3694a5da45731d98723f29c_factory));
            new Sfactory(this, "boundDataType_0fc663b1365a4a469182eee5fcb869b1", new SCreator(boundDataType_0fc663b1365a4a469182eee5fcb869b1_factory));
            new Sfactory(this, "datavalList", new SCreator(datavalList_factory));
            new Sfactory(this, "valueOrThing_b292e5effebc4cf08f68227d444765da", new SCreator(valueOrThing_b292e5effebc4cf08f68227d444765da_factory));
            new Sfactory(this, "boundFacets", new SCreator(boundFacets_factory));
            new Sfactory(this, "duration_m_f0080b26096e4580ad7cf651e734477a", new SCreator(duration_m_f0080b26096e4580ad7cf651e734477a_factory));
            new Sfactory(this, "objectRoleExpr2_0b291fc985a044dbb25bd6ce57f4e694", new SCreator(objectRoleExpr2_0b291fc985a044dbb25bd6ce57f4e694_factory));
            new Sfactory(this, "facet_7ac077192b684ee5a57818db00d8ba40", new SCreator(facet_7ac077192b684ee5a57818db00d8ba40_factory));
            new Sfactory(this, "exerule", new SCreator(exerule_factory));
            new Sfactory(this, "comparer2_edb3d005808a42149810185952208fc5", new SCreator(comparer2_edb3d005808a42149810185952208fc5_factory));
            new Sfactory(this, "subjectNo", new SCreator(subjectNo_factory));
            new Sfactory(this, "subsumption_if", new SCreator(subsumption_if_factory));
            new Sfactory(this, "duration_m_6c11941f4548438387454a9601225be3", new SCreator(duration_m_6c11941f4548438387454a9601225be3_factory));
            new Sfactory(this, "subjectBigName_d35cd74c001042809ecb7c047ee96c03", new SCreator(subjectBigName_d35cd74c001042809ecb7c047ee96c03_factory));
            new Sfactory(this, "condition_result_role_3118228cc5a84fa1ac3397d77a6a5a83", new SCreator(condition_result_role_3118228cc5a84fa1ac3397d77a6a5a83_factory));
            new Sfactory(this, "datetime_0c55c536432947bc95b1c0540e659c73", new SCreator(datetime_0c55c536432947bc95b1c0540e659c73_factory));
            new Sfactory(this, "isBeAre", new SCreator(isBeAre_factory));
            new Sfactory(this, "condition_data_property_4a412d9875d24be4b511f3ce4fe6af7f", new SCreator(condition_data_property_4a412d9875d24be4b511f3ce4fe6af7f_factory));
            new Sfactory(this, "datavaler", new SCreator(datavaler_factory));
            new Sfactory(this, "oobjectCmpInstance_62f6ed86ccc8445fbfb0f1cbe9b8ee54", new SCreator(oobjectCmpInstance_62f6ed86ccc8445fbfb0f1cbe9b8ee54_factory));
            new Sfactory(this, "rolesubsumption_7b44428ea8344fcebe9eb5d6b1c5c84f", new SCreator(rolesubsumption_7b44428ea8344fcebe9eb5d6b1c5c84f_factory));
            new Sfactory(this, "andComma", new SCreator(andComma_factory));
            new Sfactory(this, "condition_exists_3b7fabca36e94c648fb58c8d856e7ff8", new SCreator(condition_exists_3b7fabca36e94c648fb58c8d856e7ff8_factory));
            new Sfactory(this, "boundVal_c828dcad517f46a4a90fc47a1f03bc1c", new SCreator(boundVal_c828dcad517f46a4a90fc47a1f03bc1c_factory));
            new Sfactory(this, "oobjectOnlyInstance_1efa92f90a8941c78aa48223d0dc46f8", new SCreator(oobjectOnlyInstance_1efa92f90a8941c78aa48223d0dc46f8_factory));
            new Sfactory(this, "boundOneOf_95c897a4a52e48cbbdecc5b57b19d24b", new SCreator(boundOneOf_95c897a4a52e48cbbdecc5b57b19d24b_factory));
            new Sfactory(this, "notidentobject_b94aa5042b0b4cd0b7fb47c31cd21884", new SCreator(notidentobject_b94aa5042b0b4cd0b7fb47c31cd21884_factory));
            new Sfactory(this, "word_number_f29f4b45d4f6440faab7b038d63e8016_1ce16831796c4da3aef1ace355e30bbe", new SCreator(word_number_f29f4b45d4f6440faab7b038d63e8016_1ce16831796c4da3aef1ace355e30bbe_factory));
            new Sfactory(this, "condition", new SCreator(condition_factory));
            new Sfactory(this, "paragraph_c73a4bfe7c064b4c84855e3199998995", new SCreator(paragraph_c73a4bfe7c064b4c84855e3199998995_factory));
            new Sfactory(this, "comparer2_469cb9c5f35a4878b84b753ed5aa6a1a", new SCreator(comparer2_469cb9c5f35a4878b84b753ed5aa6a1a_factory));
            new Sfactory(this, "comparer2_edb3d005808a42149810185952208fc5_8e3c464b3c1d4fd8ba1e6951f15c7a9e", new SCreator(comparer2_edb3d005808a42149810185952208fc5_8e3c464b3c1d4fd8ba1e6951f15c7a9e_factory));
            new Sfactory(this, "builtin_trans_e14262332461450a95eba2859a129c66", new SCreator(builtin_trans_e14262332461450a95eba2859a129c66_factory));
            new Sfactory(this, "andanyrolechain_ae905887b9044709890fb37bfff1f7d2", new SCreator(andanyrolechain_ae905887b9044709890fb37bfff1f7d2_factory));
            new Sfactory(this, "thatOrLoop_268216a573c34a43bde29d7d942ad849", new SCreator(thatOrLoop_268216a573c34a43bde29d7d942ad849_factory));
            new Sfactory(this, "oobjectBnd", new SCreator(oobjectBnd_factory));
            new Sfactory(this, "datavalerPlusList_cf96adeabac64a4f9768270e4f7b43a5", new SCreator(datavalerPlusList_cf96adeabac64a4f9768270e4f7b43a5_factory));
            new Sfactory(this, "orloop_a4d7a2437b774b5f91927bcf3a5d48b8", new SCreator(orloop_a4d7a2437b774b5f91927bcf3a5d48b8_factory));
            new Sfactory(this, "objectRoleExpr3_efd2e20597084fa18a608bf2eebdaee0", new SCreator(objectRoleExpr3_efd2e20597084fa18a608bf2eebdaee0_factory));
            new Sfactory(this, "builtin_datetime_2f4201d44eba4fd1a0014b982148a99f", new SCreator(builtin_datetime_2f4201d44eba4fd1a0014b982148a99f_factory));
            new Sfactory(this, "notidentobject_21178b2016ee43dd9b7828f754df3ee4", new SCreator(notidentobject_21178b2016ee43dd9b7828f754df3ee4_factory));
            new Sfactory(this, "oobjectSomething_2939bf68e33d408393cc769e668447e1", new SCreator(oobjectSomething_2939bf68e33d408393cc769e668447e1_factory));
            new Sfactory(this, "valueOrThing_606f91515c9a4f178ebde2e9e15da180", new SCreator(valueOrThing_606f91515c9a4f178ebde2e9e15da180_factory));
            new Sfactory(this, "builtin_substr_6b286ee63b70402c803dbfc771a3d878", new SCreator(builtin_substr_6b286ee63b70402c803dbfc771a3d878_factory));
            new Sfactory(this, "comparer", new SCreator(comparer_factory));
            new Sfactory(this, "condition_result_builtin", new SCreator(condition_result_builtin_factory));
            new Sfactory(this, "condition_role_450ed8e2227a42cfb94f34d571c49138", new SCreator(condition_role_450ed8e2227a42cfb94f34d571c49138_factory));
            new Sfactory(this, "identobject_inst_3841f77f0f734bcd853061126e5a07ae", new SCreator(identobject_inst_3841f77f0f734bcd853061126e5a07ae_factory));
            new Sfactory(this, "comparer2_ae23ce61f8ed473db910fce732481f63", new SCreator(comparer2_ae23ce61f8ed473db910fce732481f63_factory));
            new Sfactory(this, "comparer2_ce1a6ff8e277483c96f9740c7e35cb79", new SCreator(comparer2_ce1a6ff8e277483c96f9740c7e35cb79_factory));
            new Sfactory(this, "doesNot_a3f6472835454ce98820f5340279efd6", new SCreator(doesNot_a3f6472835454ce98820f5340279efd6_factory));
            new Sfactory(this, "andComma_7a1140bd0fba4a04bdcf342ba6e7a16d", new SCreator(andComma_7a1140bd0fba4a04bdcf342ba6e7a16d_factory));
            new Sfactory(this, "roleWithXY_bb5d6ff79bbc40df8487cf0d619e22e7", new SCreator(roleWithXY_bb5d6ff79bbc40df8487cf0d619e22e7_factory));
            new Sfactory(this, "modality_2994985d0cdc4d74bde814570c298b31_51a1e4967eb4403ba2edffb6c4127ebd", new SCreator(modality_2994985d0cdc4d74bde814570c298b31_51a1e4967eb4403ba2edffb6c4127ebd_factory));
            new Sfactory(this, "oobjectA_ebcc38bea7724ceeb1528c0f415eb9fe", new SCreator(oobjectA_ebcc38bea7724ceeb1528c0f415eb9fe_factory));
            new Sfactory(this, "condition_data_property_bound", new SCreator(condition_data_property_bound_factory));
            new Sfactory(this, "oobjectRelated", new SCreator(oobjectRelated_factory));
            new Sfactory(this, "boundOr", new SCreator(boundOr_factory));
            new Sfactory(this, "unOp2_a6f44f374d46487b93ad3733d3c68a6c_ba7f49eb4a3b484a9a6d606af1527be9", new SCreator(unOp2_a6f44f374d46487b93ad3733d3c68a6c_ba7f49eb4a3b484a9a6d606af1527be9_factory));
            new Sfactory(this, "doesNotBy_85bea99ab26f4aca9250e879bcb8f56d", new SCreator(doesNotBy_85bea99ab26f4aca9250e879bcb8f56d_factory));
            new Sfactory(this, "instanceList_d5ff625a1a5e40f2b562e8162854b3c4", new SCreator(instanceList_d5ff625a1a5e40f2b562e8162854b3c4_factory));
            new Sfactory(this, "datarolesubsumption", new SCreator(datarolesubsumption_factory));
            new Sfactory(this, "singleName", new SCreator(singleName_factory));
            new Sfactory(this, "datarolesubsumption_53b8fa47c596440a848c3686d84ff9fa", new SCreator(datarolesubsumption_53b8fa47c596440a848c3686d84ff9fa_factory));
            new Sfactory(this, "oobjectCmpBnd_ae7f63b9a17b4ffca0c504642566dc07", new SCreator(oobjectCmpBnd_ae7f63b9a17b4ffca0c504642566dc07_factory));
            new Sfactory(this, "subject", new SCreator(subject_factory));
            new Sfactory(this, "builtin_list_9da4d36c3fa049b3bc22c9f613fd1969", new SCreator(builtin_list_9da4d36c3fa049b3bc22c9f613fd1969_factory));
            new Sfactory(this, "orloop", new SCreator(orloop_factory));
            new Sfactory(this, "objectRoleExpr2_4563ca84b9a5499d9d0b46564a48e95d", new SCreator(objectRoleExpr2_4563ca84b9a5499d9d0b46564a48e95d_factory));
            new Sfactory(this, "datetime", new SCreator(datetime_factory));
            new Sfactory(this, "chain_f1d1e8479fab4525a8b3a49c2185acfd", new SCreator(chain_f1d1e8479fab4525a8b3a49c2185acfd_factory));
            new Sfactory(this, "dataroleequivalence2_79e8e3c6387c49ab995139ad18214122", new SCreator(dataroleequivalence2_79e8e3c6387c49ab995139ad18214122_factory));
            new Sfactory(this, "roleWithXY_5c11be3751d74f2fafcd1c1dc41dc069", new SCreator(roleWithXY_5c11be3751d74f2fafcd1c1dc41dc069_factory));
            new Sfactory(this, "comparer_5ecbaad0e39b422491fc9c98728523fc", new SCreator(comparer_5ecbaad0e39b422491fc9c98728523fc_factory));
            new Sfactory(this, "notRoleWithXY_b64e4dfa1d3648f2ba1cb621d93842c4", new SCreator(notRoleWithXY_b64e4dfa1d3648f2ba1cb621d93842c4_factory));
            new Sfactory(this, "subjectBigName_e247709fad4f46e8af6b598ac4e69ed9", new SCreator(subjectBigName_e247709fad4f46e8af6b598ac4e69ed9_factory));
            new Sfactory(this, "unOp_c74ee41853af4d08897b08b21a8b04bb", new SCreator(unOp_c74ee41853af4d08897b08b21a8b04bb_factory));
            new Sfactory(this, "exeargs_09198c24a4c54171b54a3ac103990da0", new SCreator(exeargs_09198c24a4c54171b54a3ac103990da0_factory));
            new Sfactory(this, "exeargs_56a109c849ca4fffb7c041d5d1b34493", new SCreator(exeargs_56a109c849ca4fffb7c041d5d1b34493_factory));
            new Sfactory(this, "datavalval", new SCreator(datavalval_factory));
            new Sfactory(this, "duration_m_32c6f48867c3460fbf618a076eab8e73", new SCreator(duration_m_32c6f48867c3460fbf618a076eab8e73_factory));
            new Sfactory(this, "dataval", new SCreator(dataval_factory));
            new Sfactory(this, "binOp_d4ec7f2581f64fb48b3c50d1edfdbce4", new SCreator(binOp_d4ec7f2581f64fb48b3c50d1edfdbce4_factory));
            new Sfactory(this, "singleOneOf_9f64f95e0fe54d98a7cc112260916b4c", new SCreator(singleOneOf_9f64f95e0fe54d98a7cc112260916b4c_factory));
            new Sfactory(this, "oobjectSomethingThat_07ef2c4b1ef34c98812ebce5f195afb5", new SCreator(oobjectSomethingThat_07ef2c4b1ef34c98812ebce5f195afb5_factory));
            new Sfactory(this, "builtin", new SCreator(builtin_factory));
            new Sfactory(this, "orObjectRoleExprChain_5fc55687f5bb48589182786b97a199c8", new SCreator(orObjectRoleExprChain_5fc55687f5bb48589182786b97a199c8_factory));
            new Sfactory(this, "roleequivalence2", new SCreator(roleequivalence2_factory));
            new Sfactory(this, "Number", new SCreator(Number_factory));
            new Sfactory(this, "abstractbound", new SCreator(abstractbound_factory));
            new Sfactory(this, "swrlrule", new SCreator(swrlrule_factory));
            new Sfactory(this, "duration_m_d99f9c87cb8f49678638ec69894cf1ed", new SCreator(duration_m_d99f9c87cb8f49678638ec69894cf1ed_factory));
            new Sfactory(this, "equalTo_02e1029631bf4b709a469df03d37ec01", new SCreator(equalTo_02e1029631bf4b709a469df03d37ec01_factory));
            new Sfactory(this, "exclusiveunion_9d3feb24afc04ba0a619553526a44646", new SCreator(exclusiveunion_9d3feb24afc04ba0a619553526a44646_factory));
            new Sfactory(this, "Number_695f0fa0c7f749ee9618398b97f99dc9", new SCreator(Number_695f0fa0c7f749ee9618398b97f99dc9_factory));
            new Sfactory(this, "Duration_9e45f683e8974e1281bfe106323d0b43", new SCreator(Duration_9e45f683e8974e1281bfe106323d0b43_factory));
            new Sfactory(this, "duration_m_f51410a0fe5f4f27ba914db7cdb141c7", new SCreator(duration_m_f51410a0fe5f4f27ba914db7cdb141c7_factory));
            new Sfactory(this, "andanyrolechain_0fb0bf0280ea497fa0987d6c7f3495a8", new SCreator(andanyrolechain_0fb0bf0280ea497fa0987d6c7f3495a8_factory));
            new Sfactory(this, "nosubject", new SCreator(nosubject_factory));
            new Sfactory(this, "comparer_145f81cae96f4e20b3227cffa71b35d3", new SCreator(comparer_145f81cae96f4e20b3227cffa71b35d3_factory));
            new Sfactory(this, "instancer", new SCreator(instancer_factory));
            new Sfactory(this, "binOp_bb9c172983b748b9857554319e6d40bb_72f21f793eb145a7ad1885c54a555683", new SCreator(binOp_bb9c172983b748b9857554319e6d40bb_72f21f793eb145a7ad1885c54a555683_factory));
            new Sfactory(this, "notidentobject_29d7f93464bb49ee924c71f88475ad54", new SCreator(notidentobject_29d7f93464bb49ee924c71f88475ad54_factory));
            new Sfactory(this, "boundIdent_ca48d918cfd84dfda3281d288116a0d9", new SCreator(boundIdent_ca48d918cfd84dfda3281d288116a0d9_factory));
            new Sfactory(this, "condition_result_definition", new SCreator(condition_result_definition_factory));
            new Sfactory(this, "single", new SCreator(single_factory));
            new Sfactory(this, "facetList_165d6454d84548f6bd60c95dd795ab59", new SCreator(facetList_165d6454d84548f6bd60c95dd795ab59_factory));
            new Sfactory(this, "objectRoleExpr2_bef62ec5bd3d466a851eadb99cdff5f6", new SCreator(objectRoleExpr2_bef62ec5bd3d466a851eadb99cdff5f6_factory));
            new Sfactory(this, "builtin_unary_free", new SCreator(builtin_unary_free_factory));
            new Sfactory(this, "singleOneOf_f9240bafbcaf418d8bfe10765ad8e1f9", new SCreator(singleOneOf_f9240bafbcaf418d8bfe10765ad8e1f9_factory));
            new Sfactory(this, "clause", new SCreator(clause_factory));
            new Sfactory(this, "exeargs", new SCreator(exeargs_factory));
            new Sfactory(this, "modality2_d1082eb795094c42b220acc0e8512328", new SCreator(modality2_d1082eb795094c42b220acc0e8512328_factory));
            new Sfactory(this, "condition_data_bound_81d74be785d9496f86106ac984df9d6e", new SCreator(condition_data_bound_81d74be785d9496f86106ac984df9d6e_factory));
            new Sfactory(this, "objectRoleExpr1_36cf0e01213f4d05a90288649fbc298a", new SCreator(objectRoleExpr1_36cf0e01213f4d05a90288649fbc298a_factory));
            new Sfactory(this, "builtin_unary_cmp_f42342a2c7e74153bd6fad912164a09e", new SCreator(builtin_unary_cmp_f42342a2c7e74153bd6fad912164a09e_factory));
            new Sfactory(this, "orloop_009a8290e37345849a1180987de9be5b", new SCreator(orloop_009a8290e37345849a1180987de9be5b_factory));
            new Sfactory(this, "exeargs_dedb7be397514b3b8032978e42985b45", new SCreator(exeargs_dedb7be397514b3b8032978e42985b45_factory));
            new Sfactory(this, "oobjectCmp", new SCreator(oobjectCmp_factory));
            new Sfactory(this, "subjectEverything_d8d0f8f1d0e7462c8d1f6773d656e8d3", new SCreator(subjectEverything_d8d0f8f1d0e7462c8d1f6773d656e8d3_factory));
            new Sfactory(this, "subsumption_e11b8feca52a432982c43c7eef4e9fff", new SCreator(subsumption_e11b8feca52a432982c43c7eef4e9fff_factory));
            new Sfactory(this, "identobject_name_2f71ecb76d814507b89088016afc756b", new SCreator(identobject_name_2f71ecb76d814507b89088016afc756b_factory));
            new Sfactory(this, "isBeAre_c074f3547e2642baae4dee8d613e8409", new SCreator(isBeAre_c074f3547e2642baae4dee8d613e8409_factory));
            new Sfactory(this, "datavalerFollowedByList_31358cf7b46841b5b007904f15c8e113", new SCreator(datavalerFollowedByList_31358cf7b46841b5b007904f15c8e113_factory));
            new Sfactory(this, "condition_result_definition_bfa38c97338d412b851ae3a69b9cfb92", new SCreator(condition_result_definition_bfa38c97338d412b851ae3a69b9cfb92_factory));
            new Sfactory(this, "equalTo_02e1029631bf4b709a469df03d37ec01_ab0683c73b1e47619b12824e51bd8938", new SCreator(equalTo_02e1029631bf4b709a469df03d37ec01_ab0683c73b1e47619b12824e51bd8938_factory));
            new Sfactory(this, "Bool_7bd728463a3648f4821dcc1df88074ae", new SCreator(Bool_7bd728463a3648f4821dcc1df88074ae_factory));
            new Sfactory(this, "exerule_0b3d9235c9f049308eaa150fa7fe6dc5", new SCreator(exerule_0b3d9235c9f049308eaa150fa7fe6dc5_factory));
            new Sfactory(this, "singleOneOf", new SCreator(singleOneOf_factory));
            new Sfactory(this, "objectRoleExpr2_924e43f9f12c47d39f389b84218c39b2", new SCreator(objectRoleExpr2_924e43f9f12c47d39f389b84218c39b2_factory));
            new Sfactory(this, "objectr", new SCreator(objectr_factory));
            new Sfactory(this, "objectRoleExpr1", new SCreator(objectRoleExpr1_factory));
            new Sfactory(this, "comparer_a0c0bb93e6ae469793321c37956af897", new SCreator(comparer_a0c0bb93e6ae469793321c37956af897_factory));
            new Sfactory(this, "oobjectOnlyInstance", new SCreator(oobjectOnlyInstance_factory));
            new Sfactory(this, "comparer2_469cb9c5f35a4878b84b753ed5aa6a1a_daf2c9c6e5c8422a9e71782ad63f1af4", new SCreator(comparer2_469cb9c5f35a4878b84b753ed5aa6a1a_daf2c9c6e5c8422a9e71782ad63f1af4_factory));
            new Sfactory(this, "comparer2", new SCreator(comparer2_factory));
            new Sfactory(this, "identobject", new SCreator(identobject_factory));
            new Sfactory(this, "paragraph", new SCreator(paragraph_factory));
            new Sfactory(this, "word_number_75bd5a6cddf347a09ca63021c8ed26ad_faba2b6d66ab4550a02bb74333041ec9", new SCreator(word_number_75bd5a6cddf347a09ca63021c8ed26ad_faba2b6d66ab4550a02bb74333041ec9_factory));
            new Sfactory(this, "duration_m_8bc29c23fa0f414d9fa5214fbebd4ada", new SCreator(duration_m_8bc29c23fa0f414d9fa5214fbebd4ada_factory));
            new Sfactory(this, "nosubsumption", new SCreator(nosubsumption_factory));
            new Sfactory(this, "binOp_bb9c172983b748b9857554319e6d40bb", new SCreator(binOp_bb9c172983b748b9857554319e6d40bb_factory));
            new Sfactory(this, "doesNotBy_efdc773be95d4eb89dc96e2228b39f7c", new SCreator(doesNotBy_efdc773be95d4eb89dc96e2228b39f7c_factory));
            new Sfactory(this, "objectRoleExpr", new SCreator(objectRoleExpr_factory));
            new Sfactory(this, "condition_builtin", new SCreator(condition_builtin_factory));
            new Sfactory(this, "identobject_name_db6df83e230f4c83b0a33be8be59c8ee", new SCreator(identobject_name_db6df83e230f4c83b0a33be8be59c8ee_factory));
            new Sfactory(this, "modality_a2b72e688f854a05b5285b0dafef6501", new SCreator(modality_a2b72e688f854a05b5285b0dafef6501_factory));
            new Sfactory(this, "instancer_67fb63a2276c44c580c90318fac84b88", new SCreator(instancer_67fb63a2276c44c580c90318fac84b88_factory));
            new Sfactory(this, "modality2", new SCreator(modality2_factory));
            new Sfactory(this, "binOp_d03cb2932c8e4f0ab8095286123f6797_6d013372786b4e7294e707369b187f39", new SCreator(binOp_d03cb2932c8e4f0ab8095286123f6797_6d013372786b4e7294e707369b187f39_factory));
            new Sfactory(this, "valueOrThing_b292e5effebc4cf08f68227d444765da_e394101d548f4b1790b3a7fb2cffaaec", new SCreator(valueOrThing_b292e5effebc4cf08f68227d444765da_e394101d548f4b1790b3a7fb2cffaaec_factory));
            new Sfactory(this, "builtin_list", new SCreator(builtin_list_factory));
            new Sfactory(this, "word_number_e49d3cc248904823a1e3a1a3e0636e87", new SCreator(word_number_e49d3cc248904823a1e3a1a3e0636e87_factory));
            new Sfactory(this, "oobjectA_b25547576b434f7fab695d719256db02", new SCreator(oobjectA_b25547576b434f7fab695d719256db02_factory));
            new Sfactory(this, "condition_builtin_404e871395204a49aad4da7fe66997d1", new SCreator(condition_builtin_404e871395204a49aad4da7fe66997d1_factory));
            new Sfactory(this, "datavalerFollowedByList_f66a5ef8595548f28eecf225fee146ed", new SCreator(datavalerFollowedByList_f66a5ef8595548f28eecf225fee146ed_factory));
            new Sfactory(this, "objectr_nio_3e0d3830f09c478b96444fef526d4ef2", new SCreator(objectr_nio_3e0d3830f09c478b96444fef526d4ef2_factory));
            new Sfactory(this, "modality2_65c4f542ddbd4e18bcb08dfa7f89efc6", new SCreator(modality2_65c4f542ddbd4e18bcb08dfa7f89efc6_factory));
            new Sfactory(this, "notidentobject", new SCreator(notidentobject_factory));
            new Sfactory(this, "unOp2_5e29de36058a472b8e84736e6631ef1e", new SCreator(unOp2_5e29de36058a472b8e84736e6631ef1e_factory));
            new Sfactory(this, "oobjectA_17fb8807dc2a404e8456e6658b43a07d", new SCreator(oobjectA_17fb8807dc2a404e8456e6658b43a07d_factory));
            new Sfactory(this, "roleequivalence2_7329660247a3423dbbe6d751ea254a7f", new SCreator(roleequivalence2_7329660247a3423dbbe6d751ea254a7f_factory));
            new Sfactory(this, "unOp_580a60d4d1d54a1c9c8f5c9001e818b1", new SCreator(unOp_580a60d4d1d54a1c9c8f5c9001e818b1_factory));
            new Sfactory(this, "condition_is", new SCreator(condition_is_factory));
            new Sfactory(this, "boundTotal_aece926e36334b22b0ccccd4a9967b6f", new SCreator(boundTotal_aece926e36334b22b0ccccd4a9967b6f_factory));
            new Sfactory(this, "builtin_exe_38dcc13695b745029673f6bf43cce7a6", new SCreator(builtin_exe_38dcc13695b745029673f6bf43cce7a6_factory));
            new Sfactory(this, "builtin_substr_3c32f071139b4b7e9262c07f5e8d086e", new SCreator(builtin_substr_3c32f071139b4b7e9262c07f5e8d086e_factory));
            new Sfactory(this, "andloop_e3de1582f6d74803ab551f91b1708bcd", new SCreator(andloop_e3de1582f6d74803ab551f91b1708bcd_factory));
            new Sfactory(this, "datetime_9d175bd7e80948ccb573987c4312e831", new SCreator(datetime_9d175bd7e80948ccb573987c4312e831_factory));
            new Sfactory(this, "sentence", new SCreator(sentence_factory));
            new Sfactory(this, "singleThing_027b542c7d7d420f9939341d13468e6f", new SCreator(singleThing_027b542c7d7d420f9939341d13468e6f_factory));
            new Sfactory(this, "singleThingThat_c13bf3918b4e485590d9146d5d5071de", new SCreator(singleThingThat_c13bf3918b4e485590d9146d5d5071de_factory));
            new Sfactory(this, "facetList_4439de31ce8d4a6dad5120738bb949b8", new SCreator(facetList_4439de31ce8d4a6dad5120738bb949b8_factory));
            new Sfactory(this, "modality_418a797e33f8415090b8ccb9cf27e0ca", new SCreator(modality_418a797e33f8415090b8ccb9cf27e0ca_factory));
            new Sfactory(this, "condition_data_property", new SCreator(condition_data_property_factory));
            new Sfactory(this, "builtin_alpha", new SCreator(builtin_alpha_factory));
            new Sfactory(this, "comparer_a0c0bb93e6ae469793321c37956af897_04b1cd80d9ec4dc9b2e56bad4333cc56", new SCreator(comparer_a0c0bb93e6ae469793321c37956af897_04b1cd80d9ec4dc9b2e56bad4333cc56_factory));
            new Sfactory(this, "exclusiveunion", new SCreator(exclusiveunion_factory));
            new Sfactory(this, "comparer2_587ff1bbf2da4e7d8b88417a53cfb5e7", new SCreator(comparer2_587ff1bbf2da4e7d8b88417a53cfb5e7_factory));
            new Sfactory(this, "condition_result_data_property_cd2208eb47554d05a88bc19b0e0f3557", new SCreator(condition_result_data_property_cd2208eb47554d05a88bc19b0e0f3557_factory));
            new Sfactory(this, "unOp_45c2620dc3744a0798b88be259a3133e_4966f022786945619ab8bac5dc1c4da7", new SCreator(unOp_45c2620dc3744a0798b88be259a3133e_4966f022786945619ab8bac5dc1c4da7_factory));
            new Sfactory(this, "DateTimeData", new SCreator(DateTimeData_factory));
            new Sfactory(this, "comparer2_214406d730e745df9f734e109290ad77_dc3359640dd04db190bf53abb66fde9a", new SCreator(comparer2_214406d730e745df9f734e109290ad77_dc3359640dd04db190bf53abb66fde9a_factory));
            new Sfactory(this, "equalTo_da1a5ce4efaf479e89d992a3133720b7", new SCreator(equalTo_da1a5ce4efaf479e89d992a3133720b7_factory));
            new Sfactory(this, "objectRoleExpr2_8a5455a74e4b4e8e82837a108198e0cd", new SCreator(objectRoleExpr2_8a5455a74e4b4e8e82837a108198e0cd_factory));
            new Sfactory(this, "oobjectSelf_107b7f335e9642db95cbe9eacf9e8599", new SCreator(oobjectSelf_107b7f335e9642db95cbe9eacf9e8599_factory));
            new Sfactory(this, "subjectNo_3aa0e323824548baae9acb988db41f47", new SCreator(subjectNo_3aa0e323824548baae9acb988db41f47_factory));
            new Sfactory(this, "equalTo_bc50a34a422d45dc9f8aaab9e3c89df6", new SCreator(equalTo_bc50a34a422d45dc9f8aaab9e3c89df6_factory));
            new Sfactory(this, "condition_role_a276b189029044c990d6e87acfb16909", new SCreator(condition_role_a276b189029044c990d6e87acfb16909_factory));
            new Sfactory(this, "boundDataType", new SCreator(boundDataType_factory));
            new Sfactory(this, "code", new SCreator(code_factory));
            new Sfactory(this, "nosubsumption_241070898bd34b07be44ae8b03b9fa25", new SCreator(nosubsumption_241070898bd34b07be44ae8b03b9fa25_factory));
            new Sfactory(this, "aAn_4da7a5201e2b453cab1bb992ac99294f", new SCreator(aAn_4da7a5201e2b453cab1bb992ac99294f_factory));
            new Sfactory(this, "boundFacets_b18592c63926410fa1be8207c1c1239b", new SCreator(boundFacets_b18592c63926410fa1be8207c1c1239b_factory));
            new Sfactory(this, "duration_m", new SCreator(duration_m_factory));
            new Sfactory(this, "instanceBigName_1e636d9f23c1424fb328abdd45d2ce29", new SCreator(instanceBigName_1e636d9f23c1424fb328abdd45d2ce29_factory));
            new Sfactory(this, "StrData", new SCreator(StrData_factory));
            new Sfactory(this, "modality_2994985d0cdc4d74bde814570c298b31", new SCreator(modality_2994985d0cdc4d74bde814570c298b31_factory));
            new Sfactory(this, "swrlrule_943c8bac97c94c82a87e57602514c1d5", new SCreator(swrlrule_943c8bac97c94c82a87e57602514c1d5_factory));
            new Sfactory(this, "identobject_name_a74993c3e8ef4b53b4e341ce3a3d454b", new SCreator(identobject_name_a74993c3e8ef4b53b4e341ce3a3d454b_factory));
            new Sfactory(this, "oobjectOnlySomethingThat_623f154535ae4f53951b0fadee21be88", new SCreator(oobjectOnlySomethingThat_623f154535ae4f53951b0fadee21be88_factory));
            new Sfactory(this, "error", new SCreator(error_factory));
            new Sfactory(this, "singleThingThat_5aa505e771854f21833e7d6c82f10846", new SCreator(singleThingThat_5aa505e771854f21833e7d6c82f10846_factory));
            new Sfactory(this, "boundVal_29311d3be24545c1a3d44fc83ce5932f", new SCreator(boundVal_29311d3be24545c1a3d44fc83ce5932f_factory));
            new Sfactory(this, "binOp_decd62613c0f4f7fafe385767da99fb4", new SCreator(binOp_decd62613c0f4f7fafe385767da99fb4_factory));
            new Sfactory(this, "condition_definition_835c47f908394e68b1462e376f670837", new SCreator(condition_definition_835c47f908394e68b1462e376f670837_factory));
            new Sfactory(this, "objectRoleExpr3", new SCreator(objectRoleExpr3_factory));
            new Sfactory(this, "objectRoleExpr2", new SCreator(objectRoleExpr2_factory));
            new Sfactory(this, "builtin_cmp_946d7d48c4614d5f9794a4058d592831", new SCreator(builtin_cmp_946d7d48c4614d5f9794a4058d592831_factory));
            new Sfactory(this, "builtin_datetime", new SCreator(builtin_datetime_factory));
            new Sfactory(this, "role_19de336b9f7f4160896933435e4fb29a", new SCreator(role_19de336b9f7f4160896933435e4fb29a_factory));
            new Sfactory(this, "boundNot_45259cdb5cc64446ab1766109ff78fdf", new SCreator(boundNot_45259cdb5cc64446ab1766109ff78fdf_factory));
            new Sfactory(this, "builtin_cmp", new SCreator(builtin_cmp_factory));
            new Sfactory(this, "boundAnd", new SCreator(boundAnd_factory));
            new Sfactory(this, "modality2_65c4f542ddbd4e18bcb08dfa7f89efc6_17d398d661fb4d528f09bb6bbab1450f", new SCreator(modality2_65c4f542ddbd4e18bcb08dfa7f89efc6_17d398d661fb4d528f09bb6bbab1450f_factory));
            new Sfactory(this, "singleThing", new SCreator(singleThing_factory));
            new Sfactory(this, "thatOrLoop", new SCreator(thatOrLoop_factory));
            new Sfactory(this, "boundIdent", new SCreator(boundIdent_factory));
            new Sfactory(this, "oobjectBnd_f5bc457fb16a4e18af92122e283da35e", new SCreator(oobjectBnd_f5bc457fb16a4e18af92122e283da35e_factory));
            new Sfactory(this, "dataroleequivalence2", new SCreator(dataroleequivalence2_factory));
            new Sfactory(this, "DateTimeData_2cce692ba0a5488c9b79920d2e985eaf", new SCreator(DateTimeData_2cce692ba0a5488c9b79920d2e985eaf_factory));
            new Sfactory(this, "haskey", new SCreator(haskey_factory));
            new Sfactory(this, "valueOrThing_606f91515c9a4f178ebde2e9e15da180_a0194531c9a046758b0864b1beb8f1b0", new SCreator(valueOrThing_606f91515c9a4f178ebde2e9e15da180_a0194531c9a046758b0864b1beb8f1b0_factory));
            new Sfactory(this, "boundOneOf", new SCreator(boundOneOf_factory));
            new Sfactory(this, "comparer2_11e106ec73574e0d8853ad29dfb3ed8e_27b290a48ef545c1848fd6f340bf8239", new SCreator(comparer2_11e106ec73574e0d8853ad29dfb3ed8e_27b290a48ef545c1848fd6f340bf8239_factory));
            new Sfactory(this, "builtin_unary_cmp", new SCreator(builtin_unary_cmp_factory));
            new Sfactory(this, "oobjectNothing", new SCreator(oobjectNothing_factory));
            new Sfactory(this, "instanceThe", new SCreator(instanceThe_factory));
            new Sfactory(this, "andloop", new SCreator(andloop_factory));
            new Sfactory(this, "modality_8f69bc2826e14a64b655e1d64d497a75_6e7d1c5cb95c495886cac24c6c505c9e", new SCreator(modality_8f69bc2826e14a64b655e1d64d497a75_6e7d1c5cb95c495886cac24c6c505c9e_factory));
            new Sfactory(this, "oobjectOnlyBnd", new SCreator(oobjectOnlyBnd_factory));
            new Sfactory(this, "instance", new SCreator(instance_factory));
            new Sfactory(this, "equivalence2", new SCreator(equivalence2_factory));
            new Sfactory(this, "that", new SCreator(that_factory));
            new Sfactory(this, "builtin_duration", new SCreator(builtin_duration_factory));
            new Sfactory(this, "condition_exists", new SCreator(condition_exists_factory));
            new Sfactory(this, "condition_definition", new SCreator(condition_definition_factory));
            new Sfactory(this, "code_cbe070844a604bcd8667f1542c831241", new SCreator(code_cbe070844a604bcd8667f1542c831241_factory));
            new Sfactory(this, "Number_905fb068ff8c4500a200cb7d77c377a0", new SCreator(Number_905fb068ff8c4500a200cb7d77c377a0_factory));
            new Sfactory(this, "clause_4afb50346dbc4e0ab977917496ae7465", new SCreator(clause_4afb50346dbc4e0ab977917496ae7465_factory));
            new Sfactory(this, "builtin_list_e48ab73f344340b7b7bf105756aaa681", new SCreator(builtin_list_e48ab73f344340b7b7bf105756aaa681_factory));
            new Sfactory(this, "unOp2", new SCreator(unOp2_factory));
            new Sfactory(this, "datavalList_bbab639eab514464a606fc27d2b58cfb", new SCreator(datavalList_bbab639eab514464a606fc27d2b58cfb_factory));
            new Sfactory(this, "unOp_c4ccaad173814dd9849b1c02d3e4fce6", new SCreator(unOp_c4ccaad173814dd9849b1c02d3e4fce6_factory));
            new Sfactory(this, "thatOrLoop_cc5e77cf72b948a89f0ce8fc8ddb7303", new SCreator(thatOrLoop_cc5e77cf72b948a89f0ce8fc8ddb7303_factory));
            new Sfactory(this, "Float", new SCreator(Float_factory));
            new Sfactory(this, "boundNot", new SCreator(boundNot_factory));
            new Sfactory(this, "condition_role", new SCreator(condition_role_factory));
            new Sfactory(this, "objectr_io", new SCreator(objectr_io_factory));
            new Sfactory(this, "unOp_a56e6c90a8e24c09a709d29ba96464e4", new SCreator(unOp_a56e6c90a8e24c09a709d29ba96464e4_factory));
            new Sfactory(this, "roledisjoint2_0e157aedc4c4420286bc66850f27b4a2", new SCreator(roledisjoint2_0e157aedc4c4420286bc66850f27b4a2_factory));
            new Sfactory(this, "oobjectOnlyBnd_0f7bc12a73fe4b20b422df4fe7d65cf3", new SCreator(oobjectOnlyBnd_0f7bc12a73fe4b20b422df4fe7d65cf3_factory));
            new Sfactory(this, "subjectEvery", new SCreator(subjectEvery_factory));
            new Sfactory(this, "clause_result_e4966a20715f4ad6a9f4eaeb33a5ea99", new SCreator(clause_result_e4966a20715f4ad6a9f4eaeb33a5ea99_factory));
            new Sfactory(this, "builtin_annot", new SCreator(builtin_annot_factory));
            new Sfactory(this, "Bool", new SCreator(Bool_factory));
            new Sfactory(this, "comparer2_b0fe676e97734f1ba55ea7231f35b8bc", new SCreator(comparer2_b0fe676e97734f1ba55ea7231f35b8bc_factory));
            new Sfactory(this, "haskey_42d75fdf80ab4593b47edf7159d47307", new SCreator(haskey_42d75fdf80ab4593b47edf7159d47307_factory));
            new Sfactory(this, "chain", new SCreator(chain_factory));
            new Sfactory(this, "condition_result_role", new SCreator(condition_result_role_factory));
            new Sfactory(this, "builtin_bin", new SCreator(builtin_bin_factory));
            new Sfactory(this, "oobjectCmpInstance", new SCreator(oobjectCmpInstance_factory));
            new Sfactory(this, "clause_result_34e19e77573e4cee91a7ff6f0b710780", new SCreator(clause_result_34e19e77573e4cee91a7ff6f0b710780_factory));
            new Sfactory(this, "binOp_d03cb2932c8e4f0ab8095286123f6797", new SCreator(binOp_d03cb2932c8e4f0ab8095286123f6797_factory));
            new Sfactory(this, "Duration", new SCreator(Duration_factory));
            new Sfactory(this, "orObjectRoleExprChain", new SCreator(orObjectRoleExprChain_factory));
            new Sfactory(this, "equivalence2_2ece582c05814d189b07e26b3fc415f0", new SCreator(equivalence2_2ece582c05814d189b07e26b3fc415f0_factory));
            new Sfactory(this, "facetList", new SCreator(facetList_factory));
            new Sfactory(this, "boundOr_175e4bd629cc4ce4bbcb2a4999452b4c", new SCreator(boundOr_175e4bd629cc4ce4bbcb2a4999452b4c_factory));
            new Sfactory(this, "annotation", new SCreator(annotation_factory));
            new Sfactory(this, "oobjectSelf", new SCreator(oobjectSelf_factory));
            new Sfactory(this, "condition_result_data_property", new SCreator(condition_result_data_property_factory));
            new Sfactory(this, "datatypedef", new SCreator(datatypedef_factory));
            new Sfactory(this, "clause_result", new SCreator(clause_result_factory));
            new Sfactory(this, "duration_m_954e0a8601524bfcb8dd02dd40da7138", new SCreator(duration_m_954e0a8601524bfcb8dd02dd40da7138_factory));
            new Sfactory(this, "boundVal", new SCreator(boundVal_factory));
            new Sfactory(this, "boundTotal", new SCreator(boundTotal_factory));
            new Sfactory(this, "notRoleWithXY_52cb25920ebd47df94420b8e97bb2a19", new SCreator(notRoleWithXY_52cb25920ebd47df94420b8e97bb2a19_factory));
            new Sfactory(this, "builtin_bin_e973596f450e4814ab503802d183a2d2", new SCreator(builtin_bin_e973596f450e4814ab503802d183a2d2_factory));
            new Sfactory(this, "oobjectOnlySomethingThat", new SCreator(oobjectOnlySomethingThat_factory));
            new Sfactory(this, "oobjectInstance", new SCreator(oobjectInstance_factory));
            new Sfactory(this, "objectRoleExpr1_447e56a3854146ce9506d780f10a1ba3", new SCreator(objectRoleExpr1_447e56a3854146ce9506d780f10a1ba3_factory));
            new Sfactory(this, "singleThingThat_4af593f3c9c942aa8d42c41502b3cfd9", new SCreator(singleThingThat_4af593f3c9c942aa8d42c41502b3cfd9_factory));
            new Sfactory(this, "orComma_de6f2dda1b30498c9c2c5d4e08dcbc02", new SCreator(orComma_de6f2dda1b30498c9c2c5d4e08dcbc02_factory));
            new Sfactory(this, "datavalerTimesList_f5a5d38302574d3282fede0c80d42c45", new SCreator(datavalerTimesList_f5a5d38302574d3282fede0c80d42c45_factory));
            new Sfactory(this, "identobject_name", new SCreator(identobject_name_factory));
            new Sfactory(this, "duration_w", new SCreator(duration_w_factory));
            new Sfactory(this, "condition_result_is", new SCreator(condition_result_is_factory));
            new Sfactory(this, "word_number_f29f4b45d4f6440faab7b038d63e8016", new SCreator(word_number_f29f4b45d4f6440faab7b038d63e8016_factory));
            new Sfactory(this, "modality2_39e84493f70c44e4b103f81e61df7146", new SCreator(modality2_39e84493f70c44e4b103f81e61df7146_factory));
            new Sfactory(this, "subjectNothing", new SCreator(subjectNothing_factory));
            new Sfactory(this, "subjectThe", new SCreator(subjectThe_factory));
            new Sfactory(this, "datavalerPlusList_1027d4d7a1d44f248cbb749a7b8379c4", new SCreator(datavalerPlusList_1027d4d7a1d44f248cbb749a7b8379c4_factory));
            new Sfactory(this, "comparer2_b0fe676e97734f1ba55ea7231f35b8bc_48f64b1ce3024ea4a87b7d0a4a07a4f6", new SCreator(comparer2_b0fe676e97734f1ba55ea7231f35b8bc_48f64b1ce3024ea4a87b7d0a4a07a4f6_factory));
            new Sfactory(this, "condition_result_is_a76c128b6c4a4fd080e8207bb5686aaf", new SCreator(condition_result_is_a76c128b6c4a4fd080e8207bb5686aaf_factory));
            new Sfactory(this, "comparer_1592b4ba6da04d7aa71e8b2f19b6bc01", new SCreator(comparer_1592b4ba6da04d7aa71e8b2f19b6bc01_factory));
            new Sfactory(this, "unOp_fbfd003d2c10478f98392c2071fc6b30", new SCreator(unOp_fbfd003d2c10478f98392c2071fc6b30_factory));
            new Sfactory(this, "objectr_io_ee9983a723fd4267a9248edc2a281b7b", new SCreator(objectr_io_ee9983a723fd4267a9248edc2a281b7b_factory));
            new Sfactory(this, "identobject_inst", new SCreator(identobject_inst_factory));
            new Sfactory(this, "equalTo_da1a5ce4efaf479e89d992a3133720b7_c77ccc0f563e4beb95e9c323d6772ad7", new SCreator(equalTo_da1a5ce4efaf479e89d992a3133720b7_c77ccc0f563e4beb95e9c323d6772ad7_factory));
            new Sfactory(this, "unOp_7b7d90a7bb91439e9a99a97c9b68aaa3_032a287ddb214419b8fd109c616d4a90", new SCreator(unOp_7b7d90a7bb91439e9a99a97c9b68aaa3_032a287ddb214419b8fd109c616d4a90_factory));
            new Sfactory(this, "unOp_45c2620dc3744a0798b88be259a3133e", new SCreator(unOp_45c2620dc3744a0798b88be259a3133e_factory));
            new Sfactory(this, "comparer_5ecbaad0e39b422491fc9c98728523fc_ba645194d6924b0087226328f3ed2351", new SCreator(comparer_5ecbaad0e39b422491fc9c98728523fc_ba645194d6924b0087226328f3ed2351_factory));
            new Sfactory(this, "orObjectRoleExprChain_1280932fed444a0dbbe66357a095bc98", new SCreator(orObjectRoleExprChain_1280932fed444a0dbbe66357a095bc98_factory));
            new Sfactory(this, "instanceThe_aabecdb18b164b9e806c3f5407c38d6f", new SCreator(instanceThe_aabecdb18b164b9e806c3f5407c38d6f_factory));
            new Sfactory(this, "builtin_list_1f1f215d473e40fbac3c2ea190bd875f", new SCreator(builtin_list_1f1f215d473e40fbac3c2ea190bd875f_factory));
            new Sfactory(this, "unOp2_a6f44f374d46487b93ad3733d3c68a6c", new SCreator(unOp2_a6f44f374d46487b93ad3733d3c68a6c_factory));
            new Sfactory(this, "roledisjoint2", new SCreator(roledisjoint2_factory));
            new Sfactory(this, "StrData_cfad7327880546028155730124b7a9c2", new SCreator(StrData_cfad7327880546028155730124b7a9c2_factory));
            new Sfactory(this, "word_number_75bd5a6cddf347a09ca63021c8ed26ad", new SCreator(word_number_75bd5a6cddf347a09ca63021c8ed26ad_factory));
            new Sfactory(this, "builtin_exe", new SCreator(builtin_exe_factory));
            new Sfactory(this, "oobjectSomething", new SCreator(oobjectSomething_factory));
            new Sfactory(this, "clause_896721228f0749b1835787e438800b80", new SCreator(clause_896721228f0749b1835787e438800b80_factory));
            new Sfactory(this, "instanceList", new SCreator(instanceList_factory));
            new Sfactory(this, "andloop_e2351c0e014c4a929e8994e6c5548a06", new SCreator(andloop_e2351c0e014c4a929e8994e6c5548a06_factory));
            new Sfactory(this, "unOp_7b7d90a7bb91439e9a99a97c9b68aaa3", new SCreator(unOp_7b7d90a7bb91439e9a99a97c9b68aaa3_factory));
            new Sfactory(this, "modality2_a9903bb7580245b5883060adb41cf3e7", new SCreator(modality2_a9903bb7580245b5883060adb41cf3e7_factory));
            new Sfactory(this, "comparer2_214406d730e745df9f734e109290ad77", new SCreator(comparer2_214406d730e745df9f734e109290ad77_factory));
            new Sfactory(this, "paragraph_566245c87df54ee3bb78d5606c0fc1e8", new SCreator(paragraph_566245c87df54ee3bb78d5606c0fc1e8_factory));
            new Sfactory(this, "condition_result_is_92cac4ab014b429fbecd05c009e4f3d3", new SCreator(condition_result_is_92cac4ab014b429fbecd05c009e4f3d3_factory));
            new Sfactory(this, "rolesubsumption_7af6523e728b450da936b5061ba53008", new SCreator(rolesubsumption_7af6523e728b450da936b5061ba53008_factory));
            new Sfactory(this, "role_1dd48d6cbe9549b084e63dbcf3a1aa81", new SCreator(role_1dd48d6cbe9549b084e63dbcf3a1aa81_factory));
            new Sfactory(this, "word_number_f7873402a182481d9f3d6ec914ae2965", new SCreator(word_number_f7873402a182481d9f3d6ec914ae2965_factory));
            new Sfactory(this, "duration_m_55afbd56816a4d12b9ac108a3f2cc8cf", new SCreator(duration_m_55afbd56816a4d12b9ac108a3f2cc8cf_factory));
            new Sfactory(this, "builtin_substr", new SCreator(builtin_substr_factory));
            new Sfactory(this, "annotation_44947d7626e243a382eb0069325b2d2c", new SCreator(annotation_44947d7626e243a382eb0069325b2d2c_factory));
            new Sfactory(this, "oobjectInstance_722298a5591f4241b81f6afc6f9b4040", new SCreator(oobjectInstance_722298a5591f4241b81f6afc6f9b4040_factory));
            new Sfactory(this, "condition_result_role_08f60b79e87347629c40e05c00ba7320", new SCreator(condition_result_role_08f60b79e87347629c40e05c00ba7320_factory));
            new Sfactory(this, "dataroledisjoint2_443ae1c9dfc34907879db58e54a43552", new SCreator(dataroledisjoint2_443ae1c9dfc34907879db58e54a43552_factory));
            new Sfactory(this, "singleName_96baba4832584aa5a9c41319d6aac993", new SCreator(singleName_96baba4832584aa5a9c41319d6aac993_factory));
            new Sfactory(this, "subsumption", new SCreator(subsumption_factory));
            new Sfactory(this, "builtin_alpha_aef1c6f72a054960bdce448f4a84f3a0", new SCreator(builtin_alpha_aef1c6f72a054960bdce448f4a84f3a0_factory));
            new Sfactory(this, "unOp_b29fb39a8a2c4ad6b274981f8a22136c_defeec6d3e904923b3dcb7daa4e43ad1", new SCreator(unOp_b29fb39a8a2c4ad6b274981f8a22136c_defeec6d3e904923b3dcb7daa4e43ad1_factory));
            new Sfactory(this, "condition_data_bound", new SCreator(condition_data_bound_factory));
            new Sfactory(this, "orComma_c868b6e1644e46dd8b823005b69c36f6", new SCreator(orComma_c868b6e1644e46dd8b823005b69c36f6_factory));
            new Sfactory(this, "singleThing_2c020c6f78d04c66affa2f215acad6f0", new SCreator(singleThing_2c020c6f78d04c66affa2f215acad6f0_factory));
            new Sfactory(this, "modality2_a9903bb7580245b5883060adb41cf3e7_5978f781665c46f5898d26123f73c7da", new SCreator(modality2_a9903bb7580245b5883060adb41cf3e7_5978f781665c46f5898d26123f73c7da_factory));
            new Sfactory(this, "valueOrThing", new SCreator(valueOrThing_factory));
            new Sfactory(this, "binOp_decd62613c0f4f7fafe385767da99fb4_7a83a968f8894995b3f2e13a43e8f9f0", new SCreator(binOp_decd62613c0f4f7fafe385767da99fb4_7a83a968f8894995b3f2e13a43e8f9f0_factory));
            new Sfactory(this, "valueOrThing_11693110f638425bb998c8487484accb", new SCreator(valueOrThing_11693110f638425bb998c8487484accb_factory));
            new Sfactory(this, "andanyrolechain_edab88b964b3415ea64a77e329d21f2b", new SCreator(andanyrolechain_edab88b964b3415ea64a77e329d21f2b_factory));
            new Sfactory(this, "subjectEverything_eafee055036a4f93a25c840d4b1400b8", new SCreator(subjectEverything_eafee055036a4f93a25c840d4b1400b8_factory));
            new Sfactory(this, "orComma", new SCreator(orComma_factory));
            new Sfactory(this, "builtin_trans", new SCreator(builtin_trans_factory));
            new Sfactory(this, "subjectThe_6508d4ff2b3946699f3af047d72e60e6", new SCreator(subjectThe_6508d4ff2b3946699f3af047d72e60e6_factory));
            new Sfactory(this, "oobjectNothing_2901c595cf1540c19f93bb5c009cbb87", new SCreator(oobjectNothing_2901c595cf1540c19f93bb5c009cbb87_factory));
            new Sfactory(this, "instanceList_069c2d4f5b5a45a1befc5253260ec712", new SCreator(instanceList_069c2d4f5b5a45a1befc5253260ec712_factory));
            new Sfactory(this, "instanceBigName_9280333231384117af3a6a0100620d76", new SCreator(instanceBigName_9280333231384117af3a6a0100620d76_factory));
            new Sfactory(this, "datavalerTimesList", new SCreator(datavalerTimesList_factory));
            new Sfactory(this, "oobjectOnly", new SCreator(oobjectOnly_factory));
            new Sfactory(this, "andanyrolechain", new SCreator(andanyrolechain_factory));
            new Sfactory(this, "comparer2_6be5d1975f4a46fd94c2f08da7d7a9cf", new SCreator(comparer2_6be5d1975f4a46fd94c2f08da7d7a9cf_factory));
            new Sfactory(this, "boundTop_275235405d9443ac9a990108000eb708", new SCreator(boundTop_275235405d9443ac9a990108000eb708_factory));
            new Sfactory(this, "andanyrolechain_9cb513c982124810877effaecd901b05", new SCreator(andanyrolechain_9cb513c982124810877effaecd901b05_factory));
            new Sfactory(this, "notidentobject_a31997c075994d7399c36d4cff248073", new SCreator(notidentobject_a31997c075994d7399c36d4cff248073_factory));
            new Sfactory(this, "condition_is_2c5c8b2d68c842e797705cfc4be4ccfc", new SCreator(condition_is_2c5c8b2d68c842e797705cfc4be4ccfc_factory));
            new Sfactory(this, "subjectNothing_7a10a8be0b3141b49936878cfa3c2393", new SCreator(subjectNothing_7a10a8be0b3141b49936878cfa3c2393_factory));
            new Sfactory(this, "andComma_e5f37ebe59584ba2868ea509fe54bb77", new SCreator(andComma_e5f37ebe59584ba2868ea509fe54bb77_factory));
            new Sfactory(this, "modality", new SCreator(modality_factory));
            new Sfactory(this, "duration_m_c42cc94093cd4389ba02e7236c12aca7", new SCreator(duration_m_c42cc94093cd4389ba02e7236c12aca7_factory));
            new Sfactory(this, "oobjectOnlyNothing", new SCreator(oobjectOnlyNothing_factory));
            new Sfactory(this, "instanceThe_0e073159e58d4676ae81f9be6dc723ee", new SCreator(instanceThe_0e073159e58d4676ae81f9be6dc723ee_factory));
            new Sfactory(this, "aAn", new SCreator(aAn_factory));
            new Sfactory(this, "isBeAre_5c14e059db714db585d1b5f2d4ff642d", new SCreator(isBeAre_5c14e059db714db585d1b5f2d4ff642d_factory));
            new Sfactory(this, "condition_result", new SCreator(condition_result_factory));
            new Sfactory(this, "facet_0d405be671eb4858b930ed5b5683541e", new SCreator(facet_0d405be671eb4858b930ed5b5683541e_factory));
            new Sfactory(this, "roleWithXY", new SCreator(roleWithXY_factory));
            new Sfactory(this, "dataroledisjoint2", new SCreator(dataroledisjoint2_factory));
            new Sfactory(this, "doesNot", new SCreator(doesNot_factory));
            new Sfactory(this, "binOp", new SCreator(binOp_factory));
            new Sfactory(this, "objectr_nio", new SCreator(objectr_nio_factory));
            new Sfactory(this, "subjectEvery_9a9d70377b6d4bbdb1976cff0484dd2c", new SCreator(subjectEvery_9a9d70377b6d4bbdb1976cff0484dd2c_factory));
            new Sfactory(this, "objectRoleExpr2_1215fd8d349f4815b218576300ac412a", new SCreator(objectRoleExpr2_1215fd8d349f4815b218576300ac412a_factory));
            new Sfactory(this, "datavalerTimesList_b27ec15854c24ac89733734cf77072d2", new SCreator(datavalerTimesList_b27ec15854c24ac89733734cf77072d2_factory));
            new Sfactory(this, "singleNameThat_dcf44b171bab44659e6789f964328462", new SCreator(singleNameThat_dcf44b171bab44659e6789f964328462_factory));
            new Sfactory(this, "condition_data_property_bound_199281df83cd4401ae5f574544961b1e", new SCreator(condition_data_property_bound_199281df83cd4401ae5f574544961b1e_factory));
            new Sfactory(this, "role", new SCreator(role_factory));
            new Sfactory(this, "instanceBigName", new SCreator(instanceBigName_factory));
            new Sfactory(this, "equalTo_d7301e3cdc084c2f97a594538d3895f7", new SCreator(equalTo_d7301e3cdc084c2f97a594538d3895f7_factory));
            new Sfactory(this, "datatypedef_ede858d8e5dc4afdaaf6f887b2464fad", new SCreator(datatypedef_ede858d8e5dc4afdaaf6f887b2464fad_factory));
            new Sfactory(this, "binOp_67f4ca57a0b3428d92570e2f1277da2c", new SCreator(binOp_67f4ca57a0b3428d92570e2f1277da2c_factory));
            new Sfactory(this, "builtin_unary_free_129c9687f63741f982aa3fd65b1d0be0", new SCreator(builtin_unary_free_129c9687f63741f982aa3fd65b1d0be0_factory));
            new Sfactory(this, "datavalerFollowedByList", new SCreator(datavalerFollowedByList_factory));
            new Sfactory(this, "objectRoleExpr2_916548c0549c4e3392c7d97720703364", new SCreator(objectRoleExpr2_916548c0549c4e3392c7d97720703364_factory));
            new Sfactory(this, "datavalvar", new SCreator(datavalvar_factory));
            new Sfactory(this, "binOp_a7b23d9bc410429f82a991f2001c95b2", new SCreator(binOp_a7b23d9bc410429f82a991f2001c95b2_factory));
            new Sfactory(this, "equalTo", new SCreator(equalTo_factory));
            new Sfactory(this, "datavalerPlusList", new SCreator(datavalerPlusList_factory));
            new Sfactory(this, "exclusives_91ffa52d905549b0aaea515988ac0301", new SCreator(exclusives_91ffa52d905549b0aaea515988ac0301_factory));
            new Sfactory(this, "unOp_c74ee41853af4d08897b08b21a8b04bb_f246cea1ed394396824a7e7a2da47609", new SCreator(unOp_c74ee41853af4d08897b08b21a8b04bb_f246cea1ed394396824a7e7a2da47609_factory));
            new Sfactory(this, "duration_m_7047a4fd6e37488cb3d6e52991e74677", new SCreator(duration_m_7047a4fd6e37488cb3d6e52991e74677_factory));
            new Sfactory(this, "unOp", new SCreator(unOp_factory));
            new Sfactory(this, "datavalList_8c8a6b39af874ea182c64a8d745197bc", new SCreator(datavalList_8c8a6b39af874ea182c64a8d745197bc_factory));
            new Sfactory(this, "oobjectCmpBnd", new SCreator(oobjectCmpBnd_factory));
            new Sfactory(this, "unOp_b29fb39a8a2c4ad6b274981f8a22136c", new SCreator(unOp_b29fb39a8a2c4ad6b274981f8a22136c_factory));
            new Sfactory(this, "swrlrulefor", new SCreator(swrlrulefor_factory));
            new Sfactory(this, "facet", new SCreator(facet_factory));
            new Sfactory(this, "subjectEverything", new SCreator(subjectEverything_factory));
            new Sfactory(this, "datavalvar_d0dde5e18b8948c094af05fe960f9d8d", new SCreator(datavalvar_d0dde5e18b8948c094af05fe960f9d8d_factory));
            new Sfactory(this, "comparer2_42749d2044714b4d8ee198f3be859206", new SCreator(comparer2_42749d2044714b4d8ee198f3be859206_factory));
            new Sfactory(this, "valueOrThing_992d64a96a1d4f6cb4906f802c44e3ce", new SCreator(valueOrThing_992d64a96a1d4f6cb4906f802c44e3ce_factory));
            new Sfactory(this, "beAre", new SCreator(beAre_factory));
            new Sfactory(this, "subjectThe_59b29ef9aabf4c0887f1a24fb530874e", new SCreator(subjectThe_59b29ef9aabf4c0887f1a24fb530874e_factory));
            new Sfactory(this, "builtin_annot_d13e72dd7c9a4459bd0b16e8ce7559e3", new SCreator(builtin_annot_d13e72dd7c9a4459bd0b16e8ce7559e3_factory));
            new Sfactory(this, "oobjectA", new SCreator(oobjectA_factory));
            new Sfactory(this, "oobject", new SCreator(oobject_factory));
            new Sfactory(this, "swrlrulefor_132bd0b2a4b14ab5959beb871c7597d2", new SCreator(swrlrulefor_132bd0b2a4b14ab5959beb871c7597d2_factory));
            new Sfactory(this, "doesNotBy_996156a337804089bc11b27d2ae541de", new SCreator(doesNotBy_996156a337804089bc11b27d2ae541de_factory));
            new Sfactory(this, "duration", new SCreator(duration_factory));
            new Sfactory(this, "boundAnd_9c7407cefecf40c9b2a9028e2662b542", new SCreator(boundAnd_9c7407cefecf40c9b2a9028e2662b542_factory));
            new Sfactory(this, "doesNot_ffd19021ca9b42d185d150974fcf38fc", new SCreator(doesNot_ffd19021ca9b42d185d150974fcf38fc_factory));
            new Sfactory(this, "datavalval_bafc195f566548d79632b7bf2b97db37", new SCreator(datavalval_bafc195f566548d79632b7bf2b97db37_factory));
            new Sfactory(this, "singleThingThat", new SCreator(singleThingThat_factory));
            new Sfactory(this, "oobjectCmp_ff0528b2d05e491e8f6feadcdb7a5070", new SCreator(oobjectCmp_ff0528b2d05e491e8f6feadcdb7a5070_factory));
            new Sfactory(this, "word_number", new SCreator(word_number_factory));
            new Sfactory(this, "singleThing_eff0badc6a2b437fbf4688f7c457b0ea", new SCreator(singleThing_eff0badc6a2b437fbf4688f7c457b0ea_factory));
            new Sfactory(this, "exeargs_26c6dfa4d57a4228aafb1dd705608024", new SCreator(exeargs_26c6dfa4d57a4228aafb1dd705608024_factory));
            new Sfactory(this, "facet_35a26489569e44c89c44ce226a3368bc", new SCreator(facet_35a26489569e44c89c44ce226a3368bc_factory));
            new Sfactory(this, "facet_522c79e37a364067a3af29e0c191bfac", new SCreator(facet_522c79e37a364067a3af29e0c191bfac_factory));
            new Sfactory(this, "exclusives", new SCreator(exclusives_factory));
            new Sfactory(this, "chain_5daba5ce21514b7b8d7cd821e7c45d4e", new SCreator(chain_5daba5ce21514b7b8d7cd821e7c45d4e_factory));
            new Sfactory(this, "instancer_b276f0b0160f40d786e314b752ebe195", new SCreator(instancer_b276f0b0160f40d786e314b752ebe195_factory));
            new Sfactory(this, "modality_8f69bc2826e14a64b655e1d64d497a75", new SCreator(modality_8f69bc2826e14a64b655e1d64d497a75_factory));
            new Sfactory(this, "builtin_duration_ba10ee6406b74fe6a00ea802f3072516", new SCreator(builtin_duration_ba10ee6406b74fe6a00ea802f3072516_factory));
            new Sfactory(this, "subjectBigName", new SCreator(subjectBigName_factory));
            new Sfactory(this, "Float_9a6d2ea064fb4affa593690db836281b", new SCreator(Float_9a6d2ea064fb4affa593690db836281b_factory));
            new Sfactory(this, "oobjectSomethingThat", new SCreator(oobjectSomethingThat_factory));
            new Sfactory(this, "comparer2_11e106ec73574e0d8853ad29dfb3ed8e", new SCreator(comparer2_11e106ec73574e0d8853ad29dfb3ed8e_factory));
            new Sfactory(this, "oobjectCardinal", new SCreator(oobjectCardinal_factory));
            new Sfactory(this, "rolesubsumption", new SCreator(rolesubsumption_factory));
            new Sfactory(this, "singleNameThat", new SCreator(singleNameThat_factory));
        }
        public static object doesNotBy_factory(Parser yyp) { return new doesNotBy(yyp); }
        public static object oobjectOnly_318ac4d9886640ad915d368dfcce1ff8_factory(Parser yyp) { return new oobjectOnly_318ac4d9886640ad915d368dfcce1ff8(yyp); }
        public static object boundTop_factory(Parser yyp) { return new boundTop(yyp); }
        public static object oobjectOnlyNothing_8646f1419d734b9894c47da4bf657213_factory(Parser yyp) { return new oobjectOnlyNothing_8646f1419d734b9894c47da4bf657213(yyp); }
        public static object identobject_name_e753f510c632415caecfe92fdfe04132_factory(Parser yyp) { return new identobject_name_e753f510c632415caecfe92fdfe04132(yyp); }
        public static object notRoleWithXY_factory(Parser yyp) { return new notRoleWithXY(yyp); }
        public static object condition_is_9851cdc5ee4547de8f6f21edbb5ef45e_factory(Parser yyp) { return new condition_is_9851cdc5ee4547de8f6f21edbb5ef45e(yyp); }
        public static object builtin_substr_a071f16bc3694a5da45731d98723f29c_factory(Parser yyp) { return new builtin_substr_a071f16bc3694a5da45731d98723f29c(yyp); }
        public static object boundDataType_0fc663b1365a4a469182eee5fcb869b1_factory(Parser yyp) { return new boundDataType_0fc663b1365a4a469182eee5fcb869b1(yyp); }
        public static object datavalList_factory(Parser yyp) { return new datavalList(yyp); }
        public static object valueOrThing_b292e5effebc4cf08f68227d444765da_factory(Parser yyp) { return new valueOrThing_b292e5effebc4cf08f68227d444765da(yyp); }
        public static object boundFacets_factory(Parser yyp) { return new boundFacets(yyp); }
        public static object duration_m_f0080b26096e4580ad7cf651e734477a_factory(Parser yyp) { return new duration_m_f0080b26096e4580ad7cf651e734477a(yyp); }
        public static object objectRoleExpr2_0b291fc985a044dbb25bd6ce57f4e694_factory(Parser yyp) { return new objectRoleExpr2_0b291fc985a044dbb25bd6ce57f4e694(yyp); }
        public static object facet_7ac077192b684ee5a57818db00d8ba40_factory(Parser yyp) { return new facet_7ac077192b684ee5a57818db00d8ba40(yyp); }
        public static object exerule_factory(Parser yyp) { return new exerule(yyp); }
        public static object comparer2_edb3d005808a42149810185952208fc5_factory(Parser yyp) { return new comparer2_edb3d005808a42149810185952208fc5(yyp); }
        public static object subjectNo_factory(Parser yyp) { return new subjectNo(yyp); }
        public static object subsumption_if_factory(Parser yyp) { return new subsumption_if(yyp); }
        public static object duration_m_6c11941f4548438387454a9601225be3_factory(Parser yyp) { return new duration_m_6c11941f4548438387454a9601225be3(yyp); }
        public static object subjectBigName_d35cd74c001042809ecb7c047ee96c03_factory(Parser yyp) { return new subjectBigName_d35cd74c001042809ecb7c047ee96c03(yyp); }
        public static object condition_result_role_3118228cc5a84fa1ac3397d77a6a5a83_factory(Parser yyp) { return new condition_result_role_3118228cc5a84fa1ac3397d77a6a5a83(yyp); }
        public static object datetime_0c55c536432947bc95b1c0540e659c73_factory(Parser yyp) { return new datetime_0c55c536432947bc95b1c0540e659c73(yyp); }
        public static object isBeAre_factory(Parser yyp) { return new isBeAre(yyp); }
        public static object condition_data_property_4a412d9875d24be4b511f3ce4fe6af7f_factory(Parser yyp) { return new condition_data_property_4a412d9875d24be4b511f3ce4fe6af7f(yyp); }
        public static object datavaler_factory(Parser yyp) { return new datavaler(yyp); }
        public static object oobjectCmpInstance_62f6ed86ccc8445fbfb0f1cbe9b8ee54_factory(Parser yyp) { return new oobjectCmpInstance_62f6ed86ccc8445fbfb0f1cbe9b8ee54(yyp); }
        public static object rolesubsumption_7b44428ea8344fcebe9eb5d6b1c5c84f_factory(Parser yyp) { return new rolesubsumption_7b44428ea8344fcebe9eb5d6b1c5c84f(yyp); }
        public static object andComma_factory(Parser yyp) { return new andComma(yyp); }
        public static object condition_exists_3b7fabca36e94c648fb58c8d856e7ff8_factory(Parser yyp) { return new condition_exists_3b7fabca36e94c648fb58c8d856e7ff8(yyp); }
        public static object boundVal_c828dcad517f46a4a90fc47a1f03bc1c_factory(Parser yyp) { return new boundVal_c828dcad517f46a4a90fc47a1f03bc1c(yyp); }
        public static object oobjectOnlyInstance_1efa92f90a8941c78aa48223d0dc46f8_factory(Parser yyp) { return new oobjectOnlyInstance_1efa92f90a8941c78aa48223d0dc46f8(yyp); }
        public static object boundOneOf_95c897a4a52e48cbbdecc5b57b19d24b_factory(Parser yyp) { return new boundOneOf_95c897a4a52e48cbbdecc5b57b19d24b(yyp); }
        public static object notidentobject_b94aa5042b0b4cd0b7fb47c31cd21884_factory(Parser yyp) { return new notidentobject_b94aa5042b0b4cd0b7fb47c31cd21884(yyp); }
        public static object word_number_f29f4b45d4f6440faab7b038d63e8016_1ce16831796c4da3aef1ace355e30bbe_factory(Parser yyp) { return new word_number_f29f4b45d4f6440faab7b038d63e8016_1ce16831796c4da3aef1ace355e30bbe(yyp); }
        public static object condition_factory(Parser yyp) { return new condition(yyp); }
        public static object paragraph_c73a4bfe7c064b4c84855e3199998995_factory(Parser yyp) { return new paragraph_c73a4bfe7c064b4c84855e3199998995(yyp); }
        public static object comparer2_469cb9c5f35a4878b84b753ed5aa6a1a_factory(Parser yyp) { return new comparer2_469cb9c5f35a4878b84b753ed5aa6a1a(yyp); }
        public static object comparer2_edb3d005808a42149810185952208fc5_8e3c464b3c1d4fd8ba1e6951f15c7a9e_factory(Parser yyp) { return new comparer2_edb3d005808a42149810185952208fc5_8e3c464b3c1d4fd8ba1e6951f15c7a9e(yyp); }
        public static object builtin_trans_e14262332461450a95eba2859a129c66_factory(Parser yyp) { return new builtin_trans_e14262332461450a95eba2859a129c66(yyp); }
        public static object andanyrolechain_ae905887b9044709890fb37bfff1f7d2_factory(Parser yyp) { return new andanyrolechain_ae905887b9044709890fb37bfff1f7d2(yyp); }
        public static object thatOrLoop_268216a573c34a43bde29d7d942ad849_factory(Parser yyp) { return new thatOrLoop_268216a573c34a43bde29d7d942ad849(yyp); }
        public static object oobjectBnd_factory(Parser yyp) { return new oobjectBnd(yyp); }
        public static object datavalerPlusList_cf96adeabac64a4f9768270e4f7b43a5_factory(Parser yyp) { return new datavalerPlusList_cf96adeabac64a4f9768270e4f7b43a5(yyp); }
        public static object orloop_a4d7a2437b774b5f91927bcf3a5d48b8_factory(Parser yyp) { return new orloop_a4d7a2437b774b5f91927bcf3a5d48b8(yyp); }
        public static object objectRoleExpr3_efd2e20597084fa18a608bf2eebdaee0_factory(Parser yyp) { return new objectRoleExpr3_efd2e20597084fa18a608bf2eebdaee0(yyp); }
        public static object builtin_datetime_2f4201d44eba4fd1a0014b982148a99f_factory(Parser yyp) { return new builtin_datetime_2f4201d44eba4fd1a0014b982148a99f(yyp); }
        public static object notidentobject_21178b2016ee43dd9b7828f754df3ee4_factory(Parser yyp) { return new notidentobject_21178b2016ee43dd9b7828f754df3ee4(yyp); }
        public static object oobjectSomething_2939bf68e33d408393cc769e668447e1_factory(Parser yyp) { return new oobjectSomething_2939bf68e33d408393cc769e668447e1(yyp); }
        public static object valueOrThing_606f91515c9a4f178ebde2e9e15da180_factory(Parser yyp) { return new valueOrThing_606f91515c9a4f178ebde2e9e15da180(yyp); }
        public static object builtin_substr_6b286ee63b70402c803dbfc771a3d878_factory(Parser yyp) { return new builtin_substr_6b286ee63b70402c803dbfc771a3d878(yyp); }
        public static object comparer_factory(Parser yyp) { return new comparer(yyp); }
        public static object condition_result_builtin_factory(Parser yyp) { return new condition_result_builtin(yyp); }
        public static object condition_role_450ed8e2227a42cfb94f34d571c49138_factory(Parser yyp) { return new condition_role_450ed8e2227a42cfb94f34d571c49138(yyp); }
        public static object identobject_inst_3841f77f0f734bcd853061126e5a07ae_factory(Parser yyp) { return new identobject_inst_3841f77f0f734bcd853061126e5a07ae(yyp); }
        public static object comparer2_ae23ce61f8ed473db910fce732481f63_factory(Parser yyp) { return new comparer2_ae23ce61f8ed473db910fce732481f63(yyp); }
        public static object comparer2_ce1a6ff8e277483c96f9740c7e35cb79_factory(Parser yyp) { return new comparer2_ce1a6ff8e277483c96f9740c7e35cb79(yyp); }
        public static object doesNot_a3f6472835454ce98820f5340279efd6_factory(Parser yyp) { return new doesNot_a3f6472835454ce98820f5340279efd6(yyp); }
        public static object andComma_7a1140bd0fba4a04bdcf342ba6e7a16d_factory(Parser yyp) { return new andComma_7a1140bd0fba4a04bdcf342ba6e7a16d(yyp); }
        public static object roleWithXY_bb5d6ff79bbc40df8487cf0d619e22e7_factory(Parser yyp) { return new roleWithXY_bb5d6ff79bbc40df8487cf0d619e22e7(yyp); }
        public static object modality_2994985d0cdc4d74bde814570c298b31_51a1e4967eb4403ba2edffb6c4127ebd_factory(Parser yyp) { return new modality_2994985d0cdc4d74bde814570c298b31_51a1e4967eb4403ba2edffb6c4127ebd(yyp); }
        public static object oobjectA_ebcc38bea7724ceeb1528c0f415eb9fe_factory(Parser yyp) { return new oobjectA_ebcc38bea7724ceeb1528c0f415eb9fe(yyp); }
        public static object condition_data_property_bound_factory(Parser yyp) { return new condition_data_property_bound(yyp); }
        public static object oobjectRelated_factory(Parser yyp) { return new oobjectRelated(yyp); }
        public static object boundOr_factory(Parser yyp) { return new boundOr(yyp); }
        public static object unOp2_a6f44f374d46487b93ad3733d3c68a6c_ba7f49eb4a3b484a9a6d606af1527be9_factory(Parser yyp) { return new unOp2_a6f44f374d46487b93ad3733d3c68a6c_ba7f49eb4a3b484a9a6d606af1527be9(yyp); }
        public static object doesNotBy_85bea99ab26f4aca9250e879bcb8f56d_factory(Parser yyp) { return new doesNotBy_85bea99ab26f4aca9250e879bcb8f56d(yyp); }
        public static object instanceList_d5ff625a1a5e40f2b562e8162854b3c4_factory(Parser yyp) { return new instanceList_d5ff625a1a5e40f2b562e8162854b3c4(yyp); }
        public static object datarolesubsumption_factory(Parser yyp) { return new datarolesubsumption(yyp); }
        public static object singleName_factory(Parser yyp) { return new singleName(yyp); }
        public static object datarolesubsumption_53b8fa47c596440a848c3686d84ff9fa_factory(Parser yyp) { return new datarolesubsumption_53b8fa47c596440a848c3686d84ff9fa(yyp); }
        public static object oobjectCmpBnd_ae7f63b9a17b4ffca0c504642566dc07_factory(Parser yyp) { return new oobjectCmpBnd_ae7f63b9a17b4ffca0c504642566dc07(yyp); }
        public static object subject_factory(Parser yyp) { return new subject(yyp); }
        public static object builtin_list_9da4d36c3fa049b3bc22c9f613fd1969_factory(Parser yyp) { return new builtin_list_9da4d36c3fa049b3bc22c9f613fd1969(yyp); }
        public static object orloop_factory(Parser yyp) { return new orloop(yyp); }
        public static object objectRoleExpr2_4563ca84b9a5499d9d0b46564a48e95d_factory(Parser yyp) { return new objectRoleExpr2_4563ca84b9a5499d9d0b46564a48e95d(yyp); }
        public static object datetime_factory(Parser yyp) { return new datetime(yyp); }
        public static object chain_f1d1e8479fab4525a8b3a49c2185acfd_factory(Parser yyp) { return new chain_f1d1e8479fab4525a8b3a49c2185acfd(yyp); }
        public static object dataroleequivalence2_79e8e3c6387c49ab995139ad18214122_factory(Parser yyp) { return new dataroleequivalence2_79e8e3c6387c49ab995139ad18214122(yyp); }
        public static object roleWithXY_5c11be3751d74f2fafcd1c1dc41dc069_factory(Parser yyp) { return new roleWithXY_5c11be3751d74f2fafcd1c1dc41dc069(yyp); }
        public static object comparer_5ecbaad0e39b422491fc9c98728523fc_factory(Parser yyp) { return new comparer_5ecbaad0e39b422491fc9c98728523fc(yyp); }
        public static object notRoleWithXY_b64e4dfa1d3648f2ba1cb621d93842c4_factory(Parser yyp) { return new notRoleWithXY_b64e4dfa1d3648f2ba1cb621d93842c4(yyp); }
        public static object subjectBigName_e247709fad4f46e8af6b598ac4e69ed9_factory(Parser yyp) { return new subjectBigName_e247709fad4f46e8af6b598ac4e69ed9(yyp); }
        public static object unOp_c74ee41853af4d08897b08b21a8b04bb_factory(Parser yyp) { return new unOp_c74ee41853af4d08897b08b21a8b04bb(yyp); }
        public static object exeargs_09198c24a4c54171b54a3ac103990da0_factory(Parser yyp) { return new exeargs_09198c24a4c54171b54a3ac103990da0(yyp); }
        public static object exeargs_56a109c849ca4fffb7c041d5d1b34493_factory(Parser yyp) { return new exeargs_56a109c849ca4fffb7c041d5d1b34493(yyp); }
        public static object datavalval_factory(Parser yyp) { return new datavalval(yyp); }
        public static object duration_m_32c6f48867c3460fbf618a076eab8e73_factory(Parser yyp) { return new duration_m_32c6f48867c3460fbf618a076eab8e73(yyp); }
        public static object dataval_factory(Parser yyp) { return new dataval(yyp); }
        public static object binOp_d4ec7f2581f64fb48b3c50d1edfdbce4_factory(Parser yyp) { return new binOp_d4ec7f2581f64fb48b3c50d1edfdbce4(yyp); }
        public static object singleOneOf_9f64f95e0fe54d98a7cc112260916b4c_factory(Parser yyp) { return new singleOneOf_9f64f95e0fe54d98a7cc112260916b4c(yyp); }
        public static object oobjectSomethingThat_07ef2c4b1ef34c98812ebce5f195afb5_factory(Parser yyp) { return new oobjectSomethingThat_07ef2c4b1ef34c98812ebce5f195afb5(yyp); }
        public static object builtin_factory(Parser yyp) { return new builtin(yyp); }
        public static object orObjectRoleExprChain_5fc55687f5bb48589182786b97a199c8_factory(Parser yyp) { return new orObjectRoleExprChain_5fc55687f5bb48589182786b97a199c8(yyp); }
        public static object roleequivalence2_factory(Parser yyp) { return new roleequivalence2(yyp); }
        public static object Number_factory(Parser yyp) { return new Number(yyp); }
        public static object abstractbound_factory(Parser yyp) { return new abstractbound(yyp); }
        public static object swrlrule_factory(Parser yyp) { return new swrlrule(yyp); }
        public static object duration_m_d99f9c87cb8f49678638ec69894cf1ed_factory(Parser yyp) { return new duration_m_d99f9c87cb8f49678638ec69894cf1ed(yyp); }
        public static object equalTo_02e1029631bf4b709a469df03d37ec01_factory(Parser yyp) { return new equalTo_02e1029631bf4b709a469df03d37ec01(yyp); }
        public static object exclusiveunion_9d3feb24afc04ba0a619553526a44646_factory(Parser yyp) { return new exclusiveunion_9d3feb24afc04ba0a619553526a44646(yyp); }
        public static object Number_695f0fa0c7f749ee9618398b97f99dc9_factory(Parser yyp) { return new Number_695f0fa0c7f749ee9618398b97f99dc9(yyp); }
        public static object Duration_9e45f683e8974e1281bfe106323d0b43_factory(Parser yyp) { return new Duration_9e45f683e8974e1281bfe106323d0b43(yyp); }
        public static object duration_m_f51410a0fe5f4f27ba914db7cdb141c7_factory(Parser yyp) { return new duration_m_f51410a0fe5f4f27ba914db7cdb141c7(yyp); }
        public static object andanyrolechain_0fb0bf0280ea497fa0987d6c7f3495a8_factory(Parser yyp) { return new andanyrolechain_0fb0bf0280ea497fa0987d6c7f3495a8(yyp); }
        public static object nosubject_factory(Parser yyp) { return new nosubject(yyp); }
        public static object comparer_145f81cae96f4e20b3227cffa71b35d3_factory(Parser yyp) { return new comparer_145f81cae96f4e20b3227cffa71b35d3(yyp); }
        public static object instancer_factory(Parser yyp) { return new instancer(yyp); }
        public static object binOp_bb9c172983b748b9857554319e6d40bb_72f21f793eb145a7ad1885c54a555683_factory(Parser yyp) { return new binOp_bb9c172983b748b9857554319e6d40bb_72f21f793eb145a7ad1885c54a555683(yyp); }
        public static object notidentobject_29d7f93464bb49ee924c71f88475ad54_factory(Parser yyp) { return new notidentobject_29d7f93464bb49ee924c71f88475ad54(yyp); }
        public static object boundIdent_ca48d918cfd84dfda3281d288116a0d9_factory(Parser yyp) { return new boundIdent_ca48d918cfd84dfda3281d288116a0d9(yyp); }
        public static object condition_result_definition_factory(Parser yyp) { return new condition_result_definition(yyp); }
        public static object single_factory(Parser yyp) { return new single(yyp); }
        public static object facetList_165d6454d84548f6bd60c95dd795ab59_factory(Parser yyp) { return new facetList_165d6454d84548f6bd60c95dd795ab59(yyp); }
        public static object objectRoleExpr2_bef62ec5bd3d466a851eadb99cdff5f6_factory(Parser yyp) { return new objectRoleExpr2_bef62ec5bd3d466a851eadb99cdff5f6(yyp); }
        public static object builtin_unary_free_factory(Parser yyp) { return new builtin_unary_free(yyp); }
        public static object singleOneOf_f9240bafbcaf418d8bfe10765ad8e1f9_factory(Parser yyp) { return new singleOneOf_f9240bafbcaf418d8bfe10765ad8e1f9(yyp); }
        public static object clause_factory(Parser yyp) { return new clause(yyp); }
        public static object exeargs_factory(Parser yyp) { return new exeargs(yyp); }
        public static object modality2_d1082eb795094c42b220acc0e8512328_factory(Parser yyp) { return new modality2_d1082eb795094c42b220acc0e8512328(yyp); }
        public static object condition_data_bound_81d74be785d9496f86106ac984df9d6e_factory(Parser yyp) { return new condition_data_bound_81d74be785d9496f86106ac984df9d6e(yyp); }
        public static object objectRoleExpr1_36cf0e01213f4d05a90288649fbc298a_factory(Parser yyp) { return new objectRoleExpr1_36cf0e01213f4d05a90288649fbc298a(yyp); }
        public static object builtin_unary_cmp_f42342a2c7e74153bd6fad912164a09e_factory(Parser yyp) { return new builtin_unary_cmp_f42342a2c7e74153bd6fad912164a09e(yyp); }
        public static object orloop_009a8290e37345849a1180987de9be5b_factory(Parser yyp) { return new orloop_009a8290e37345849a1180987de9be5b(yyp); }
        public static object exeargs_dedb7be397514b3b8032978e42985b45_factory(Parser yyp) { return new exeargs_dedb7be397514b3b8032978e42985b45(yyp); }
        public static object oobjectCmp_factory(Parser yyp) { return new oobjectCmp(yyp); }
        public static object subjectEverything_d8d0f8f1d0e7462c8d1f6773d656e8d3_factory(Parser yyp) { return new subjectEverything_d8d0f8f1d0e7462c8d1f6773d656e8d3(yyp); }
        public static object subsumption_e11b8feca52a432982c43c7eef4e9fff_factory(Parser yyp) { return new subsumption_e11b8feca52a432982c43c7eef4e9fff(yyp); }
        public static object identobject_name_2f71ecb76d814507b89088016afc756b_factory(Parser yyp) { return new identobject_name_2f71ecb76d814507b89088016afc756b(yyp); }
        public static object isBeAre_c074f3547e2642baae4dee8d613e8409_factory(Parser yyp) { return new isBeAre_c074f3547e2642baae4dee8d613e8409(yyp); }
        public static object datavalerFollowedByList_31358cf7b46841b5b007904f15c8e113_factory(Parser yyp) { return new datavalerFollowedByList_31358cf7b46841b5b007904f15c8e113(yyp); }
        public static object condition_result_definition_bfa38c97338d412b851ae3a69b9cfb92_factory(Parser yyp) { return new condition_result_definition_bfa38c97338d412b851ae3a69b9cfb92(yyp); }
        public static object equalTo_02e1029631bf4b709a469df03d37ec01_ab0683c73b1e47619b12824e51bd8938_factory(Parser yyp) { return new equalTo_02e1029631bf4b709a469df03d37ec01_ab0683c73b1e47619b12824e51bd8938(yyp); }
        public static object Bool_7bd728463a3648f4821dcc1df88074ae_factory(Parser yyp) { return new Bool_7bd728463a3648f4821dcc1df88074ae(yyp); }
        public static object exerule_0b3d9235c9f049308eaa150fa7fe6dc5_factory(Parser yyp) { return new exerule_0b3d9235c9f049308eaa150fa7fe6dc5(yyp); }
        public static object singleOneOf_factory(Parser yyp) { return new singleOneOf(yyp); }
        public static object objectRoleExpr2_924e43f9f12c47d39f389b84218c39b2_factory(Parser yyp) { return new objectRoleExpr2_924e43f9f12c47d39f389b84218c39b2(yyp); }
        public static object objectr_factory(Parser yyp) { return new objectr(yyp); }
        public static object objectRoleExpr1_factory(Parser yyp) { return new objectRoleExpr1(yyp); }
        public static object comparer_a0c0bb93e6ae469793321c37956af897_factory(Parser yyp) { return new comparer_a0c0bb93e6ae469793321c37956af897(yyp); }
        public static object oobjectOnlyInstance_factory(Parser yyp) { return new oobjectOnlyInstance(yyp); }
        public static object comparer2_469cb9c5f35a4878b84b753ed5aa6a1a_daf2c9c6e5c8422a9e71782ad63f1af4_factory(Parser yyp) { return new comparer2_469cb9c5f35a4878b84b753ed5aa6a1a_daf2c9c6e5c8422a9e71782ad63f1af4(yyp); }
        public static object comparer2_factory(Parser yyp) { return new comparer2(yyp); }
        public static object identobject_factory(Parser yyp) { return new identobject(yyp); }
        public static object paragraph_factory(Parser yyp) { return new paragraph(yyp); }
        public static object word_number_75bd5a6cddf347a09ca63021c8ed26ad_faba2b6d66ab4550a02bb74333041ec9_factory(Parser yyp) { return new word_number_75bd5a6cddf347a09ca63021c8ed26ad_faba2b6d66ab4550a02bb74333041ec9(yyp); }
        public static object duration_m_8bc29c23fa0f414d9fa5214fbebd4ada_factory(Parser yyp) { return new duration_m_8bc29c23fa0f414d9fa5214fbebd4ada(yyp); }
        public static object nosubsumption_factory(Parser yyp) { return new nosubsumption(yyp); }
        public static object binOp_bb9c172983b748b9857554319e6d40bb_factory(Parser yyp) { return new binOp_bb9c172983b748b9857554319e6d40bb(yyp); }
        public static object doesNotBy_efdc773be95d4eb89dc96e2228b39f7c_factory(Parser yyp) { return new doesNotBy_efdc773be95d4eb89dc96e2228b39f7c(yyp); }
        public static object objectRoleExpr_factory(Parser yyp) { return new objectRoleExpr(yyp); }
        public static object condition_builtin_factory(Parser yyp) { return new condition_builtin(yyp); }
        public static object identobject_name_db6df83e230f4c83b0a33be8be59c8ee_factory(Parser yyp) { return new identobject_name_db6df83e230f4c83b0a33be8be59c8ee(yyp); }
        public static object modality_a2b72e688f854a05b5285b0dafef6501_factory(Parser yyp) { return new modality_a2b72e688f854a05b5285b0dafef6501(yyp); }
        public static object instancer_67fb63a2276c44c580c90318fac84b88_factory(Parser yyp) { return new instancer_67fb63a2276c44c580c90318fac84b88(yyp); }
        public static object modality2_factory(Parser yyp) { return new modality2(yyp); }
        public static object binOp_d03cb2932c8e4f0ab8095286123f6797_6d013372786b4e7294e707369b187f39_factory(Parser yyp) { return new binOp_d03cb2932c8e4f0ab8095286123f6797_6d013372786b4e7294e707369b187f39(yyp); }
        public static object valueOrThing_b292e5effebc4cf08f68227d444765da_e394101d548f4b1790b3a7fb2cffaaec_factory(Parser yyp) { return new valueOrThing_b292e5effebc4cf08f68227d444765da_e394101d548f4b1790b3a7fb2cffaaec(yyp); }
        public static object builtin_list_factory(Parser yyp) { return new builtin_list(yyp); }
        public static object word_number_e49d3cc248904823a1e3a1a3e0636e87_factory(Parser yyp) { return new word_number_e49d3cc248904823a1e3a1a3e0636e87(yyp); }
        public static object oobjectA_b25547576b434f7fab695d719256db02_factory(Parser yyp) { return new oobjectA_b25547576b434f7fab695d719256db02(yyp); }
        public static object condition_builtin_404e871395204a49aad4da7fe66997d1_factory(Parser yyp) { return new condition_builtin_404e871395204a49aad4da7fe66997d1(yyp); }
        public static object datavalerFollowedByList_f66a5ef8595548f28eecf225fee146ed_factory(Parser yyp) { return new datavalerFollowedByList_f66a5ef8595548f28eecf225fee146ed(yyp); }
        public static object objectr_nio_3e0d3830f09c478b96444fef526d4ef2_factory(Parser yyp) { return new objectr_nio_3e0d3830f09c478b96444fef526d4ef2(yyp); }
        public static object modality2_65c4f542ddbd4e18bcb08dfa7f89efc6_factory(Parser yyp) { return new modality2_65c4f542ddbd4e18bcb08dfa7f89efc6(yyp); }
        public static object notidentobject_factory(Parser yyp) { return new notidentobject(yyp); }
        public static object unOp2_5e29de36058a472b8e84736e6631ef1e_factory(Parser yyp) { return new unOp2_5e29de36058a472b8e84736e6631ef1e(yyp); }
        public static object oobjectA_17fb8807dc2a404e8456e6658b43a07d_factory(Parser yyp) { return new oobjectA_17fb8807dc2a404e8456e6658b43a07d(yyp); }
        public static object roleequivalence2_7329660247a3423dbbe6d751ea254a7f_factory(Parser yyp) { return new roleequivalence2_7329660247a3423dbbe6d751ea254a7f(yyp); }
        public static object unOp_580a60d4d1d54a1c9c8f5c9001e818b1_factory(Parser yyp) { return new unOp_580a60d4d1d54a1c9c8f5c9001e818b1(yyp); }
        public static object condition_is_factory(Parser yyp) { return new condition_is(yyp); }
        public static object boundTotal_aece926e36334b22b0ccccd4a9967b6f_factory(Parser yyp) { return new boundTotal_aece926e36334b22b0ccccd4a9967b6f(yyp); }
        public static object builtin_exe_38dcc13695b745029673f6bf43cce7a6_factory(Parser yyp) { return new builtin_exe_38dcc13695b745029673f6bf43cce7a6(yyp); }
        public static object builtin_substr_3c32f071139b4b7e9262c07f5e8d086e_factory(Parser yyp) { return new builtin_substr_3c32f071139b4b7e9262c07f5e8d086e(yyp); }
        public static object andloop_e3de1582f6d74803ab551f91b1708bcd_factory(Parser yyp) { return new andloop_e3de1582f6d74803ab551f91b1708bcd(yyp); }
        public static object datetime_9d175bd7e80948ccb573987c4312e831_factory(Parser yyp) { return new datetime_9d175bd7e80948ccb573987c4312e831(yyp); }
        public static object sentence_factory(Parser yyp) { return new sentence(yyp); }
        public static object singleThing_027b542c7d7d420f9939341d13468e6f_factory(Parser yyp) { return new singleThing_027b542c7d7d420f9939341d13468e6f(yyp); }
        public static object singleThingThat_c13bf3918b4e485590d9146d5d5071de_factory(Parser yyp) { return new singleThingThat_c13bf3918b4e485590d9146d5d5071de(yyp); }
        public static object facetList_4439de31ce8d4a6dad5120738bb949b8_factory(Parser yyp) { return new facetList_4439de31ce8d4a6dad5120738bb949b8(yyp); }
        public static object modality_418a797e33f8415090b8ccb9cf27e0ca_factory(Parser yyp) { return new modality_418a797e33f8415090b8ccb9cf27e0ca(yyp); }
        public static object condition_data_property_factory(Parser yyp) { return new condition_data_property(yyp); }
        public static object builtin_alpha_factory(Parser yyp) { return new builtin_alpha(yyp); }
        public static object comparer_a0c0bb93e6ae469793321c37956af897_04b1cd80d9ec4dc9b2e56bad4333cc56_factory(Parser yyp) { return new comparer_a0c0bb93e6ae469793321c37956af897_04b1cd80d9ec4dc9b2e56bad4333cc56(yyp); }
        public static object exclusiveunion_factory(Parser yyp) { return new exclusiveunion(yyp); }
        public static object comparer2_587ff1bbf2da4e7d8b88417a53cfb5e7_factory(Parser yyp) { return new comparer2_587ff1bbf2da4e7d8b88417a53cfb5e7(yyp); }
        public static object condition_result_data_property_cd2208eb47554d05a88bc19b0e0f3557_factory(Parser yyp) { return new condition_result_data_property_cd2208eb47554d05a88bc19b0e0f3557(yyp); }
        public static object unOp_45c2620dc3744a0798b88be259a3133e_4966f022786945619ab8bac5dc1c4da7_factory(Parser yyp) { return new unOp_45c2620dc3744a0798b88be259a3133e_4966f022786945619ab8bac5dc1c4da7(yyp); }
        public static object DateTimeData_factory(Parser yyp) { return new DateTimeData(yyp); }
        public static object comparer2_214406d730e745df9f734e109290ad77_dc3359640dd04db190bf53abb66fde9a_factory(Parser yyp) { return new comparer2_214406d730e745df9f734e109290ad77_dc3359640dd04db190bf53abb66fde9a(yyp); }
        public static object equalTo_da1a5ce4efaf479e89d992a3133720b7_factory(Parser yyp) { return new equalTo_da1a5ce4efaf479e89d992a3133720b7(yyp); }
        public static object objectRoleExpr2_8a5455a74e4b4e8e82837a108198e0cd_factory(Parser yyp) { return new objectRoleExpr2_8a5455a74e4b4e8e82837a108198e0cd(yyp); }
        public static object oobjectSelf_107b7f335e9642db95cbe9eacf9e8599_factory(Parser yyp) { return new oobjectSelf_107b7f335e9642db95cbe9eacf9e8599(yyp); }
        public static object subjectNo_3aa0e323824548baae9acb988db41f47_factory(Parser yyp) { return new subjectNo_3aa0e323824548baae9acb988db41f47(yyp); }
        public static object equalTo_bc50a34a422d45dc9f8aaab9e3c89df6_factory(Parser yyp) { return new equalTo_bc50a34a422d45dc9f8aaab9e3c89df6(yyp); }
        public static object condition_role_a276b189029044c990d6e87acfb16909_factory(Parser yyp) { return new condition_role_a276b189029044c990d6e87acfb16909(yyp); }
        public static object boundDataType_factory(Parser yyp) { return new boundDataType(yyp); }
        public static object code_factory(Parser yyp) { return new code(yyp); }
        public static object nosubsumption_241070898bd34b07be44ae8b03b9fa25_factory(Parser yyp) { return new nosubsumption_241070898bd34b07be44ae8b03b9fa25(yyp); }
        public static object aAn_4da7a5201e2b453cab1bb992ac99294f_factory(Parser yyp) { return new aAn_4da7a5201e2b453cab1bb992ac99294f(yyp); }
        public static object boundFacets_b18592c63926410fa1be8207c1c1239b_factory(Parser yyp) { return new boundFacets_b18592c63926410fa1be8207c1c1239b(yyp); }
        public static object duration_m_factory(Parser yyp) { return new duration_m(yyp); }
        public static object instanceBigName_1e636d9f23c1424fb328abdd45d2ce29_factory(Parser yyp) { return new instanceBigName_1e636d9f23c1424fb328abdd45d2ce29(yyp); }
        public static object StrData_factory(Parser yyp) { return new StrData(yyp); }
        public static object modality_2994985d0cdc4d74bde814570c298b31_factory(Parser yyp) { return new modality_2994985d0cdc4d74bde814570c298b31(yyp); }
        public static object swrlrule_943c8bac97c94c82a87e57602514c1d5_factory(Parser yyp) { return new swrlrule_943c8bac97c94c82a87e57602514c1d5(yyp); }
        public static object identobject_name_a74993c3e8ef4b53b4e341ce3a3d454b_factory(Parser yyp) { return new identobject_name_a74993c3e8ef4b53b4e341ce3a3d454b(yyp); }
        public static object oobjectOnlySomethingThat_623f154535ae4f53951b0fadee21be88_factory(Parser yyp) { return new oobjectOnlySomethingThat_623f154535ae4f53951b0fadee21be88(yyp); }
        public static object error_factory(Parser yyp) { return new error(yyp); }
        public static object singleThingThat_5aa505e771854f21833e7d6c82f10846_factory(Parser yyp) { return new singleThingThat_5aa505e771854f21833e7d6c82f10846(yyp); }
        public static object boundVal_29311d3be24545c1a3d44fc83ce5932f_factory(Parser yyp) { return new boundVal_29311d3be24545c1a3d44fc83ce5932f(yyp); }
        public static object binOp_decd62613c0f4f7fafe385767da99fb4_factory(Parser yyp) { return new binOp_decd62613c0f4f7fafe385767da99fb4(yyp); }
        public static object condition_definition_835c47f908394e68b1462e376f670837_factory(Parser yyp) { return new condition_definition_835c47f908394e68b1462e376f670837(yyp); }
        public static object objectRoleExpr3_factory(Parser yyp) { return new objectRoleExpr3(yyp); }
        public static object objectRoleExpr2_factory(Parser yyp) { return new objectRoleExpr2(yyp); }
        public static object builtin_cmp_946d7d48c4614d5f9794a4058d592831_factory(Parser yyp) { return new builtin_cmp_946d7d48c4614d5f9794a4058d592831(yyp); }
        public static object builtin_datetime_factory(Parser yyp) { return new builtin_datetime(yyp); }
        public static object role_19de336b9f7f4160896933435e4fb29a_factory(Parser yyp) { return new role_19de336b9f7f4160896933435e4fb29a(yyp); }
        public static object boundNot_45259cdb5cc64446ab1766109ff78fdf_factory(Parser yyp) { return new boundNot_45259cdb5cc64446ab1766109ff78fdf(yyp); }
        public static object builtin_cmp_factory(Parser yyp) { return new builtin_cmp(yyp); }
        public static object boundAnd_factory(Parser yyp) { return new boundAnd(yyp); }
        public static object modality2_65c4f542ddbd4e18bcb08dfa7f89efc6_17d398d661fb4d528f09bb6bbab1450f_factory(Parser yyp) { return new modality2_65c4f542ddbd4e18bcb08dfa7f89efc6_17d398d661fb4d528f09bb6bbab1450f(yyp); }
        public static object singleThing_factory(Parser yyp) { return new singleThing(yyp); }
        public static object thatOrLoop_factory(Parser yyp) { return new thatOrLoop(yyp); }
        public static object boundIdent_factory(Parser yyp) { return new boundIdent(yyp); }
        public static object oobjectBnd_f5bc457fb16a4e18af92122e283da35e_factory(Parser yyp) { return new oobjectBnd_f5bc457fb16a4e18af92122e283da35e(yyp); }
        public static object dataroleequivalence2_factory(Parser yyp) { return new dataroleequivalence2(yyp); }
        public static object DateTimeData_2cce692ba0a5488c9b79920d2e985eaf_factory(Parser yyp) { return new DateTimeData_2cce692ba0a5488c9b79920d2e985eaf(yyp); }
        public static object haskey_factory(Parser yyp) { return new haskey(yyp); }
        public static object valueOrThing_606f91515c9a4f178ebde2e9e15da180_a0194531c9a046758b0864b1beb8f1b0_factory(Parser yyp) { return new valueOrThing_606f91515c9a4f178ebde2e9e15da180_a0194531c9a046758b0864b1beb8f1b0(yyp); }
        public static object boundOneOf_factory(Parser yyp) { return new boundOneOf(yyp); }
        public static object comparer2_11e106ec73574e0d8853ad29dfb3ed8e_27b290a48ef545c1848fd6f340bf8239_factory(Parser yyp) { return new comparer2_11e106ec73574e0d8853ad29dfb3ed8e_27b290a48ef545c1848fd6f340bf8239(yyp); }
        public static object builtin_unary_cmp_factory(Parser yyp) { return new builtin_unary_cmp(yyp); }
        public static object oobjectNothing_factory(Parser yyp) { return new oobjectNothing(yyp); }
        public static object instanceThe_factory(Parser yyp) { return new instanceThe(yyp); }
        public static object andloop_factory(Parser yyp) { return new andloop(yyp); }
        public static object modality_8f69bc2826e14a64b655e1d64d497a75_6e7d1c5cb95c495886cac24c6c505c9e_factory(Parser yyp) { return new modality_8f69bc2826e14a64b655e1d64d497a75_6e7d1c5cb95c495886cac24c6c505c9e(yyp); }
        public static object oobjectOnlyBnd_factory(Parser yyp) { return new oobjectOnlyBnd(yyp); }
        public static object instance_factory(Parser yyp) { return new instance(yyp); }
        public static object equivalence2_factory(Parser yyp) { return new equivalence2(yyp); }
        public static object that_factory(Parser yyp) { return new that(yyp); }
        public static object builtin_duration_factory(Parser yyp) { return new builtin_duration(yyp); }
        public static object condition_exists_factory(Parser yyp) { return new condition_exists(yyp); }
        public static object condition_definition_factory(Parser yyp) { return new condition_definition(yyp); }
        public static object code_cbe070844a604bcd8667f1542c831241_factory(Parser yyp) { return new code_cbe070844a604bcd8667f1542c831241(yyp); }
        public static object Number_905fb068ff8c4500a200cb7d77c377a0_factory(Parser yyp) { return new Number_905fb068ff8c4500a200cb7d77c377a0(yyp); }
        public static object clause_4afb50346dbc4e0ab977917496ae7465_factory(Parser yyp) { return new clause_4afb50346dbc4e0ab977917496ae7465(yyp); }
        public static object builtin_list_e48ab73f344340b7b7bf105756aaa681_factory(Parser yyp) { return new builtin_list_e48ab73f344340b7b7bf105756aaa681(yyp); }
        public static object unOp2_factory(Parser yyp) { return new unOp2(yyp); }
        public static object datavalList_bbab639eab514464a606fc27d2b58cfb_factory(Parser yyp) { return new datavalList_bbab639eab514464a606fc27d2b58cfb(yyp); }
        public static object unOp_c4ccaad173814dd9849b1c02d3e4fce6_factory(Parser yyp) { return new unOp_c4ccaad173814dd9849b1c02d3e4fce6(yyp); }
        public static object thatOrLoop_cc5e77cf72b948a89f0ce8fc8ddb7303_factory(Parser yyp) { return new thatOrLoop_cc5e77cf72b948a89f0ce8fc8ddb7303(yyp); }
        public static object Float_factory(Parser yyp) { return new Float(yyp); }
        public static object boundNot_factory(Parser yyp) { return new boundNot(yyp); }
        public static object condition_role_factory(Parser yyp) { return new condition_role(yyp); }
        public static object objectr_io_factory(Parser yyp) { return new objectr_io(yyp); }
        public static object unOp_a56e6c90a8e24c09a709d29ba96464e4_factory(Parser yyp) { return new unOp_a56e6c90a8e24c09a709d29ba96464e4(yyp); }
        public static object roledisjoint2_0e157aedc4c4420286bc66850f27b4a2_factory(Parser yyp) { return new roledisjoint2_0e157aedc4c4420286bc66850f27b4a2(yyp); }
        public static object oobjectOnlyBnd_0f7bc12a73fe4b20b422df4fe7d65cf3_factory(Parser yyp) { return new oobjectOnlyBnd_0f7bc12a73fe4b20b422df4fe7d65cf3(yyp); }
        public static object subjectEvery_factory(Parser yyp) { return new subjectEvery(yyp); }
        public static object clause_result_e4966a20715f4ad6a9f4eaeb33a5ea99_factory(Parser yyp) { return new clause_result_e4966a20715f4ad6a9f4eaeb33a5ea99(yyp); }
        public static object builtin_annot_factory(Parser yyp) { return new builtin_annot(yyp); }
        public static object Bool_factory(Parser yyp) { return new Bool(yyp); }
        public static object comparer2_b0fe676e97734f1ba55ea7231f35b8bc_factory(Parser yyp) { return new comparer2_b0fe676e97734f1ba55ea7231f35b8bc(yyp); }
        public static object haskey_42d75fdf80ab4593b47edf7159d47307_factory(Parser yyp) { return new haskey_42d75fdf80ab4593b47edf7159d47307(yyp); }
        public static object chain_factory(Parser yyp) { return new chain(yyp); }
        public static object condition_result_role_factory(Parser yyp) { return new condition_result_role(yyp); }
        public static object builtin_bin_factory(Parser yyp) { return new builtin_bin(yyp); }
        public static object oobjectCmpInstance_factory(Parser yyp) { return new oobjectCmpInstance(yyp); }
        public static object clause_result_34e19e77573e4cee91a7ff6f0b710780_factory(Parser yyp) { return new clause_result_34e19e77573e4cee91a7ff6f0b710780(yyp); }
        public static object binOp_d03cb2932c8e4f0ab8095286123f6797_factory(Parser yyp) { return new binOp_d03cb2932c8e4f0ab8095286123f6797(yyp); }
        public static object Duration_factory(Parser yyp) { return new Duration(yyp); }
        public static object orObjectRoleExprChain_factory(Parser yyp) { return new orObjectRoleExprChain(yyp); }
        public static object equivalence2_2ece582c05814d189b07e26b3fc415f0_factory(Parser yyp) { return new equivalence2_2ece582c05814d189b07e26b3fc415f0(yyp); }
        public static object facetList_factory(Parser yyp) { return new facetList(yyp); }
        public static object boundOr_175e4bd629cc4ce4bbcb2a4999452b4c_factory(Parser yyp) { return new boundOr_175e4bd629cc4ce4bbcb2a4999452b4c(yyp); }
        public static object annotation_factory(Parser yyp) { return new annotation(yyp); }
        public static object oobjectSelf_factory(Parser yyp) { return new oobjectSelf(yyp); }
        public static object condition_result_data_property_factory(Parser yyp) { return new condition_result_data_property(yyp); }
        public static object datatypedef_factory(Parser yyp) { return new datatypedef(yyp); }
        public static object clause_result_factory(Parser yyp) { return new clause_result(yyp); }
        public static object duration_m_954e0a8601524bfcb8dd02dd40da7138_factory(Parser yyp) { return new duration_m_954e0a8601524bfcb8dd02dd40da7138(yyp); }
        public static object boundVal_factory(Parser yyp) { return new boundVal(yyp); }
        public static object boundTotal_factory(Parser yyp) { return new boundTotal(yyp); }
        public static object notRoleWithXY_52cb25920ebd47df94420b8e97bb2a19_factory(Parser yyp) { return new notRoleWithXY_52cb25920ebd47df94420b8e97bb2a19(yyp); }
        public static object builtin_bin_e973596f450e4814ab503802d183a2d2_factory(Parser yyp) { return new builtin_bin_e973596f450e4814ab503802d183a2d2(yyp); }
        public static object oobjectOnlySomethingThat_factory(Parser yyp) { return new oobjectOnlySomethingThat(yyp); }
        public static object oobjectInstance_factory(Parser yyp) { return new oobjectInstance(yyp); }
        public static object objectRoleExpr1_447e56a3854146ce9506d780f10a1ba3_factory(Parser yyp) { return new objectRoleExpr1_447e56a3854146ce9506d780f10a1ba3(yyp); }
        public static object singleThingThat_4af593f3c9c942aa8d42c41502b3cfd9_factory(Parser yyp) { return new singleThingThat_4af593f3c9c942aa8d42c41502b3cfd9(yyp); }
        public static object orComma_de6f2dda1b30498c9c2c5d4e08dcbc02_factory(Parser yyp) { return new orComma_de6f2dda1b30498c9c2c5d4e08dcbc02(yyp); }
        public static object datavalerTimesList_f5a5d38302574d3282fede0c80d42c45_factory(Parser yyp) { return new datavalerTimesList_f5a5d38302574d3282fede0c80d42c45(yyp); }
        public static object identobject_name_factory(Parser yyp) { return new identobject_name(yyp); }
        public static object duration_w_factory(Parser yyp) { return new duration_w(yyp); }
        public static object condition_result_is_factory(Parser yyp) { return new condition_result_is(yyp); }
        public static object word_number_f29f4b45d4f6440faab7b038d63e8016_factory(Parser yyp) { return new word_number_f29f4b45d4f6440faab7b038d63e8016(yyp); }
        public static object modality2_39e84493f70c44e4b103f81e61df7146_factory(Parser yyp) { return new modality2_39e84493f70c44e4b103f81e61df7146(yyp); }
        public static object subjectNothing_factory(Parser yyp) { return new subjectNothing(yyp); }
        public static object subjectThe_factory(Parser yyp) { return new subjectThe(yyp); }
        public static object datavalerPlusList_1027d4d7a1d44f248cbb749a7b8379c4_factory(Parser yyp) { return new datavalerPlusList_1027d4d7a1d44f248cbb749a7b8379c4(yyp); }
        public static object comparer2_b0fe676e97734f1ba55ea7231f35b8bc_48f64b1ce3024ea4a87b7d0a4a07a4f6_factory(Parser yyp) { return new comparer2_b0fe676e97734f1ba55ea7231f35b8bc_48f64b1ce3024ea4a87b7d0a4a07a4f6(yyp); }
        public static object condition_result_is_a76c128b6c4a4fd080e8207bb5686aaf_factory(Parser yyp) { return new condition_result_is_a76c128b6c4a4fd080e8207bb5686aaf(yyp); }
        public static object comparer_1592b4ba6da04d7aa71e8b2f19b6bc01_factory(Parser yyp) { return new comparer_1592b4ba6da04d7aa71e8b2f19b6bc01(yyp); }
        public static object unOp_fbfd003d2c10478f98392c2071fc6b30_factory(Parser yyp) { return new unOp_fbfd003d2c10478f98392c2071fc6b30(yyp); }
        public static object objectr_io_ee9983a723fd4267a9248edc2a281b7b_factory(Parser yyp) { return new objectr_io_ee9983a723fd4267a9248edc2a281b7b(yyp); }
        public static object identobject_inst_factory(Parser yyp) { return new identobject_inst(yyp); }
        public static object equalTo_da1a5ce4efaf479e89d992a3133720b7_c77ccc0f563e4beb95e9c323d6772ad7_factory(Parser yyp) { return new equalTo_da1a5ce4efaf479e89d992a3133720b7_c77ccc0f563e4beb95e9c323d6772ad7(yyp); }
        public static object unOp_7b7d90a7bb91439e9a99a97c9b68aaa3_032a287ddb214419b8fd109c616d4a90_factory(Parser yyp) { return new unOp_7b7d90a7bb91439e9a99a97c9b68aaa3_032a287ddb214419b8fd109c616d4a90(yyp); }
        public static object unOp_45c2620dc3744a0798b88be259a3133e_factory(Parser yyp) { return new unOp_45c2620dc3744a0798b88be259a3133e(yyp); }
        public static object comparer_5ecbaad0e39b422491fc9c98728523fc_ba645194d6924b0087226328f3ed2351_factory(Parser yyp) { return new comparer_5ecbaad0e39b422491fc9c98728523fc_ba645194d6924b0087226328f3ed2351(yyp); }
        public static object orObjectRoleExprChain_1280932fed444a0dbbe66357a095bc98_factory(Parser yyp) { return new orObjectRoleExprChain_1280932fed444a0dbbe66357a095bc98(yyp); }
        public static object instanceThe_aabecdb18b164b9e806c3f5407c38d6f_factory(Parser yyp) { return new instanceThe_aabecdb18b164b9e806c3f5407c38d6f(yyp); }
        public static object builtin_list_1f1f215d473e40fbac3c2ea190bd875f_factory(Parser yyp) { return new builtin_list_1f1f215d473e40fbac3c2ea190bd875f(yyp); }
        public static object unOp2_a6f44f374d46487b93ad3733d3c68a6c_factory(Parser yyp) { return new unOp2_a6f44f374d46487b93ad3733d3c68a6c(yyp); }
        public static object roledisjoint2_factory(Parser yyp) { return new roledisjoint2(yyp); }
        public static object StrData_cfad7327880546028155730124b7a9c2_factory(Parser yyp) { return new StrData_cfad7327880546028155730124b7a9c2(yyp); }
        public static object word_number_75bd5a6cddf347a09ca63021c8ed26ad_factory(Parser yyp) { return new word_number_75bd5a6cddf347a09ca63021c8ed26ad(yyp); }
        public static object builtin_exe_factory(Parser yyp) { return new builtin_exe(yyp); }
        public static object oobjectSomething_factory(Parser yyp) { return new oobjectSomething(yyp); }
        public static object clause_896721228f0749b1835787e438800b80_factory(Parser yyp) { return new clause_896721228f0749b1835787e438800b80(yyp); }
        public static object instanceList_factory(Parser yyp) { return new instanceList(yyp); }
        public static object andloop_e2351c0e014c4a929e8994e6c5548a06_factory(Parser yyp) { return new andloop_e2351c0e014c4a929e8994e6c5548a06(yyp); }
        public static object unOp_7b7d90a7bb91439e9a99a97c9b68aaa3_factory(Parser yyp) { return new unOp_7b7d90a7bb91439e9a99a97c9b68aaa3(yyp); }
        public static object modality2_a9903bb7580245b5883060adb41cf3e7_factory(Parser yyp) { return new modality2_a9903bb7580245b5883060adb41cf3e7(yyp); }
        public static object comparer2_214406d730e745df9f734e109290ad77_factory(Parser yyp) { return new comparer2_214406d730e745df9f734e109290ad77(yyp); }
        public static object paragraph_566245c87df54ee3bb78d5606c0fc1e8_factory(Parser yyp) { return new paragraph_566245c87df54ee3bb78d5606c0fc1e8(yyp); }
        public static object condition_result_is_92cac4ab014b429fbecd05c009e4f3d3_factory(Parser yyp) { return new condition_result_is_92cac4ab014b429fbecd05c009e4f3d3(yyp); }
        public static object rolesubsumption_7af6523e728b450da936b5061ba53008_factory(Parser yyp) { return new rolesubsumption_7af6523e728b450da936b5061ba53008(yyp); }
        public static object role_1dd48d6cbe9549b084e63dbcf3a1aa81_factory(Parser yyp) { return new role_1dd48d6cbe9549b084e63dbcf3a1aa81(yyp); }
        public static object word_number_f7873402a182481d9f3d6ec914ae2965_factory(Parser yyp) { return new word_number_f7873402a182481d9f3d6ec914ae2965(yyp); }
        public static object duration_m_55afbd56816a4d12b9ac108a3f2cc8cf_factory(Parser yyp) { return new duration_m_55afbd56816a4d12b9ac108a3f2cc8cf(yyp); }
        public static object builtin_substr_factory(Parser yyp) { return new builtin_substr(yyp); }
        public static object annotation_44947d7626e243a382eb0069325b2d2c_factory(Parser yyp) { return new annotation_44947d7626e243a382eb0069325b2d2c(yyp); }
        public static object oobjectInstance_722298a5591f4241b81f6afc6f9b4040_factory(Parser yyp) { return new oobjectInstance_722298a5591f4241b81f6afc6f9b4040(yyp); }
        public static object condition_result_role_08f60b79e87347629c40e05c00ba7320_factory(Parser yyp) { return new condition_result_role_08f60b79e87347629c40e05c00ba7320(yyp); }
        public static object dataroledisjoint2_443ae1c9dfc34907879db58e54a43552_factory(Parser yyp) { return new dataroledisjoint2_443ae1c9dfc34907879db58e54a43552(yyp); }
        public static object singleName_96baba4832584aa5a9c41319d6aac993_factory(Parser yyp) { return new singleName_96baba4832584aa5a9c41319d6aac993(yyp); }
        public static object subsumption_factory(Parser yyp) { return new subsumption(yyp); }
        public static object builtin_alpha_aef1c6f72a054960bdce448f4a84f3a0_factory(Parser yyp) { return new builtin_alpha_aef1c6f72a054960bdce448f4a84f3a0(yyp); }
        public static object unOp_b29fb39a8a2c4ad6b274981f8a22136c_defeec6d3e904923b3dcb7daa4e43ad1_factory(Parser yyp) { return new unOp_b29fb39a8a2c4ad6b274981f8a22136c_defeec6d3e904923b3dcb7daa4e43ad1(yyp); }
        public static object condition_data_bound_factory(Parser yyp) { return new condition_data_bound(yyp); }
        public static object orComma_c868b6e1644e46dd8b823005b69c36f6_factory(Parser yyp) { return new orComma_c868b6e1644e46dd8b823005b69c36f6(yyp); }
        public static object singleThing_2c020c6f78d04c66affa2f215acad6f0_factory(Parser yyp) { return new singleThing_2c020c6f78d04c66affa2f215acad6f0(yyp); }
        public static object modality2_a9903bb7580245b5883060adb41cf3e7_5978f781665c46f5898d26123f73c7da_factory(Parser yyp) { return new modality2_a9903bb7580245b5883060adb41cf3e7_5978f781665c46f5898d26123f73c7da(yyp); }
        public static object valueOrThing_factory(Parser yyp) { return new valueOrThing(yyp); }
        public static object binOp_decd62613c0f4f7fafe385767da99fb4_7a83a968f8894995b3f2e13a43e8f9f0_factory(Parser yyp) { return new binOp_decd62613c0f4f7fafe385767da99fb4_7a83a968f8894995b3f2e13a43e8f9f0(yyp); }
        public static object valueOrThing_11693110f638425bb998c8487484accb_factory(Parser yyp) { return new valueOrThing_11693110f638425bb998c8487484accb(yyp); }
        public static object andanyrolechain_edab88b964b3415ea64a77e329d21f2b_factory(Parser yyp) { return new andanyrolechain_edab88b964b3415ea64a77e329d21f2b(yyp); }
        public static object subjectEverything_eafee055036a4f93a25c840d4b1400b8_factory(Parser yyp) { return new subjectEverything_eafee055036a4f93a25c840d4b1400b8(yyp); }
        public static object orComma_factory(Parser yyp) { return new orComma(yyp); }
        public static object builtin_trans_factory(Parser yyp) { return new builtin_trans(yyp); }
        public static object subjectThe_6508d4ff2b3946699f3af047d72e60e6_factory(Parser yyp) { return new subjectThe_6508d4ff2b3946699f3af047d72e60e6(yyp); }
        public static object oobjectNothing_2901c595cf1540c19f93bb5c009cbb87_factory(Parser yyp) { return new oobjectNothing_2901c595cf1540c19f93bb5c009cbb87(yyp); }
        public static object instanceList_069c2d4f5b5a45a1befc5253260ec712_factory(Parser yyp) { return new instanceList_069c2d4f5b5a45a1befc5253260ec712(yyp); }
        public static object instanceBigName_9280333231384117af3a6a0100620d76_factory(Parser yyp) { return new instanceBigName_9280333231384117af3a6a0100620d76(yyp); }
        public static object datavalerTimesList_factory(Parser yyp) { return new datavalerTimesList(yyp); }
        public static object oobjectOnly_factory(Parser yyp) { return new oobjectOnly(yyp); }
        public static object andanyrolechain_factory(Parser yyp) { return new andanyrolechain(yyp); }
        public static object comparer2_6be5d1975f4a46fd94c2f08da7d7a9cf_factory(Parser yyp) { return new comparer2_6be5d1975f4a46fd94c2f08da7d7a9cf(yyp); }
        public static object boundTop_275235405d9443ac9a990108000eb708_factory(Parser yyp) { return new boundTop_275235405d9443ac9a990108000eb708(yyp); }
        public static object andanyrolechain_9cb513c982124810877effaecd901b05_factory(Parser yyp) { return new andanyrolechain_9cb513c982124810877effaecd901b05(yyp); }
        public static object notidentobject_a31997c075994d7399c36d4cff248073_factory(Parser yyp) { return new notidentobject_a31997c075994d7399c36d4cff248073(yyp); }
        public static object condition_is_2c5c8b2d68c842e797705cfc4be4ccfc_factory(Parser yyp) { return new condition_is_2c5c8b2d68c842e797705cfc4be4ccfc(yyp); }
        public static object subjectNothing_7a10a8be0b3141b49936878cfa3c2393_factory(Parser yyp) { return new subjectNothing_7a10a8be0b3141b49936878cfa3c2393(yyp); }
        public static object andComma_e5f37ebe59584ba2868ea509fe54bb77_factory(Parser yyp) { return new andComma_e5f37ebe59584ba2868ea509fe54bb77(yyp); }
        public static object modality_factory(Parser yyp) { return new modality(yyp); }
        public static object duration_m_c42cc94093cd4389ba02e7236c12aca7_factory(Parser yyp) { return new duration_m_c42cc94093cd4389ba02e7236c12aca7(yyp); }
        public static object oobjectOnlyNothing_factory(Parser yyp) { return new oobjectOnlyNothing(yyp); }
        public static object instanceThe_0e073159e58d4676ae81f9be6dc723ee_factory(Parser yyp) { return new instanceThe_0e073159e58d4676ae81f9be6dc723ee(yyp); }
        public static object aAn_factory(Parser yyp) { return new aAn(yyp); }
        public static object isBeAre_5c14e059db714db585d1b5f2d4ff642d_factory(Parser yyp) { return new isBeAre_5c14e059db714db585d1b5f2d4ff642d(yyp); }
        public static object condition_result_factory(Parser yyp) { return new condition_result(yyp); }
        public static object facet_0d405be671eb4858b930ed5b5683541e_factory(Parser yyp) { return new facet_0d405be671eb4858b930ed5b5683541e(yyp); }
        public static object roleWithXY_factory(Parser yyp) { return new roleWithXY(yyp); }
        public static object dataroledisjoint2_factory(Parser yyp) { return new dataroledisjoint2(yyp); }
        public static object doesNot_factory(Parser yyp) { return new doesNot(yyp); }
        public static object binOp_factory(Parser yyp) { return new binOp(yyp); }
        public static object objectr_nio_factory(Parser yyp) { return new objectr_nio(yyp); }
        public static object subjectEvery_9a9d70377b6d4bbdb1976cff0484dd2c_factory(Parser yyp) { return new subjectEvery_9a9d70377b6d4bbdb1976cff0484dd2c(yyp); }
        public static object objectRoleExpr2_1215fd8d349f4815b218576300ac412a_factory(Parser yyp) { return new objectRoleExpr2_1215fd8d349f4815b218576300ac412a(yyp); }
        public static object datavalerTimesList_b27ec15854c24ac89733734cf77072d2_factory(Parser yyp) { return new datavalerTimesList_b27ec15854c24ac89733734cf77072d2(yyp); }
        public static object singleNameThat_dcf44b171bab44659e6789f964328462_factory(Parser yyp) { return new singleNameThat_dcf44b171bab44659e6789f964328462(yyp); }
        public static object condition_data_property_bound_199281df83cd4401ae5f574544961b1e_factory(Parser yyp) { return new condition_data_property_bound_199281df83cd4401ae5f574544961b1e(yyp); }
        public static object role_factory(Parser yyp) { return new role(yyp); }
        public static object instanceBigName_factory(Parser yyp) { return new instanceBigName(yyp); }
        public static object equalTo_d7301e3cdc084c2f97a594538d3895f7_factory(Parser yyp) { return new equalTo_d7301e3cdc084c2f97a594538d3895f7(yyp); }
        public static object datatypedef_ede858d8e5dc4afdaaf6f887b2464fad_factory(Parser yyp) { return new datatypedef_ede858d8e5dc4afdaaf6f887b2464fad(yyp); }
        public static object binOp_67f4ca57a0b3428d92570e2f1277da2c_factory(Parser yyp) { return new binOp_67f4ca57a0b3428d92570e2f1277da2c(yyp); }
        public static object builtin_unary_free_129c9687f63741f982aa3fd65b1d0be0_factory(Parser yyp) { return new builtin_unary_free_129c9687f63741f982aa3fd65b1d0be0(yyp); }
        public static object datavalerFollowedByList_factory(Parser yyp) { return new datavalerFollowedByList(yyp); }
        public static object objectRoleExpr2_916548c0549c4e3392c7d97720703364_factory(Parser yyp) { return new objectRoleExpr2_916548c0549c4e3392c7d97720703364(yyp); }
        public static object datavalvar_factory(Parser yyp) { return new datavalvar(yyp); }
        public static object binOp_a7b23d9bc410429f82a991f2001c95b2_factory(Parser yyp) { return new binOp_a7b23d9bc410429f82a991f2001c95b2(yyp); }
        public static object equalTo_factory(Parser yyp) { return new equalTo(yyp); }
        public static object datavalerPlusList_factory(Parser yyp) { return new datavalerPlusList(yyp); }
        public static object exclusives_91ffa52d905549b0aaea515988ac0301_factory(Parser yyp) { return new exclusives_91ffa52d905549b0aaea515988ac0301(yyp); }
        public static object unOp_c74ee41853af4d08897b08b21a8b04bb_f246cea1ed394396824a7e7a2da47609_factory(Parser yyp) { return new unOp_c74ee41853af4d08897b08b21a8b04bb_f246cea1ed394396824a7e7a2da47609(yyp); }
        public static object duration_m_7047a4fd6e37488cb3d6e52991e74677_factory(Parser yyp) { return new duration_m_7047a4fd6e37488cb3d6e52991e74677(yyp); }
        public static object unOp_factory(Parser yyp) { return new unOp(yyp); }
        public static object datavalList_8c8a6b39af874ea182c64a8d745197bc_factory(Parser yyp) { return new datavalList_8c8a6b39af874ea182c64a8d745197bc(yyp); }
        public static object oobjectCmpBnd_factory(Parser yyp) { return new oobjectCmpBnd(yyp); }
        public static object unOp_b29fb39a8a2c4ad6b274981f8a22136c_factory(Parser yyp) { return new unOp_b29fb39a8a2c4ad6b274981f8a22136c(yyp); }
        public static object swrlrulefor_factory(Parser yyp) { return new swrlrulefor(yyp); }
        public static object facet_factory(Parser yyp) { return new facet(yyp); }
        public static object subjectEverything_factory(Parser yyp) { return new subjectEverything(yyp); }
        public static object datavalvar_d0dde5e18b8948c094af05fe960f9d8d_factory(Parser yyp) { return new datavalvar_d0dde5e18b8948c094af05fe960f9d8d(yyp); }
        public static object comparer2_42749d2044714b4d8ee198f3be859206_factory(Parser yyp) { return new comparer2_42749d2044714b4d8ee198f3be859206(yyp); }
        public static object valueOrThing_992d64a96a1d4f6cb4906f802c44e3ce_factory(Parser yyp) { return new valueOrThing_992d64a96a1d4f6cb4906f802c44e3ce(yyp); }
        public static object beAre_factory(Parser yyp) { return new beAre(yyp); }
        public static object subjectThe_59b29ef9aabf4c0887f1a24fb530874e_factory(Parser yyp) { return new subjectThe_59b29ef9aabf4c0887f1a24fb530874e(yyp); }
        public static object builtin_annot_d13e72dd7c9a4459bd0b16e8ce7559e3_factory(Parser yyp) { return new builtin_annot_d13e72dd7c9a4459bd0b16e8ce7559e3(yyp); }
        public static object oobjectA_factory(Parser yyp) { return new oobjectA(yyp); }
        public static object oobject_factory(Parser yyp) { return new oobject(yyp); }
        public static object swrlrulefor_132bd0b2a4b14ab5959beb871c7597d2_factory(Parser yyp) { return new swrlrulefor_132bd0b2a4b14ab5959beb871c7597d2(yyp); }
        public static object doesNotBy_996156a337804089bc11b27d2ae541de_factory(Parser yyp) { return new doesNotBy_996156a337804089bc11b27d2ae541de(yyp); }
        public static object duration_factory(Parser yyp) { return new duration(yyp); }
        public static object boundAnd_9c7407cefecf40c9b2a9028e2662b542_factory(Parser yyp) { return new boundAnd_9c7407cefecf40c9b2a9028e2662b542(yyp); }
        public static object doesNot_ffd19021ca9b42d185d150974fcf38fc_factory(Parser yyp) { return new doesNot_ffd19021ca9b42d185d150974fcf38fc(yyp); }
        public static object datavalval_bafc195f566548d79632b7bf2b97db37_factory(Parser yyp) { return new datavalval_bafc195f566548d79632b7bf2b97db37(yyp); }
        public static object singleThingThat_factory(Parser yyp) { return new singleThingThat(yyp); }
        public static object oobjectCmp_ff0528b2d05e491e8f6feadcdb7a5070_factory(Parser yyp) { return new oobjectCmp_ff0528b2d05e491e8f6feadcdb7a5070(yyp); }
        public static object word_number_factory(Parser yyp) { return new word_number(yyp); }
        public static object singleThing_eff0badc6a2b437fbf4688f7c457b0ea_factory(Parser yyp) { return new singleThing_eff0badc6a2b437fbf4688f7c457b0ea(yyp); }
        public static object exeargs_26c6dfa4d57a4228aafb1dd705608024_factory(Parser yyp) { return new exeargs_26c6dfa4d57a4228aafb1dd705608024(yyp); }
        public static object facet_35a26489569e44c89c44ce226a3368bc_factory(Parser yyp) { return new facet_35a26489569e44c89c44ce226a3368bc(yyp); }
        public static object facet_522c79e37a364067a3af29e0c191bfac_factory(Parser yyp) { return new facet_522c79e37a364067a3af29e0c191bfac(yyp); }
        public static object exclusives_factory(Parser yyp) { return new exclusives(yyp); }
        public static object chain_5daba5ce21514b7b8d7cd821e7c45d4e_factory(Parser yyp) { return new chain_5daba5ce21514b7b8d7cd821e7c45d4e(yyp); }
        public static object instancer_b276f0b0160f40d786e314b752ebe195_factory(Parser yyp) { return new instancer_b276f0b0160f40d786e314b752ebe195(yyp); }
        public static object modality_8f69bc2826e14a64b655e1d64d497a75_factory(Parser yyp) { return new modality_8f69bc2826e14a64b655e1d64d497a75(yyp); }
        public static object builtin_duration_ba10ee6406b74fe6a00ea802f3072516_factory(Parser yyp) { return new builtin_duration_ba10ee6406b74fe6a00ea802f3072516(yyp); }
        public static object subjectBigName_factory(Parser yyp) { return new subjectBigName(yyp); }
        public static object Float_9a6d2ea064fb4affa593690db836281b_factory(Parser yyp) { return new Float_9a6d2ea064fb4affa593690db836281b(yyp); }
        public static object oobjectSomethingThat_factory(Parser yyp) { return new oobjectSomethingThat(yyp); }
        public static object comparer2_11e106ec73574e0d8853ad29dfb3ed8e_factory(Parser yyp) { return new comparer2_11e106ec73574e0d8853ad29dfb3ed8e(yyp); }
        public static object oobjectCardinal_factory(Parser yyp) { return new oobjectCardinal(yyp); }
        public static object rolesubsumption_factory(Parser yyp) { return new rolesubsumption(yyp); }
        public static object singleNameThat_factory(Parser yyp) { return new singleNameThat(yyp); }
    }
    public class endl : Parser
    {
        public endl() : base(new yyendl(), new tokens()) { }
        public endl(YyParser syms) : base(syms, new tokens()) { }
        public endl(YyParser syms, ErrorHandler erh) : base(syms, new tokens(erh)) { }

    }
}
