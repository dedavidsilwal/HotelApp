import { RestService , PagedAndSortedResultRequestDto, PagedResultDto} from '@abp/ng.core';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CreateUpdateHotelDto, HotelDto} from '../models';

@Injectable({providedIn: 'root'})
export class HotelService {
  apiName = 'Default';

  constructor(private restService: RestService) {}

 getSearchHotelLocationBySearchTerm(searchTerm: string): Observable<string[]> {
   return this.restService.request({ url: '/api/app/hotel/searchHotelLocation', method: 'GET', params: { searchTerm } },
   { apiName: this.apiName });
 }
 createByInput(body: CreateUpdateHotelDto): Observable<HotelDto> {
   return this.restService.request({ url: '/api/app/hotel', method: 'POST', body },{ apiName: this.apiName });
 }
 updateByIdAndInput(body: CreateUpdateHotelDto, id: string): Observable<HotelDto> {
   return this.restService.request({ url: `/api/app/hotel/${id}`, method: 'PUT', body },{ apiName: this.apiName });
 }
 deleteById(id: string): Observable<void> {
   return this.restService.request({ url: `/api/app/hotel/${id}`, method: 'DELETE' },{ apiName: this.apiName });
 }
 getById(id: string): Observable<HotelDto> {
   return this.restService.request({ url: `/api/app/hotel/${id}`, method: 'GET' },{ apiName: this.apiName });
 }
 getListByInput(params = {} as PagedAndSortedResultRequestDto): Observable<PagedResultDto<HotelDto>> {
   return this.restService.request({ url: '/api/app/hotel', method: 'GET', params },{ apiName: this.apiName });
 }
}
