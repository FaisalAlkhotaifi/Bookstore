"use strict";(self.webpackChunkbookstore_web=self.webpackChunkbookstore_web||[]).push([[891],{2891:(Q,u,i)=>{i.r(u),i.d(u,{AuthorModule:()=>J});var d=i(9808),m=i(6074),c=i(333),a=i(2382),t=i(4893),f=i(7844),h=i(4858),_=i(5405),g=i(5930),A=i(1554),p=i(5667);let v=(()=>{class e{constructor(r,n,s,L){this._appFormErrorService=r,this._location=n,this._fb=s,this._authorService=L,this.form=new a.cw({}),this.isLoading=!1}get genderOptions(){return[{key:"Male",label:"Male"},{key:"Female",label:"Female"}]}ngOnInit(){this._initForm()}hasError(r){return this._appFormErrorService.hasError(r,this.form)}getControlError(r){return this._appFormErrorService.getControlError(this.form.get(r))}onSubmit(){!this.form.valid||(this.isLoading=!0,this._authorService.add(this.form.value).then(()=>{this.isLoading=!1,this._location.back()}).catch(()=>this.isLoading=!1))}_initForm(){this.form=this._fb.group({fullName:new a.NI(null,[a.kI.required]),birthDate:new a.NI(null,[a.kI.required]),nationality:new a.NI(null,[a.kI.required]),phoneNumber:new a.NI(null,[a.kI.required]),gender:new a.NI(null,[a.kI.required])})}}return e.\u0275fac=function(r){return new(r||e)(t.Y36(f.z),t.Y36(d.Ye),t.Y36(a.qu),t.Y36(h.Y))},e.\u0275cmp=t.Xpm({type:e,selectors:[["app-author-add"]],decls:21,vars:20,consts:[[1,"dashboard-content-wrap"],[1,"dashboard-content-header-wrap"],[1,"dashboard-content-header-title"],[1,"form-wrap",3,"formGroup","ngSubmit"],[1,"row","g-4"],[1,"col-lg-6"],["formControlName","fullName","label","Name",3,"isRequired","hasError","errorMessage"],["formControlName","birthDate","label","Birth Date",3,"isRequired","hasError","errorMessage"],["formControlName","nationality","label","Nationality",3,"isRequired","hasError","errorMessage"],["formControlName","phoneNumber","label","Phone Number",3,"isRequired","hasError","errorMessage"],["formControlName","gender","label","Gender","placeholder","Select",3,"options","isRequired","isDisables","hasError","errorMessage"],[1,"form-submit-wrap","row","g-4"],[1,"col-lg-12","text-center"],["title","Add",3,"disabled","isLoading"]],template:function(r,n){1&r&&(t.TgZ(0,"div",0)(1,"div",1)(2,"div",2)(3,"h3"),t._uU(4,"Add New Book Category"),t.qZA()()(),t.TgZ(5,"div")(6,"form",3),t.NdJ("ngSubmit",function(){return n.onSubmit()}),t.TgZ(7,"div",4)(8,"div",5),t._UZ(9,"app-text-form-field",6),t.qZA(),t.TgZ(10,"div",5),t._UZ(11,"app-date-form-field",7),t.qZA(),t.TgZ(12,"div",5),t._UZ(13,"app-text-form-field",8),t.qZA(),t.TgZ(14,"div",5),t._UZ(15,"app-text-form-field",9),t.qZA(),t.TgZ(16,"div",5),t._UZ(17,"app-dropdown-form-field",10),t.qZA(),t.TgZ(18,"div",11)(19,"div",12),t._UZ(20,"app-button",13),t.qZA()()()()()()),2&r&&(t.xp6(6),t.Q6J("formGroup",n.form),t.xp6(3),t.Q6J("isRequired",!0)("hasError",n.hasError("fullName"))("errorMessage",n.getControlError("fullName")),t.xp6(2),t.Q6J("isRequired",!0)("hasError",n.hasError("birthDate"))("errorMessage",n.getControlError("birthDate")),t.xp6(2),t.Q6J("isRequired",!0)("hasError",n.hasError("nationality"))("errorMessage",n.getControlError("nationality")),t.xp6(2),t.Q6J("isRequired",!0)("hasError",n.hasError("phoneNumber"))("errorMessage",n.getControlError("phoneNumber")),t.xp6(2),t.Q6J("options",n.genderOptions)("isRequired",!0)("isDisables",!1)("hasError",n.hasError("gender"))("errorMessage",n.getControlError("gender")),t.xp6(3),t.Q6J("disabled",!n.form.valid)("isLoading",n.isLoading))},directives:[a._Y,a.JL,a.sg,_.N,a.JJ,a.u,g.a,A.L,p.r],styles:[""]}),e})();var l=i(4999);function C(e,o){1&e&&(t.TgZ(0,"th",16),t._uU(1," Name "),t.qZA())}function Z(e,o){if(1&e&&(t.TgZ(0,"td",17),t._uU(1),t.qZA()),2&e){const r=o.$implicit;t.xp6(1),t.hij(" ",r.fullName," ")}}function N(e,o){1&e&&(t.TgZ(0,"th",16),t._uU(1," Birth Date "),t.qZA())}function b(e,o){if(1&e&&(t.TgZ(0,"td",17),t._uU(1),t.ALo(2,"date"),t.qZA()),2&e){const r=o.$implicit;t.xp6(1),t.hij(" ",t.xi3(2,1,r.birthDate,"mediumDate")," ")}}function T(e,o){1&e&&(t.TgZ(0,"th",16),t._uU(1," Nationality "),t.qZA())}function S(e,o){if(1&e&&(t.TgZ(0,"td",17),t._uU(1),t.qZA()),2&e){const r=o.$implicit;t.xp6(1),t.hij(" ",r.nationality," ")}}function y(e,o){1&e&&(t.TgZ(0,"th",16),t._uU(1," Phone Number "),t.qZA())}function w(e,o){if(1&e&&(t.TgZ(0,"td",17),t._uU(1),t.qZA()),2&e){const r=o.$implicit;t.xp6(1),t.hij(" ",r.phoneNumber," ")}}function D(e,o){1&e&&(t.TgZ(0,"th",16),t._uU(1," Gender "),t.qZA())}function E(e,o){if(1&e&&(t.TgZ(0,"td",17),t._uU(1),t.qZA()),2&e){const r=o.$implicit;t.xp6(1),t.hij(" ",r.gender," ")}}function q(e,o){1&e&&t._UZ(0,"tr",18)}function Y(e,o){1&e&&t._UZ(0,"tr",19)}function U(e,o){if(1&e&&(t.TgZ(0,"div",5)(1,"mat-table",6),t.ynx(2,7),t.YNc(3,C,2,0,"th",8),t.YNc(4,Z,2,1,"td",9),t.BQk(),t.ynx(5,10),t.YNc(6,N,2,0,"th",8),t.YNc(7,b,3,4,"td",9),t.BQk(),t.ynx(8,11),t.YNc(9,T,2,0,"th",8),t.YNc(10,S,2,1,"td",9),t.BQk(),t.ynx(11,12),t.YNc(12,y,2,0,"th",8),t.YNc(13,w,2,1,"td",9),t.BQk(),t.ynx(14,13),t.YNc(15,D,2,0,"th",8),t.YNc(16,E,2,1,"td",9),t.BQk(),t.YNc(17,q,1,0,"tr",14),t.YNc(18,Y,1,0,"tr",15),t.qZA()()),2&e){const r=t.oxw();t.xp6(1),t.Q6J("dataSource",r.dataList),t.xp6(16),t.Q6J("matHeaderRowDef",r.displayedColumns),t.xp6(1),t.Q6J("matRowDefColumns",r.displayedColumns)}}const x=[{path:"",component:(()=>{class e{constructor(){}ngOnInit(){}}return e.\u0275fac=function(r){return new(r||e)},e.\u0275cmp=t.Xpm({type:e,selectors:[["app-author"]],decls:1,vars:0,template:function(r,n){1&r&&t._UZ(0,"router-outlet")},directives:[m.lC],styles:[""]}),e})(),children:[{path:"",component:(()=>{class e{constructor(r,n,s){this._authService=r,this._router=n,this._activatedRoute=s,this.displayedColumns=["fullName","birthDate","nationality","phoneNumber","gender"],this.dataList=[]}ngOnInit(){this._setDataList()}onAddNew(){this._goto(["new"])}_setDataList(){this._authService.getAll().then(r=>this.dataList=r)}_goto(r){this._router.navigate(r,{relativeTo:this._activatedRoute})}}return e.\u0275fac=function(r){return new(r||e)(t.Y36(h.Y),t.Y36(m.F0),t.Y36(m.gz))},e.\u0275cmp=t.Xpm({type:e,selectors:[["app-author-starter"]],decls:8,vars:1,consts:[[1,"dashboard-content-wrap"],[1,"dashboard-content-header-wrap"],[1,"dashboard-content-header-title"],["title","Add",3,"click"],["class","table-container",4,"ngIf"],[1,"table-container"],[3,"dataSource"],["matColumnDef","fullName"],["mat-header-cell","",4,"matHeaderCellDef"],["mat-cell","",4,"matCellDef"],["matColumnDef","birthDate"],["matColumnDef","nationality"],["matColumnDef","phoneNumber"],["matColumnDef","gender"],["mat-header-row","",4,"matHeaderRowDef"],["mat-row","",4,"matRowDef","matRowDefColumns"],["mat-header-cell",""],["mat-cell",""],["mat-header-row",""],["mat-row",""]],template:function(r,n){1&r&&(t.TgZ(0,"div",0)(1,"div",1)(2,"div",2)(3,"h3"),t._uU(4,"Authors"),t.qZA()(),t.TgZ(5,"div")(6,"app-button",3),t.NdJ("click",function(){return n.onAddNew()}),t.qZA()()(),t.YNc(7,U,19,3,"div",4),t.qZA()),2&r&&(t.xp6(7),t.Q6J("ngIf",n.dataList&&n.dataList.length>0))},directives:[p.r,d.O5,l.BZ,l.w1,l.fO,l.ge,l.Dz,l.ev,l.as,l.XQ,l.nj,l.Gk],pipes:[d.uU],styles:[""]}),e})()},{path:"new",component:v}]}];let J=(()=>{class e{}return e.\u0275fac=function(r){return new(r||e)},e.\u0275mod=t.oAB({type:e}),e.\u0275inj=t.cJS({imports:[[d.ez,m.Bz.forChild(x),c.m]]}),e})()}}]);