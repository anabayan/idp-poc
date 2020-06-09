import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SiteComponent } from './site/site.component';
import { SpinnerComponent } from './spinner/spinner.component';
import { MultiselectComponent } from './multiselect/multiselect.component';



@NgModule({
  declarations: [SiteComponent, SpinnerComponent, MultiselectComponent],
  imports: [
    CommonModule
  ],
  exports:[
    SiteComponent
  ]
})
export class SharedModule { }
