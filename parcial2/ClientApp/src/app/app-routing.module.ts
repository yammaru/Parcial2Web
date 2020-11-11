import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { CreditoRegistroComponent } from './Empresa/credito-registro/credito-registro.component';
import { CreditoConsultaComponent } from './Empresa/credito-consulta/credito-consulta.component';
import { AbonoConsultaComponent } from './Empresa/abono-consulta/abono-consulta.component';
import { AbonoRegistroComponent } from './Empresa/abono-registro/abono-registro.component';
const routes: Routes = [
  {
  path: 'CreditoConsulta',
  component: CreditoConsultaComponent
  },
  {
  path: 'CreditoRegistro',
  component: CreditoRegistroComponent
  },
  {
    path: 'AbonoConsulta',
    component: AbonoConsultaComponent
  },
  {
    path: 'AbonoRegistro',
  component: AbonoRegistroComponent
},
  ];


@NgModule({
  declarations: [],
  imports: [
    CommonModule, RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
