// Core
import { SagaIterator } from '@redux-saga/core';
import { takeEvery, all, call } from 'redux-saga/effects';

// Types
import {
  BOOK_FETCH_ASYNC,
  BOOK_UPDATE_ASYNC,
  BOOK_ADD_ASYNC,
  BOOKS_DELETE_ASYNC,
} from '../types';

// Workers
import {
  fetchBooks,
  updateBook,
  addBook,
  deleteBooks,
} from './workers';

function* watchFetchBooks(): SagaIterator {
  yield takeEvery(BOOK_FETCH_ASYNC, fetchBooks);
}

function* watchUpdateBook(): SagaIterator {
  yield takeEvery(BOOK_UPDATE_ASYNC, updateBook);
}

function* watchAddBook(): SagaIterator {
  yield takeEvery(BOOK_ADD_ASYNC, addBook);
}

function* watchDeleteBooks(): SagaIterator {
  yield takeEvery(BOOKS_DELETE_ASYNC, deleteBooks);
}

export function* watchBooks(): Generator {
  yield all([
    call(watchFetchBooks),
    call(watchUpdateBook),
    call(watchAddBook),
    call(watchDeleteBooks),
  ]);
}
