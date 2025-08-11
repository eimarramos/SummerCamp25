import { Component } from '@angular/core';

@Component({
  selector: 'pm-root',
  template: `
    <div>
      <h1>
        {{ title }}
      </h1>
      <div>Mi Primer Componente</div>
      <pm-welcome />
      <pm-counter-demo />
      <pm-card-demo />
    </div>
  `,
})
export class AppComponent {
  title = 'apm ver 1.0';
}
