<?php
$MAX_DEP =10;
if(isset($_GET['direction'])&& isset($_GET["case"]))
{
    $nbCase = (int) $_GET['case'];
    if( is_int($nbCase) && $nbCase < $MAX_DEP)
    {
        for ($it=0; $it<$nbCase; $it++)
        {
            // htmlspecialchar transforme les chevrons des balises html en &lt; et &gt;
            echo htmlspecialchars($_GET['nom']) .  "va au " . htmlspecialchars($_GET['direction']) . '<br>';

            //stip_tags retires les balises 
            echo strip_tags($_GET['nom']) . 'vas au ' . strip_tags($_GET['direction ']) . '<br>';
        }
    }

}
?>