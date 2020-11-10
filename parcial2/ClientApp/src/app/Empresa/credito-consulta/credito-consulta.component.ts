import { Component, OnInit } from '@angular/core';
import { Credito } from '../models/credito';

@Component({
  selector: 'app-credito-consulta',
  templateUrl: './credito-consulta.component.html',
  styleUrls: ['./credito-consulta.component.css']
})
export class CreditoConsultaComponent implements OnInit {
  creditos: Credito[];
  searchText: string;

  constructor() { }

  ngOnInit() {
    this.creditos = [
      {identificacion: '1111',  nombre: 'Juan', empleados: 5 , activos: 32222},
      {identificacion: '2222', nombre: 'Marta', empleados: 6 , activos: 32},
      ]

  }

}
