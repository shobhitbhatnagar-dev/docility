/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ModuleService } from './module.service';

describe('Service: Module', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ModuleService]
    });
  });

  it('should ...', inject([ModuleService], (service: ModuleService) => {
    expect(service).toBeTruthy();
  }));
});
