import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { CreditoRegistroComponent } from './Empresa/credito-registro/credito-registro.component';
import { CreditoConsultaComponent } from './Empresa/credito-consulta/credito-consulta.component';
const routes: Routes = [
  {
  path: 'CreditoConsulta',
  component: CreditoConsultaComponent
  },
  {
  path: 'CreditoRegistro',
  component: CreditoRegistroComponent
  }
  ];


@NgModule({
  declarations: [],
  imports: [
    CommonModule, RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
