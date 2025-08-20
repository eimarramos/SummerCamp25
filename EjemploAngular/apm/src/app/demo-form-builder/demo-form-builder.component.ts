import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'pm-demo-form-builder',
  templateUrl: './demo-form-builder.component.html',
  styleUrl: './demo-form-builder.component.css',
})
export class DemoFormBuilderComponent {
  // Inyectar FormBuilder
  formularioRegistro: any;

  constructor(private fb: FormBuilder) {
    // Crear formulario con FormBuilder
    this.formularioRegistro = this.fb.group({
      nombre: ['', Validators.required],
      apellido: [''],
      email: ['', [Validators.required, Validators.email]],
      direccion: this.fb.group({
        calle: [''],
        ciudad: [''],
        codigoPostal: [''],
      }),
    });
  }

  onSubmit() {
    if (this.formularioRegistro.valid) {
      console.log('Formulario enviado:', this.formularioRegistro.value);
    } else {
      console.log('Formulario no válido');
    }
  }
}
