import { Component } from '@angular/core';
import { FormGroup, FormControl, FormArray, Validators } from '@angular/forms';
@Component({
  selector: 'pm-demo-form',
  templateUrl: './demo-form.component.html',
  styleUrl: './demo-form.component.css',
})
export class DemoFormComponent {
  // FormControl con valor inicial
  nombre = new FormControl('Juan');

  // FormControl vacío
  apellido = new FormControl('');

  actualizarNombre() {
    // Establecer valor programáticamente
    this.nombre.setValue('Carlos');
  }

  reiniciar() {
    // Restablecer al valor inicial
    this.nombre.reset();
  }
}
