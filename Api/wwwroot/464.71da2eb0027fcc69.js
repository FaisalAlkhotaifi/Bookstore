"use strict";(self.webpackChunkbookstore_web=self.webpackChunkbookstore_web||[]).push([[464],{7464:(w,C,l)=>{l.r(C),l.d(C,{AuthModule:()=>O});var e=l(9808),f=l(6074),r=l(4893);let h=(()=>{class p{constructor(){}ngOnInit(){}}return p.\u0275fac=function(s){return new(s||p)},p.\u0275cmp=r.Xpm({type:p,selectors:[["app-auth"]],decls:1,vars:0,template:function(s,c){1&s&&r._UZ(0,"router-outlet")},directives:[f.lC],styles:[""]}),p})();var n=l(2382),m=l(2601);let d=(()=>{class p{static email(){return s=>{const c=s.value;return null===c||""===c||this._emailPatternRegex.test(c)?null:{email:!0}}}}return p._emailPatternRegex=/^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i,p})();var g=l(7844),t=l(7186);let o=(()=>{class p{constructor(s){this._appHttpService=s,this.relativeUrl="",this.relativeUrl="Account"}registerAdmin(s){return this._appHttpService.postAsync(`${this.relativeUrl}/register-admin`,s)}loginAdmin(s){return this._appHttpService.postAsync(`${this.relativeUrl}/login-admin`,s)}}return p.\u0275fac=function(s){return new(s||p)(r.LFG(t.B))},p.\u0275prov=r.Yz7({token:p,factory:p.\u0275fac,providedIn:"root"}),p})();var a=l(5405),i=l(5667);let u=(()=>{class p{constructor(s,c,b){this._appFormErrorService=s,this._router=c,this._accountService=b,this.form=new n.cw({}),this.isLoading=!1}ngOnInit(){this._initForm()}hasError(s){return this._appFormErrorService.hasError(s,this.form)}getControlError(s){return this._appFormErrorService.getControlError(this.form.get(s))}onSubmit(){!this.form.valid||(this.isLoading=!0,this._accountService.loginAdmin(this.form.value).then(s=>{m.P.setAuthAccount(s),this.isLoading=!1,this._router.navigate(["dashboard"])}).catch(s=>{this.isLoading=!1,console.log("login error:",s)}))}_initForm(){this.form=new n.cw({email:new n.NI(null,[n.kI.required,d.email()]),password:new n.NI(null,[n.kI.required])})}}return p.\u0275fac=function(s){return new(s||p)(r.Y36(g.z),r.Y36(f.F0),r.Y36(o))},p.\u0275cmp=r.Xpm({type:p,selectors:[["app-login"]],decls:20,vars:9,consts:[[1,"app-content-wrap"],[1,"center-page"],[1,"auth-card-wrap"],[1,"form-wrap",3,"formGroup","ngSubmit"],[1,"row","g-4"],[1,"col-lg-12"],["formControlName","email","label","Email",3,"isRequired","hasError","errorMessage"],["formControlName","password","label","Password","type","password",3,"isRequired","hasError","errorMessage"],[1,"form-submit-wrap","row","g-4"],[1,"col-lg-12","text-center"],["title","Login",3,"disabled","isLoading"],[1,"text-center"],["routerLink","/register"]],template:function(s,c){1&s&&(r.TgZ(0,"div",0)(1,"div",1)(2,"div",2)(3,"div")(4,"h2"),r._uU(5," Login "),r.qZA()(),r.TgZ(6,"div")(7,"form",3),r.NdJ("ngSubmit",function(){return c.onSubmit()}),r.TgZ(8,"div",4)(9,"div",5),r._UZ(10,"app-text-form-field",6),r.qZA(),r.TgZ(11,"div",5),r._UZ(12,"app-text-form-field",7),r.qZA(),r.TgZ(13,"div",8)(14,"div",9),r._UZ(15,"app-button",10),r.qZA()()()()(),r.TgZ(16,"div",11),r._uU(17," Don't have an account? "),r.TgZ(18,"a",12),r._uU(19," Register "),r.qZA()()()()()),2&s&&(r.xp6(7),r.Q6J("formGroup",c.form),r.xp6(3),r.Q6J("isRequired",!0)("hasError",c.hasError("email"))("errorMessage",c.getControlError("email")),r.xp6(2),r.Q6J("isRequired",!0)("hasError",c.hasError("password"))("errorMessage",c.getControlError("password")),r.xp6(3),r.Q6J("disabled",!c.form.valid)("isLoading",c.isLoading))},directives:[n._Y,n.JL,n.sg,a.N,n.JJ,n.u,i.r,f.yS],styles:['.form-field-group-wrap[_ngcontent-%COMP%] > *[_ngcontent-%COMP%] + *[_ngcontent-%COMP%]{margin-top:.3rem}.form-field-group-wrap[_ngcontent-%COMP%]   label.form-field-require[_ngcontent-%COMP%]:after{content:" *";color:red}.form-field-group-wrap[_ngcontent-%COMP%]:focus-within   label[_ngcontent-%COMP%], .form-field-group-wrap.error-form-field[_ngcontent-%COMP%]:focus-within   label[_ngcontent-%COMP%]{color:inherit}.form-field-group-wrap.error-form-field[_ngcontent-%COMP%]   label[_ngcontent-%COMP%]{color:red}.form-field-group-wrap[_ngcontent-%COMP%]   .form-field-wrap[_ngcontent-%COMP%]{display:flex;flex-direction:row;align-items:center;flex-wrap:nowrap;padding:.75rem .85rem;gap:.5rem;border-radius:.5rem;background-color:#fff;border:thin solid #767b94}.form-field-group-wrap[_ngcontent-%COMP%]   .form-field-wrap[_ngcontent-%COMP%]   .form-field-input[_ngcontent-%COMP%]{display:block;font-weight:400;line-height:1.5;background-color:transparent;border:none;-webkit-appearance:none;appearance:none;flex-grow:1;overflow-x:auto}.form-field-group-wrap[_ngcontent-%COMP%]   .form-field-wrap[_ngcontent-%COMP%]   input.form-field-input[_ngcontent-%COMP%]:focus{outline:none}.form-field-group-wrap[_ngcontent-%COMP%]:focus-within   .form-field-wrap[_ngcontent-%COMP%], .form-field-group-wrap.error-form-field[_ngcontent-%COMP%]:focus-within   .form-field-wrap[_ngcontent-%COMP%]{border:thin solid #767b94}.form-field-group-wrap.error-form-field[_ngcontent-%COMP%]   .form-field-wrap[_ngcontent-%COMP%]{border:thin solid red}.form-field-group-wrap[_ngcontent-%COMP%]   .form-field-error-message-wrap[_ngcontent-%COMP%]{color:red;margin-top:0}']}),p})();var v=l(4395);let M=(()=>{class p{constructor(s,c,b,F){this._appFormErrorService=s,this._router=c,this._accountService=b,this._dialogService=F,this.form=new n.cw({}),this.isLoading=!1}ngOnInit(){this._initForm()}hasError(s){return this._appFormErrorService.hasError(s,this.form)}getControlError(s){return this._appFormErrorService.getControlError(this.form.get(s))}onSubmit(){!this.form.valid||(this.isLoading=!0,this._accountService.registerAdmin(this.form.value).then(()=>{this.isLoading=!1,this._openSuccessMessage()}).catch(()=>this.isLoading=!1))}ngOnDestroy(){this.dialogSubscription&&this.dialogSubscription.unsubscribe()}_initForm(){this.form=new n.cw({email:new n.NI("",[n.kI.required,d.email()]),firstName:new n.NI("",[n.kI.required]),lastName:new n.NI("",[n.kI.required]),password:new n.NI("",[n.kI.required])})}_openSuccessMessage(){this.dialogSubscription=this._dialogService.openSuccess("Account has been created successfully").subscribe(()=>{this._router.navigate(["login"])})}}return p.\u0275fac=function(s){return new(s||p)(r.Y36(g.z),r.Y36(f.F0),r.Y36(o),r.Y36(v.j))},p.\u0275cmp=r.Xpm({type:p,selectors:[["app-register"]],decls:24,vars:15,consts:[[1,"app-content-wrap"],[1,"center-page"],[1,"auth-card-wrap"],[1,"form-wrap",3,"formGroup","ngSubmit"],[1,"row","g-4"],[1,"col-lg-12"],["formControlName","email","label","Email",3,"isRequired","hasError","errorMessage"],["formControlName","firstName","label","First Name",3,"isRequired","hasError","errorMessage"],["formControlName","lastName","label","Last Name",3,"isRequired","hasError","errorMessage"],["formControlName","password","label","Password","type","password",3,"isRequired","hasError","errorMessage"],[1,"form-submit-wrap","row","g-4"],[1,"col-lg-12","text-center"],["title","Register",3,"disabled","isLoading"],[1,"text-center"],["routerLink","/login"]],template:function(s,c){1&s&&(r.TgZ(0,"div",0)(1,"div",1)(2,"div",2)(3,"div")(4,"h2"),r._uU(5," Register "),r.qZA()(),r.TgZ(6,"div")(7,"form",3),r.NdJ("ngSubmit",function(){return c.onSubmit()}),r.TgZ(8,"div",4)(9,"div",5),r._UZ(10,"app-text-form-field",6),r.qZA(),r.TgZ(11,"div",5),r._UZ(12,"app-text-form-field",7),r.qZA(),r.TgZ(13,"div",5),r._UZ(14,"app-text-form-field",8),r.qZA(),r.TgZ(15,"div",5),r._UZ(16,"app-text-form-field",9),r.qZA(),r.TgZ(17,"div",10)(18,"div",11),r._UZ(19,"app-button",12),r.qZA()()()()(),r.TgZ(20,"div",13),r._uU(21," You do have an account? "),r.TgZ(22,"a",14),r._uU(23," Login "),r.qZA()()()()()),2&s&&(r.xp6(7),r.Q6J("formGroup",c.form),r.xp6(3),r.Q6J("isRequired",!0)("hasError",c.hasError("email"))("errorMessage",c.getControlError("email")),r.xp6(2),r.Q6J("isRequired",!0)("hasError",c.hasError("firstName"))("errorMessage",c.getControlError("firstName")),r.xp6(2),r.Q6J("isRequired",!0)("hasError",c.hasError("lastName"))("errorMessage",c.getControlError("lastName")),r.xp6(2),r.Q6J("isRequired",!0)("hasError",c.hasError("password"))("errorMessage",c.getControlError("password")),r.xp6(3),r.Q6J("disabled",!c.form.valid)("isLoading",c.isLoading))},directives:[n._Y,n.JL,n.sg,a.N,n.JJ,n.u,i.r,f.yS],styles:['.form-field-group-wrap[_ngcontent-%COMP%] > *[_ngcontent-%COMP%] + *[_ngcontent-%COMP%]{margin-top:.3rem}.form-field-group-wrap[_ngcontent-%COMP%]   label.form-field-require[_ngcontent-%COMP%]:after{content:" *";color:red}.form-field-group-wrap[_ngcontent-%COMP%]:focus-within   label[_ngcontent-%COMP%], .form-field-group-wrap.error-form-field[_ngcontent-%COMP%]:focus-within   label[_ngcontent-%COMP%]{color:inherit}.form-field-group-wrap.error-form-field[_ngcontent-%COMP%]   label[_ngcontent-%COMP%]{color:red}.form-field-group-wrap[_ngcontent-%COMP%]   .form-field-wrap[_ngcontent-%COMP%]{display:flex;flex-direction:row;align-items:center;flex-wrap:nowrap;padding:.75rem .85rem;gap:.5rem;border-radius:.5rem;background-color:#fff;border:thin solid #767b94}.form-field-group-wrap[_ngcontent-%COMP%]   .form-field-wrap[_ngcontent-%COMP%]   .form-field-input[_ngcontent-%COMP%]{display:block;font-weight:400;line-height:1.5;background-color:transparent;border:none;-webkit-appearance:none;appearance:none;flex-grow:1;overflow-x:auto}.form-field-group-wrap[_ngcontent-%COMP%]   .form-field-wrap[_ngcontent-%COMP%]   input.form-field-input[_ngcontent-%COMP%]:focus{outline:none}.form-field-group-wrap[_ngcontent-%COMP%]:focus-within   .form-field-wrap[_ngcontent-%COMP%], .form-field-group-wrap.error-form-field[_ngcontent-%COMP%]:focus-within   .form-field-wrap[_ngcontent-%COMP%]{border:thin solid #767b94}.form-field-group-wrap.error-form-field[_ngcontent-%COMP%]   .form-field-wrap[_ngcontent-%COMP%]{border:thin solid red}.form-field-group-wrap[_ngcontent-%COMP%]   .form-field-error-message-wrap[_ngcontent-%COMP%]{color:red;margin-top:0}']}),p})();var P=l(333);const E=[{path:"",component:h,children:[{path:"",redirectTo:"/login",pathMatch:"full"},{path:"login",component:u},{path:"register",component:M}]}];let O=(()=>{class p{}return p.\u0275fac=function(s){return new(s||p)},p.\u0275mod=r.oAB({type:p}),p.\u0275inj=r.cJS({imports:[[e.ez,f.Bz.forChild(E),P.m]]}),p})()},7186:(w,C,l)=>{l.d(C,{B:()=>m});var e=l(6805),r=l(2340),h=l(4893),n=l(520);let m=(()=>{class d{constructor(t){this._http=t,this.baseUrl="",this.baseUrl=r.N.api.baseUrl}get(t,o){return this._http.get(this._getUrl(t),o)}getAsnyc(t,o){const a=this._http.get(this._getUrl(t),o);return this._convertToPromise(a)}post(t,o={},a){return this._http.post(this._getUrl(t),o,a)}postAsync(t,o={},a){const i=this._http.post(this._getUrl(t),o,a);return this._convertToPromise(i)}patch(t,o={},a){return this._http.patch(this._getUrl(t),o,a)}patchAsnyc(t,o={},a){const i=this._http.patch(this._getUrl(t),o,a);return this._convertToPromise(i)}delete(t,o){return this._http.delete(this._getUrl(t),o)}deleteAsync(t,o){const a=this._http.delete(this._getUrl(t),o);return this._convertToPromise(a)}_getUrl(t){return`${this.baseUrl}/${t}`}_convertToPromise(t){return new Promise((o,a)=>{(function f(d,g){const t="object"==typeof g;return new Promise((o,a)=>{let u,i=!1;d.subscribe({next:v=>{u=v,i=!0},error:a,complete:()=>{i?o(u):t?o(g.defaultValue):a(new e.K)}})})})(t).then(i=>{o(i)}).catch(i=>{a(i.message)})})}}return d.\u0275fac=function(t){return new(t||d)(h.LFG(n.eN))},d.\u0275prov=h.Yz7({token:d,factory:d.\u0275fac,providedIn:"root"}),d})()},7844:(w,C,l)=>{l.d(C,{z:()=>f});var e=l(4893);let f=(()=>{class r{constructor(){}hasError(n,m){const d=m.get(n);return!!d&&d.invalid&&d.touched}getControlError(n){if(n){if(!n.invalid||!n.touched)return null;if(n&&n.hasError("required"))return"Field is required";if(n.hasError("email"))return"Email not valid"}return null}}return r.\u0275fac=function(n){return new(n||r)},r.\u0275prov=e.Yz7({token:r,factory:r.\u0275fac,providedIn:"root"}),r})()},5667:(w,C,l)=>{l.d(C,{r:()=>n});var e=l(4893),f=l(9808);function r(m,d){if(1&m&&(e.ynx(0),e._uU(1),e.BQk()),2&m){const g=e.oxw();let t;e.xp6(1),e.hij(" ",null!==(t=g.title)&&void 0!==t?t:"Button"," ")}}function h(m,d){1&m&&(e.ynx(0),e._UZ(1,"i",2),e.BQk())}let n=(()=>{class m{constructor(){this.disabled=!1,this.isLoading=!1,this.type="submit",this.click=new e.vpe}ngOnInit(){}onClick(g){g.stopPropagation(),this.click.emit(g)}}return m.\u0275fac=function(g){return new(g||m)},m.\u0275cmp=e.Xpm({type:m,selectors:[["app-button"]],inputs:{title:"title",disabled:"disabled",isLoading:"isLoading",type:"type"},outputs:{click:"click"},decls:3,vars:4,consts:[[1,"btn","btn-primary",3,"type","disabled","click"],[4,"ngIf"],[1,"fas","fa-circle-notch","fa-spin","fa-lg"]],template:function(g,t){1&g&&(e.TgZ(0,"button",0),e.NdJ("click",function(a){return t.onClick(a)}),e.YNc(1,r,2,1,"ng-container",1),e.YNc(2,h,2,0,"ng-container",1),e.qZA()),2&g&&(e.Q6J("type",t.type)("disabled",t.disabled||t.isLoading),e.xp6(1),e.Q6J("ngIf",!t.isLoading),e.xp6(1),e.Q6J("ngIf",t.isLoading))},directives:[f.O5],styles:[""]}),m})()},683:(w,C,l)=>{l.d(C,{n:()=>g});var e=l(4893),f=l(9808);const r=function(t){return{"form-field-require":t}};function h(t,o){if(1&t&&(e.TgZ(0,"label",4),e._uU(1),e.qZA()),2&t){const a=e.oxw();e.Q6J("for",a.idForLabel)("ngClass",e.VKq(3,r,a.isRequired)),e.xp6(1),e.hij(" ",a.label," ")}}function n(t,o){if(1&t&&(e.TgZ(0,"div",5)(1,"span"),e._uU(2),e.qZA()()),2&t){const a=e.oxw();e.xp6(2),e.hij(" ",a.errorMessage," ")}}const m=function(t){return{"error-form-field":t}},d=["*"];let g=(()=>{class t{constructor(){this.hasError=!1,this.idForLabel="",this.isRequired=!1,this.errorMessage=null}ngOnInit(){}}return t.\u0275fac=function(a){return new(a||t)},t.\u0275cmp=e.Xpm({type:t,selectors:[["app-form-field-container"]],inputs:{hasError:"hasError",label:"label",idForLabel:"idForLabel",isRequired:"isRequired",errorMessage:"errorMessage"},ngContentSelectors:d,decls:5,vars:5,consts:[[1,"form-field-group-wrap",3,"ngClass"],["class","app-clr-steel",3,"for","ngClass",4,"ngIf"],[1,"form-field-wrap"],["class","form-field-error-message-wrap app-text-small",4,"ngIf"],[1,"app-clr-steel",3,"for","ngClass"],[1,"form-field-error-message-wrap","app-text-small"]],template:function(a,i){1&a&&(e.F$t(),e.TgZ(0,"div",0),e.YNc(1,h,2,5,"label",1),e.TgZ(2,"div",2),e.Hsn(3),e.qZA(),e.YNc(4,n,3,1,"div",3),e.qZA()),2&a&&(e.Q6J("ngClass",e.VKq(3,m,i.hasError)),e.xp6(1),e.Q6J("ngIf",i.label),e.xp6(3),e.Q6J("ngIf",i.errorMessage))},directives:[f.mk,f.O5],styles:[""]}),t})()},5405:(w,C,l)=>{l.d(C,{N:()=>t});var e=l(4893),f=l(2382),r=l(683),h=l(9808);function n(o,a){if(1&o&&e._UZ(0,"i",4),2&o){const i=e.oxw();e.Q6J("ngClass",i.prefixFontAwesomeIconClass)}}function m(o,a){if(1&o&&e._UZ(0,"i",4),2&o){const i=e.oxw();e.Q6J("ngClass",i.postfixFontAwesomeIconClass)}}const d=function(o,a){return{"show-text-icon":o,"hide-text-icon":a}};function g(o,a){if(1&o){const i=e.EpF();e.TgZ(0,"i",5),e.NdJ("click",function(){return e.CHM(i),e.oxw().togglePassordVisibility()}),e.qZA()}if(2&o){const i=e.oxw();e.Q6J("ngClass",e.WLB(1,d,!i.isShowingPassword,i.isShowingPassword))}}let t=(()=>{class o{constructor(){this.type="text",this.placeholder="",this.isRequired=!1,this.isShowingPasswordPostfix=!1,this.hasError=!1,this.errorMessage=null,this.isDisables=!1,this.value="",this.valueChange=new e.vpe,this.disabled=!1,this.onChange=i=>{},this.onTouched=()=>{},this.isShowingPassword=!1}get idForLabel(){return this.label?`input-${this.label.split(" ").join("_")}`:`input-${this.type}`}get inputDirClass(){if(this.testLang){if("ar"===this.testLang)return"dir-rtl";if("en"===this.testLang)return"dir-ltr"}return"dir-auto"}ngOnInit(){}writeValue(i){this.value=i}registerOnChange(i){this.onChange=i}registerOnTouched(i){this.onTouched=i}setDisabledState(i){this.disabled=i}togglePassordVisibility(){this.isShowingPassword=!this.isShowingPassword,this.type=this.isShowingPassword?"text":"password"}onValueChange(i){this.onTouched(),this.value=i,this.onChange(i),this.valueChange.emit(this.value)}}return o.\u0275fac=function(i){return new(i||o)},o.\u0275cmp=e.Xpm({type:o,selectors:[["app-text-form-field"]],inputs:{label:"label",type:"type",placeholder:"placeholder",isRequired:"isRequired",prefixFontAwesomeIconClass:"prefixFontAwesomeIconClass",postfixFontAwesomeIconClass:"postfixFontAwesomeIconClass",isShowingPasswordPostfix:"isShowingPasswordPostfix",hasError:"hasError",errorMessage:"errorMessage",testLang:"testLang",isDisables:"isDisables",value:"value"},outputs:{valueChange:"valueChange"},features:[e._Bn([{provide:f.JU,useExisting:(0,e.Gpc)(()=>o),multi:!0}])],decls:5,vars:14,consts:[[3,"label","hasError","idForLabel","isRequired","errorMessage"],[3,"ngClass",4,"ngIf"],[1,"form-field-input",3,"ngClass","type","ngModel","placeholder","id","disabled","ngModelChange"],[3,"ngClass","click",4,"ngIf"],[3,"ngClass"],[3,"ngClass","click"]],template:function(i,u){1&i&&(e.TgZ(0,"app-form-field-container",0),e.YNc(1,n,1,1,"i",1),e.TgZ(2,"input",2),e.NdJ("ngModelChange",function(M){return u.value=M})("ngModelChange",function(M){return u.onValueChange(M)}),e.qZA(),e.YNc(3,m,1,1,"i",1),e.YNc(4,g,1,4,"i",3),e.qZA()),2&i&&(e.Q6J("label",u.label)("hasError",u.hasError)("idForLabel",u.idForLabel)("isRequired",u.isRequired)("errorMessage",u.errorMessage),e.xp6(1),e.Q6J("ngIf",u.prefixFontAwesomeIconClass),e.xp6(1),e.Q6J("ngClass",u.inputDirClass)("type",u.type)("ngModel",u.value)("placeholder",u.placeholder)("id",u.idForLabel)("disabled",u.isDisables),e.xp6(1),e.Q6J("ngIf",u.postfixFontAwesomeIconClass),e.xp6(1),e.Q6J("ngIf",u.isShowingPasswordPostfix))},directives:[r.n,h.O5,h.mk,f.Fj,f.JJ,f.On],styles:[""]}),o})()}}]);