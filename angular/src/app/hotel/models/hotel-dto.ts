

import { AuditedEntityDto } from '@abp/ng.core';

export class HotelDto extends AuditedEntityDto<string> {
  name: string;
  shortDescription: string;
  fullDescription: string;
  isEnabled: boolean;
  defaultPicture: string;
  displayAddress: string;
  displayLocation: string;
  hotelType: string;
  lastModificationTime?: string;
  lastModifierId?: string;
  creationTime: string;
  creatorId?: string;
  id: string;

  constructor(initialValues: Partial<HotelDto> = {}) {
    super(initialValues);
  }
}
