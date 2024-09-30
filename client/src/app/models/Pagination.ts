export interface Metadata {
  totalPages: number;
  currentPage: number;
  pageSize: number;
  totalCount: number;
}

export class PaginatedList<T> {
  items: T;
  metaData: Metadata;
  constructor(items: T, metaData: Metadata) {
    this.items = items;
    this.metaData = metaData;
  }
}
