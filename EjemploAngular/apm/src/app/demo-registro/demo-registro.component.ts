import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'pm-demo-registro',
  templateUrl: './demo-registro.component.html',
  styleUrl: './demo-registro.component.css',
})
export class DemoRegistroComponent {
  formularioRegistro = new FormGroup({
    nombre: new FormControl(''),
    apellido: new FormControl(''),
    email: new FormControl(''),
    password: new FormControl(''),
  });

  onSubmit() {
    // Acceder a todo el formulario
    console.log(this.formularioRegistro.value);

    // Acceder a controles individuales
    console.log(this.formularioRegistro.get('email')?.value);

    // Reiniciar el formulario después de enviar
    this.formularioRegistro.reset();
  }
}
