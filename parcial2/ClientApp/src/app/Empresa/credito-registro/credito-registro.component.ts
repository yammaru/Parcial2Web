import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CreditoService } from 'src/app/services/credito.service';
import { Credito } from '../models/credito';

@Component({
  selector: 'app-credito-registro',
  templateUrl: './credito-registro.component.html',
  styleUrls: ['./credito-registro.component.css']
})
export class CreditoRegistroComponent implements OnInit {
  formGroup: FormGroup;

  credito: Credito;
  constructor(private creditoService: CreditoService, private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.buildForm();
  }
  private buildForm() {
    this.credito = new Credito();
    this.credito.identificacion = '';
    this.credito.nombre = '';
    this.credito.empleados = 0;
    this.credito.activos = 0;

    this.formGroup = this.formBuilder.group({
      identificacion: [this.credito.identificacion, Validators.required],
      nombre: [this.credito.nombre, Validators.required],
      empleados: [this.credito.empleados, Validators.required],
      activos: [this.credito.activos, Validators.required],
      });
  }
  onSubmit() {
    if (this.formGroup.invalid) {
      return;
    }
    this.add();
  }
  get control() { return this.formGroup.controls; }

// aqui va la validadcion de estado
  add() {
    this.credito = this.formGroup.value;
    this.creditoService.post(this.credito).subscribe(p => {
      if (p != null) {
      alert('Credito creado!');
      this.credito = p;
      }
      });
  }

}
