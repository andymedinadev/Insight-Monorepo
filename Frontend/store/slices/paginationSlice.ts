import { createSlice, PayloadAction } from '@reduxjs/toolkit';

interface PaginationState {
  currentPage: number;
  totalPages: number;
}

const initialState: PaginationState = {
  currentPage: 1,
  totalPages: 1,
};

export const paginationSlice = createSlice({
  name: 'pagination',
  initialState,
  reducers: {
    setCurrentPage(state, action: PayloadAction<number>) {
      state.currentPage = action.payload;
    },
    setTotalPages(state, action: PayloadAction<number>) {
      state.totalPages = action.payload;
    },
  },
});

export const { setCurrentPage, setTotalPages } = paginationSlice.actions;
export default paginationSlice.reducer;
