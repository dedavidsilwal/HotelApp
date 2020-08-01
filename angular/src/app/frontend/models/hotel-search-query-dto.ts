

import { PagedAndSortedResultRequestDto } from '@abp/ng.core';

export class HotelSearchQueryDto extends PagedAndSortedResultRequestDto {
  address: string;
  checkIn: string;
  checkOut: string;
  adults: number;
  children: number;
  rooms: number;
  filter: string;
  sorting: string;
  skipCount: number;
  maxResultCount: number;

  constructor(initialValues: Partial<HotelSearchQueryDto> = {}) {
    super(initialValues);
  }
}
