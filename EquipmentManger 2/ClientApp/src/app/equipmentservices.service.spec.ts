import { TestBed } from '@angular/core/testing';

import { EquipmentservicesService } from './equipmentservices.service';

describe('EquipmentservicesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: EquipmentservicesService = TestBed.get(EquipmentservicesService);
    expect(service).toBeTruthy();
  });
});
