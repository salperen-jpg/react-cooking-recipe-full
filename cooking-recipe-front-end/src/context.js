import React, { useState, useEffect, useContext } from 'react';

const url = 'http://localhost:20068/api/Recipes/getallrecipe';
const AppContext = React.createContext();

const AppProvider = ({ children }) => {
  const [loading, setLoading] = useState(false);
  const [searchTerm, setSearchTerm] = useState('');
  const [recipes, setRecipes] = useState([]);

  const filteredRecipes = recipes.filter((recipe) => {
    return recipe.name.toLowerCase().includes(searchTerm.toLowerCase());
  });

  const call = async () => {
    try {
      const res = await fetch(
        'http://localhost:20068/api/Recipes/getallrecipe'
      );
      const data = await res.json();
      setRecipes(data);
    } catch (err) {
      console.log(err);
    }
  };

  useEffect(() => {
    call();
  }, []);

  return (
    <AppContext.Provider
      value={{
        loading,
        recipes,
        setSearchTerm,
        filteredRecipes,
      }}
    >
      {children}
    </AppContext.Provider>
  );
};

export const useGlobalContext = () => {
  return useContext(AppContext);
};

export { AppContext, AppProvider };
