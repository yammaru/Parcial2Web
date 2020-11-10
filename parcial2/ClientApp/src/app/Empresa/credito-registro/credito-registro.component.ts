import { Component, OnInit } from '@angular/core';
import { CreditoService } from 'src/app/services/credito.service';
import { Credito } from '../models/credito';

@Component({
  selector: 'app-credito-registro',
  templateUrl: './credito-registro.component.html',
  styleUrls: ['./credito-registro.component.css']
})
export class CreditoRegistroComponent implements OnInit {
credito: Credito;
  constructor(private creditoService: CreditoService) { }

  ngOnInit() {
    this.credito = new Credito;
  }
  add() {
    this.creditoService.post(this.credito).subscribe(p => {
      if (p != null) {
      alert('Persona creada!');
      this.credito = p;
      }
      });

    }
}
