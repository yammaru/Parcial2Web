import { Component, OnInit } from '@angular/core';
import { AbonoService } from 'src/app/services/abono.service';
import { Credito } from '../models/credito';

@Component({
  selector: 'app-abono-consulta',
  templateUrl: './abono-consulta.component.html',
  styleUrls: ['./abono-consulta.component.css']
})
export class AbonoConsultaComponent implements OnInit {
  creditos: Credito[];
  searchText: string;

  constructor( private abanoService: AbonoService) { }

  ngOnInit() {
    this.abonoService.get().subscribe(result => {
      this.creditos = result;
    });
  }

}
