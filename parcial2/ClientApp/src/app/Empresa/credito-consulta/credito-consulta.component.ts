import { Component, OnInit } from '@angular/core';
import { CreditoService } from 'src/app/services/credito.service';
import { Credito } from '../models/credito';

@Component({
  selector: 'app-credito-consulta',
  templateUrl: './credito-consulta.component.html',
  styleUrls: ['./credito-consulta.component.css']
})
export class CreditoConsultaComponent implements OnInit {
  creditos: Credito[];
  searchText: string;

  constructor(private creditoService: CreditoService) { }

  ngOnInit() {
    this.creditoService.get().subscribe(result => {
      this.creditos = result;
    });

  }

}
