﻿namespace CogniPy.CNL.EN
{
    public interface IVisitor
    {
        object Visit(paragraph p);
        object Visit(annotation p);
        object Visit(dlannotationassertion p);
        object Visit(subsumption p);
        object Visit(nosubsumption p);
        object Visit(equivalence2 p);
        object Visit(exclusives p);
        object Visit(exclusiveunion p);
        object Visit(subsumption_if p);
        object Visit(datatypedef p);
        object Visit(rolesubsumption p);
        object Visit(roleequivalence2 p);
        object Visit(roledisjoint2 p);
        object Visit(datarolesubsumption p);
        object Visit(dataroleequivalence2 p);
        object Visit(dataroledisjoint2 p);
        object Visit(haskey p);
        object Visit(subjectEvery p);
        object Visit(subjectEverything p);
        object Visit(subjectNo p);
        object Visit(subjectNothing p);
        object Visit(subjectBigName p);
        object Visit(subjectThe p);
        object Visit(objectRoleExpr1 p);
        object Visit(objectRoleExpr2 p);
        object Visit(objectRoleExpr3 p);
        object Visit(role p);
        object Visit(roleWithXY p);
        object Visit(notRoleWithXY p);
        object Visit(instanceThe p);
        object Visit(instanceBigName p);
        object Visit(oobjectA p);
        object Visit(oobjectInstance p);
        object Visit(oobjectOnly p);
        object Visit(oobjectOnlyInstance p);
        object Visit(oobjectCmp p);
        object Visit(oobjectCmpInstance p);
        object Visit(oobjectBnd p);
        object Visit(oobjectOnlyBnd p);
        object Visit(oobjectCmpBnd p);
        object Visit(oobjectSelf p);
        object Visit(oobjectSomething p);
        object Visit(oobjectNothing p);
        object Visit(oobjectOnlyNothing p);
        object Visit(oobjectSomethingThat p);
        object Visit(oobjectOnlySomethingThat p);
        object Visit(singleName p);
        object Visit(singleThing p);
        object Visit(singleNameThat p);
        object Visit(singleThingThat p);
        object Visit(singleOneOf p);
        object Visit(thatOrLoop p);
        object Visit(andloop p);
        object Visit(orloop p);
        object Visit(facet p);
        object Visit(facetList p);
        object Visit(boundFacets p);
        object Visit(boundAnd p);
        object Visit(boundOr p);
        object Visit(boundNot p);
        object Visit(boundVal p);
        object Visit(boundOneOf p);
        object Visit(boundTop p);
        object Visit(boundTotal p);
        object Visit(boundDataType p);
        object Visit(Number p);
        object Visit(StrData p);
        object Visit(DateTimeData p);
        object Visit(Duration p);
        object Visit(Float p);
        object Visit(Bool p);
        object Visit(swrlrule p);
        object Visit(clause p);
        object Visit(clause_result p);
        object Visit(condition_is p);
        object Visit(condition_exists p);
        object Visit(condition_definition p);
        object Visit(condition_role p);
        object Visit(condition_data_property p);
        object Visit(condition_data_property_bound p);
        object Visit(condition_data_bound p);
        object Visit(condition_result_is p);
        object Visit(condition_result_definition p);
        object Visit(condition_result_role p);
        object Visit(condition_result_data_property p);
        object Visit(condition_result_builtin p);
        object Visit(condition_builtin p);
        object Visit(objectr_nio p);
        object Visit(objectr_io p);
        object Visit(datavalvar p);
        object Visit(datavalval p);
        object Visit(notidentobject p);
        object Visit(identobject_name p);
        object Visit(identobject_inst p);
        object Visit(instancer p);
        object Visit(swrlrulefor p);
        object Visit(exerule p);
        object Visit(exeargs p);
        object Visit(code p);
        object Visit(builtin_cmp p);
        object Visit(builtin_list p);
        object Visit(builtin_bin p);
        object Visit(builtin_unary_cmp p);
        object Visit(builtin_unary_free p);
        object Visit(builtin_substr p);
        object Visit(builtin_trans p);
        object Visit(builtin_duration p);
        object Visit(builtin_datetime p);
        object Visit(builtin_alpha p);
        object Visit(builtin_annot p);
        object Visit(builtin_exe p);
        object Visit(duration_w p);
        object Visit(duration_m p);
        object Visit(datetime p);
    }
}
