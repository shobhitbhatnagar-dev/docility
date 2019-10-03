/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { BugService } from './bug.service';

describe('Service: Bug', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [BugService]
    });
  });

  it('should ...', inject([BugService], (service: BugService) => {
    expect(service).toBeTruthy();
  }));
});
