import React, { useState } from 'react';
import { useGlobalContext } from '../context';
import Loading from './Loading';
import Recipe from './Recipe';

const RecipeList = () => {
  const { loading, filteredRecipes } = useGlobalContext();

  if (loading) {
    return <Loading />;
  }

  if (filteredRecipes.length < 1) {
    return (
      <h2 className='section-title push-down'>
        No Recipes matched your search criteria.
      </h2>
    );
  }
  return (
    <section className='section'>
      <h2 className='section-title recipe-title'>Recipes</h2>
      <div className='recipe-center'>
        {filteredRecipes.map((item) => {
          return <Recipe key={item.id} {...item} />;
        })}
      </div>
    </section>
  );
};

export default RecipeList;
